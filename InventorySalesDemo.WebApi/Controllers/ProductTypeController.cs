using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ProductTypeController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public void CreateProductType(ProductTypeDtoForCreation productType)
        {
            _serviceManager.ProductTypeService.CreateProductType(productType);
        }

        [HttpDelete]
        public void DeleteProductType(int id)
        {
            _serviceManager.ProductTypeService.DeleteProductType(id, trackChanges: false);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductType() 
        {
            var productTypes = await _serviceManager.ProductTypeService.GetAllProductTypeAsync(trackChanges: false);
            return Ok(productTypes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductTypeById(int id)
        {
            var productType = await _serviceManager.ProductTypeService.GetProductTypeByIdAsync(id, trackChanges: false);
            return Ok(productType);
        }

        [HttpPut]
        public void UpdateProductType(int id, ProductTypeDtoForUpdate productType)
        {
            _serviceManager.ProductTypeService.UpdateProductType(id, productType, trackChanges: false);
        }
    }
}
