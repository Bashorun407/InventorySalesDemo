using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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

        [HttpPost]
        public void CreateProduct(ProductDtoForCreation product)
        {
            _serviceManager.ProductService.CreateProduct(product);
        }

        [HttpDelete]
        public void DeleteProduct(int id)
        {
            _serviceManager.ProductService.DeleteProduct(id, trackChanges: false);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _serviceManager.ProductService.GetProductByIdAsync(id, trackChanges: false);
            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() 
        {
            var products = await _serviceManager.ProductService.GetAllProductsAsync(trackChanges: false);
            return Ok(products);
        }

        [HttpPut]
        public void UpdateProduct(int id, ProductDtoForUpdate product)
        {
            _serviceManager.ProductService.UpdateProduct(id, product, trackChanges: false);
        }
    }
}
