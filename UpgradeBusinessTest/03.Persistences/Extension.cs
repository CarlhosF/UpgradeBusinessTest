using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UpgradeBusinessTest._02.Core.Interfaces;
using UpgradeBusinessTest._03.Persistences.Data;
using UpgradeBusinessTest._03.Persistences.Repository;

namespace UpgradeBusinessTest._03.Persistences
{
    public static class Extension
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.BuildServiceProvider();
            services.AddDbContext<ApplicationDbContext>(builder => {
                builder.UseSqlServer(configuration?["sql:cn"]);
                builder.EnableSensitiveDataLogging();
            });  
            
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}
