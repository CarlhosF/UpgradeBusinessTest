using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;
using UpgradeBusinessTest._03.Persistences;
using UpgradeBusinessTest._05.Views;
using UpgradeBusinessTest._05.Views.Invoices;
using UpgradeBusinessTest._05.Views.Products;

namespace UpgradeBusinessTest
{
    internal static class Program
    {
        private static ServiceCollection _serviceCollection = new();
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Configure(_serviceCollection);
            using var serviceProvider = _serviceCollection.BuildServiceProvider();
            var main = serviceProvider.GetRequiredService<Main>();
            Application.Run(main);
        }

        private static void Configure(IServiceCollection services)
        {            
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true)
            .Build();
            #region Services
            services.AddPersistence(configuration);
            #endregion
            #region Forms
            services.AddScoped<Main>();
            services.AddScoped<InvoiceGestor>();
            services.AddScoped<ProductManager>();
            services.AddScoped<ViewClientesAndInvoices>();
            #endregion
            _serviceCollection = (ServiceCollection)services;
        }
    }
}
