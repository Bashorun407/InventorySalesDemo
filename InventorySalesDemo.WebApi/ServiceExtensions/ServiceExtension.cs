using InventorySalesDemo.Application.Common;
using System.Runtime.CompilerServices;

namespace InventorySalesDemo.WebApi.ServiceExtensions
{
    public static class ServiceExtension
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, IRepositoryManager>();
        }
    }
}
