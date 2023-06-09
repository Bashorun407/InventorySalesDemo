using InventorySalesDemo.Application.Common;

namespace InventorySalesDemo.WebApi.ServiceExtensions
{
    public static class ExceptionMiddleWareExtension
    {
        public static void ConfigureExceptionHandler(this WebApplication app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError => { });
        }
    }
}

