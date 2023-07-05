using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface IProductTypeService
    {
        Task<IEnumerable<ProductTypeForDisplayDto>> GetAllProductTypeAsync(bool trackChanges);
        Task<ProductTypeForDisplayDto> GetProductTypeByIdAsync(int Id, bool trackChanges);
        Task<ProductTypeForDisplayDto> CreateProductTypeAsync(ProductTypeForCreationDto productTypeForCreationDto);
        Task UpdateProductTypeAsync(int Id, ProductTypeForUpdateDto productTypeForUpdateDto, bool trackChanges);
        Task DeleteProductTypeAsync(int Id, bool trackChanges);
    }
}
