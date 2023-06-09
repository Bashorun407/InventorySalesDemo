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
    public interface IProductTypeService
    {
        Task CreateProductType(ProductTypeDtoForCreation productType);
        Task UpdateProductType(ProductTypeDtoForUpdate productType);
        Task DeleteProductType(int  productTypeId);
        Task<IEnumerable<ProductTypeDtoForDisplay>> GetAllProductType();
        Task<ProductTypeDtoForDisplay> GetProductTypeById(int productTypeId);
    }
}
