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
    public interface IProductService
    {
        Task<IEnumerable<ProductForDisplayDto>> GetAllProductAsync(bool trackChanges);
        Task<ProductForDisplayDto> GetProductAsync(int Id, bool trackChanges);
        Task<ProductForDisplayDto> CreateProductAsync(ProductForCreationDto productForCreationDto);
        Task UpdateProductAsync(int Id, ProductForUpdateDto productForUpdateDto, bool trackChanges);
        Task DeleteProductAsync(int Id, bool trackChanges);
    }
}
