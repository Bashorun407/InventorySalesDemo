using InventorySales.CoreServiceContract.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
public SaleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSales()
        {
            var sales = await _serviceManager.SaleService.GetAllSalesAsync(trackChanges: false);
            return Ok(sales);
        }
    }
}
