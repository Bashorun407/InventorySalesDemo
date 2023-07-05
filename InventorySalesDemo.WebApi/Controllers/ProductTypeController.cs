using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
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
        [HttpPost]
        public void CreateProductType(ProductTypeForCreationDto productTypeForCreationDto)
        {
            _serviceManager.ProductTypeService.CreateProductTypeAsync(productTypeForCreationDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProductType() 
        {
            var productTypes = await _serviceManager.ProductTypeService.GetAllProductTypeAsync(trackChanges: false);
            return Ok(productTypes);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetProductTypeById(int Id)
        {
            var productTypes = await _serviceManager.ProductTypeService.GetProductTypeByIdAsync(Id, trackChanges: false);
            return Ok(productTypes);
        }
        [HttpDelete]
        public void DeleteProductType(int Id)
        {
            _serviceManager.ProductTypeService.DeleteProductTypeAsync(Id, trackChanges: false);
        }
        [HttpPut]
        public void UpdateProductType(int Id, ProductTypeForUpdateDto productTypeForUpdateDto)
        {
            _serviceManager.ProductTypeService.UpdateProductTypeAsync(Id, productTypeForUpdateDto, trackChanges: false);
        }
    }
}
