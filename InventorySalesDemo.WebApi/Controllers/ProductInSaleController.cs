using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductInSaleController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductInSaleController(IServiceManager service)
        {
            _serviceManager = service;                        
        }
        [HttpPost]
        public void CreateProductInSale(ProductInSaleForCreationDto productInSaleForCreationDto)
        {
            _serviceManager.ProductInSaleService.CreateProductInSaleAsync(productInSaleForCreationDto); 
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductInSale() 
        {
            var productInSales = await _serviceManager.ProductInSaleService.GetAllProductInSaleAsync(trackChanges: false);
            return Ok(productInSales);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductInSale(int Id)
        {
            var productInSales = await _serviceManager.ProductInSaleService.GetProductInSaleAsync(Id, trackChanges: false);
            return Ok(productInSales);
        }
        [HttpDelete]
        public void DeleteProductInSale(int Id)
        {
            _serviceManager.ProductInSaleService.DeleteProductInSaleAsync(Id, trackChanges: false);
        }
        [HttpPut]
        public void UpdateProductInSale(int Id, ProductInSaleForUpdateDto productInSaleForUpdateDto)
        {
            _serviceManager.ProductInSaleService.UpdateProductInSaleAsync(Id, productInSaleForUpdateDto, trackChanges: false);
        }
    }
}
