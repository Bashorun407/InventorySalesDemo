using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface IProductInSaleRepository
    {
        Task<IEnumerable<ProductInSale>> GetAllProductInSaleAsync(bool trackChanges);
        Task<ProductInSale?> GetProductInSaleByIdAsync(int Id, bool trackChanges);
        void AddProductInSale(ProductInSale productInSale);
        void DeleteProductInSale(ProductInSale productInSale);
    }
}
