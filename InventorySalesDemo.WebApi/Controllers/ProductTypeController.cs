using InventorySalesDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductTypeController(IServiceManager service)
        {
            _serviceManager = service;            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductType() 
        {
            var productTypes = await _serviceManager.ProductTypeService.GetAllProductTypeAsync(trackChanges: false);
            return Ok(productTypes);
        }
    }
}
