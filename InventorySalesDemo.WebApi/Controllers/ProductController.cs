using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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
        [HttpPost]
        public void CreateProduct(ProductForCreationDto productForCreationDto)
        {
            _servicesManager.ProductService.CreateProductAsync(productForCreationDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductAsync() 
        {
            var products = await _servicesManager.ProductService.GetAllProductAsync(trackChanges: false);
            return Ok(products);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProduct(int Id)
        {
            var products = await _servicesManager.ProductService.GetProductByIdAsync(Id, trackChanges: false);
            return Ok(products);
        }
        [HttpDelete]
        public void DeleteProduct(int Id)
        {
            _servicesManager.ProductService.DeleteProductAsync(Id, trackChanges: false);
        }
        [HttpPut]
        public void UpdateProductAsync(int Id, ProductForUpdateDto productForUpdateDto)
        {
            _servicesManager.ProductService.UpdateProductAsync(Id, productForUpdateDto, trackChanges: false);
        }
    }
}
