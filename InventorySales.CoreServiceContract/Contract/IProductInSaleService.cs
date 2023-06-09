using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.CoreServiceContract.Contract
{
    public interface IProductInSaleService
    {
        Task CreateProductInSale(ProductDtoForCreation productDtoForCreation);
        Task UpdateProductInSale(ProductDtoForUpdate productDtoForUpdate, bool trackChanges);
        Task DeleteProductInSale(int productInSaleId);
        Task<IEnumerable<ProductDtoForDisplay>> GetAllProductInSale();
        Task<ProductDtoForUpdate> GetProductInSaleById(int productInSaleId);
    }
}
