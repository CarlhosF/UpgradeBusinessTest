using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using UpgradeBusinessTest._02.Core.Wrappers;

namespace UpgradeBusinessTest._02.Core.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        void ReloadContext();
        void Detach(TEntity entity);
        void Dispose();
        Task<TEntity> GetByIdAsyng(object id);
        Task<IReadOnlyCollection<TEntity>> GetAllAsyng(Expression<Func<TEntity, bool>>? filter = null, string include = "");
        Task<IReadOnlyCollection<TEntity>> GetAllAsyng();
        Task<PageWrapper<IReadOnlyList<TEntity>>> GetPageResponseAsync(int pageNumber, int pageSize, Expression<Func<TEntity, bool>>? filter = null, string include = "");        
        Task<string> Create(TEntity entity, Action<Exception>? exceptionHandler = null);
        Task<string> Update(TEntity entity, Action<Exception>? exceptionHandler = null);
        Task<bool> Delete(object entity, Action<Exception>? exceptionHandler = null);
        Task<bool> Delete(Expression<Func<TEntity, bool>> filter, Action<Exception>? exceptionHandler = null);
        Task<bool> Delete(TEntity entity, Action<Exception>? exceptionHandler = null);
    }

}
