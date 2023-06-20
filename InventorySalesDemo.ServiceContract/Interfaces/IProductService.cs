using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDtoForDisplay>> GetAllProductsAsync(bool trackChanges);
        Task<ProductDtoForDisplay> GetProductByIdAsync(int id, bool trackChanges);
        void CreateProduct(ProductDtoForCreation product);
        void UpdateProduct(int id, ProductDtoForUpdate product, bool trackChanges);
        void DeleteProduct(int id, bool trackChanges);
    }
}
