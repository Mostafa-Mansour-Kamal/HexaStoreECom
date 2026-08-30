using HexaStoreECom.DataAccess;
using HexaStoreECom.DataAccess.DataSeed;
using HexaStoreECom.DataAccess.DbInitializer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HexaStoreECom.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            // تنفيذ الـ Seeding والـ Initialization عند تشغيل التطبيق
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    // 1. تشغيل الـ DbInitializer لإنشاء الـ Roles وحساب الـ Admin والـ Migrations
                    var dbInitializer = services.GetRequiredService<IDbInitializer>();
                    dbInitializer.Initialize();

                    // 2. تشغيل تغذية الأقسام والمنتجات من ملفات الـ JSON
                    var dbContext = services.GetRequiredService<ApplicationDbContext>();
                    await DataSeedingContext.CategoryDataSeed(dbContext);
                    await DataSeedingContext.ProductsDataSeed(dbContext);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while feeding the database with raw data (Data Seeding).");
                }
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}