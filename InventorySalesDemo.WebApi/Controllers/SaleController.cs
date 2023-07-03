using InventorySalesDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public SaleController(IServiceManager service)
        {
            _serviceManager = service;            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSaleAsync() 
        {
            var sales = await _serviceManager.SaleService.GetAllSaleAsync(trackChanges: false);
            return Ok(sales);
        }
    }
}
