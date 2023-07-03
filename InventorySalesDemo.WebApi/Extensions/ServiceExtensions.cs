using InventorySalesDemo.Application.Common;
using InventorySalesDemo.Persistence.Common;
using InventorySalesDemo.ServiceContract.Interfaces;
using InventorySalesDemo.ServiceRepository.Services;
using LoggerService;
using Microsoft.EntityFrameworkCore;

namespace InventorySalesDemo.WebApi.Extensions
{
    public static class ServiceExtensions
    {
        //Configuration of CORS for giving access rights to applications from different domains
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

        //Configuration of IIS Integration for accpting requests from remote client computers and returns the appropriate response
        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options => { });
        }

        //Configuration of the Logger Service
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        //Congiguration of the RepositoryManager
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        //Configuration of the Service Manager
        public static void ConfigureServiceManager(this IServiceCollection services) => services.AddScoped<IServiceManager, ServiceManager>();

        //Configuration of DbContext and Sql Connection
        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<RepositoryContext>(opt =>
                                                                                                                                                                                                                                opt.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
