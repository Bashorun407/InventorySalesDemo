using InventorySales.CoreServiceContract.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInSaleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductInSaleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductInSale() 
        {
            var productsInSale = await _serviceManager.ProductInSaleService.GetAllProductInSaleAsync(trackChanges: false);
            return Ok(productsInSale);
        }
    }
}
