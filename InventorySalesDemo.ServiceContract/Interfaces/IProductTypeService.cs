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
        Task<IEnumerable<ProductTypeDtoForDisplay>> GetAllProductTypeAsync(bool trackChanges);
        Task<ProductTypeDtoForDisplay> GetProductTypeByIdAsync(int id, bool trackChanges);
        void CreateProductType(ProductTypeDtoForCreation productType);
        void UpdateProductType(int id, ProductTypeDtoForUpdate productType, bool trackChanges);
        void DeleteProductType(int id, bool trackChanges);
    }
}
