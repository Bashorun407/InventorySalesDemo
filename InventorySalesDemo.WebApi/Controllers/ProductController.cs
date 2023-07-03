using InventorySalesDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _servicesManager;

        public ProductController(IServiceManager service)
        {
            _servicesManager = service;            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync() 
        {
            var products = await _servicesManager.ProductService.GetAllProductAsync(trackChanges: false);
            return Ok(products);
        }
    }
}
