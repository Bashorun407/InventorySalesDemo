using InventorySales.CoreServiceContract.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() 
        {
            var products = await _serviceManager.ProductService.GetAllProductsAsync(trackChanges: false);
            return Ok(products);
        }
    }
}
