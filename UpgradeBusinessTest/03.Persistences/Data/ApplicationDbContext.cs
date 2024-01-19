using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UpgradeBusinessTest._01.Domain.Entities;

namespace UpgradeBusinessTest._03.Persistences.Data
{
    public  class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceHeader> InvoiceHeaders { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("UpgradeBusinessTest"));
        }
    }
}
