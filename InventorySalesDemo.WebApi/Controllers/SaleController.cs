using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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
        [HttpPost]
        public void CreateSale(SaleForCreationDto saleForCreationDto)
        {
            _serviceManager.SaleService.CreateSaleAsync(saleForCreationDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSaleAsync() 
        {
            var sales = await _serviceManager.SaleService.GetAllSaleAsync(trackChanges: false);
            return Ok(sales);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetSaleById(int Id)
        {
            var sales = await _serviceManager.SaleService.GetSaleAsync(Id, trackChanges: false);
            return Ok(sales);
        }
        [HttpDelete]
        public void DeleteSale(int Id)
        {
            _serviceManager.SaleService.DeleteSaleAsync(Id, trackChanges: false);
        }
        [HttpPut]
        public void UpdateSale(int Id, SaleForUpdateDto saleForUpdateDto)
        {
            _serviceManager.SaleService.UpdateSaleAsync(Id, saleForUpdateDto, trackChanges: false);
        }
    }
}
