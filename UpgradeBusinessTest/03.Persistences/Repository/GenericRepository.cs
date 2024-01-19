using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UpgradeBusinessTest._02.Core.Exceptions;
using UpgradeBusinessTest._02.Core.Interfaces;
using UpgradeBusinessTest._02.Core.Wrappers;
using UpgradeBusinessTest._03.Persistences.Data;

namespace UpgradeBusinessTest._03.Persistences.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class        
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            if (_dbSet == null) throw new RepositoryException($"Entity Not found in the DbContext");
        }
        public async Task<TEntity> GetByIdAsyng(object id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IReadOnlyCollection<TEntity>> GetAllAsyng(Expression<Func<TEntity, bool>>? filter = null, string include = "")
        {
            var queryable = _dbSet.AsNoTracking();
            if (filter != null) queryable = queryable.Where(filter);
            queryable = include.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Aggregate(queryable, (current, includeProperty) => current.Include(includeProperty));
            return await queryable.ToListAsync();
        }
        public async Task<IReadOnlyCollection<TEntity>> GetAllAsyng()
        {
            var queryable = _dbSet.AsNoTracking();
            return await queryable.ToListAsync();
        }
        public async Task<PageWrapper<IReadOnlyList<TEntity>>> GetPageResponseAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>>? filter = null, string include = "")
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            if (filter != null) query = query.Where(filter);
            query = include.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            int totalRecords = query.Count();

            query = query.Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking();

            return new PageWrapper<IReadOnlyList<TEntity>>()
            {
                TotalRecords = totalRecords,
                TotalPage = totalRecords / pageSize,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                Data = await query.ToListAsync()
            };
        }
        public async Task<string> Create(TEntity entity, Action<Exception>? exceptionHandler = null)
        {
            try
            {
                var response = await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                Detach(entity);
                return response.ToString();
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
                ReloadContext();
                return string.Empty;
            }
        }
        public void Detach(TEntity entity)
        {
            var entry = _context.Entry(entity);
            if (entry == null) throw new RepositoryException($"{entity.GetType().Name} Not found in the DbContext");
            entry.State = EntityState.Detached;
        }
        public async Task<string> Update(TEntity entity, Action<Exception>? exceptionHandler = null)
        {
            try
            {
                var response = _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                Detach(entity);
                return response.ToString();
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
                ReloadContext();
                return string.Empty;
            }
        }

        public async Task<bool> Delete(object entityId, Action<Exception>? exceptionHandler = null)
        {
            try
            {
                var entity = await _context.Set<TEntity>().FindAsync(entityId);
                var response = _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
                ReloadContext();
                return false;
            }
        }
        public async Task<bool> Delete(Expression<Func<TEntity, bool>> filter, Action<Exception>? exceptionHandler = null)
        {
            try
            {
                IQueryable<TEntity> queryable = _dbSet;
                queryable = queryable.Where(filter);
                var dataToDelete = await queryable.ToListAsync();
                _context.Set<TEntity>().RemoveRange(dataToDelete);
                return true;
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
                ReloadContext();
                return false;
            }
        }

        public async Task<bool> Delete(TEntity entity, Action<Exception>? exceptionHandler = null)
        {
            try
            {
                var response = _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                exceptionHandler?.Invoke(ex);
                ReloadContext();
                return false;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void ReloadContext()
        {
            foreach (var entry in _context.ChangeTracker.Entries())
            {
                entry.State = EntityState.Detached;
            }
        }
    }
}
