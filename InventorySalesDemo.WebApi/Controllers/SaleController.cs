using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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

        [HttpPost]
        public void CreateSale(SaleDtoForCreation saleDtoForCreation)
        {
            _serviceManager.SaleService.CreateSale(saleDtoForCreation);
        }

        [HttpDelete]
        public void DeleteSale(int id)
        {
            _serviceManager.SaleService.DeleteSale(id, trackChanges: false);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSales()
        {
            var sales = await _serviceManager.SaleService.GetAllSalesAsync(trackChanges: false);
            return Ok(sales);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSaleByIdAsync(int id) 
        {
            var sale =  await _serviceManager.SaleService.GetSaleByIdAsync(id, trackChanges: false);
            return Ok(sale);
        }

        [HttpPut]
        public void UpdateSale(int id, SaleDtoForUpdate saleDtoForUpdate)
        {
            _serviceManager.SaleService.UpdateSale(id, saleDtoForUpdate, trackChanges: false);
        }
    }
}
