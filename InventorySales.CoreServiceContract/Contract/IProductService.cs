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
    public interface IProductService
    {
        Task CreateProduct(ProductDtoForCreation product);
        Task UpdateProduct(ProductDtoForUpdate product, bool trackChanges);
        Task DeleteProduct(int productId);
        Task<IEnumerable<ProductDtoForDisplay>> GetAllProducts();
        Task<ProductDtoForUpdate> GetProductById(int productId);
    }
}
