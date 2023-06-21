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
        Task<IEnumerable<ProductInSaleDtoForDisplay>> GetAllProductInSaleAsync(bool trackChanges);
        Task<ProductInSaleDtoForDisplay> GetProductInSaleById(int id, bool trackChanges);
        void CreateProductInSale(ProductInSaleDtoForCreation productInSale);
        void UpdateProductInSale(int id, ProductInSaleDtoForUpdate productInSale, bool trackChanges);
        void DeleteProductInSale(int id, bool trackChanges);
    }
}
