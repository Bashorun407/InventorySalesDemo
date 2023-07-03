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
    public interface IProductInSaleService
    {
        Task<IEnumerable<ProductInSaleForDisplayDto>> GetAllProductInSaleAsync(bool trackChanges);
        Task<ProductInSaleForDisplayDto> GetProductInSaleAsync(int Id, bool trackChanges);
        Task<ProductInSaleForDisplayDto> CreateProductInSaleAsync(ProductInSaleForCreationDto productInSaleForCreationDto);
        Task UpdateProductInSaleAsync(int Id, ProductInSaleForUpdateDto productInSaleForUpdateDto, bool trackChanges);
        Task DeleteProductInSaleAsync(int Id, bool trackChanges);
    }
}
