using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Persistence.Common;
using InventorySalesDemo.ServiceRepository.Common;
using LoggerService;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace InventorySalesDemo.WebApi.ServiceExtensions
{
    public static class ServiceExtension
    {
       
        public static void ConfigureCors(this IServiceCollection services) 
        {
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(option => { });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(opt =>
                    opt.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
    }

}
