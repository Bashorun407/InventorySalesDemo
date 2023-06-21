using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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

        [HttpPost]
        public void CreateProductInSale(ProductInSaleDtoForCreation product)
        {
            _serviceManager.ProductInSaleService.CreateProductInSale(product);
        }

        [HttpDelete]
        public void DeleteProductInSale(int id)
        {
            _serviceManager.ProductInSaleService.DeleteProductInSale(id, trackChanges: false);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductInSale() 
        {
            var productsInSale = await _serviceManager.ProductInSaleService.GetAllProductInSaleAsync(trackChanges: false);
            return Ok(productsInSale);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductInSaleById(int id)
        {
            var productToReturn = await _serviceManager.ProductInSaleService.GetProductInSaleById(id, trackChanges: false);
            return Ok(productToReturn);
        }

        [HttpPut]
        public void UpdateProductInSale(int id, ProductInSaleDtoForUpdate product)
        {
            _serviceManager.ProductInSaleService.UpdateProductInSale(id, product, trackChanges: false);
        }
    }
}
