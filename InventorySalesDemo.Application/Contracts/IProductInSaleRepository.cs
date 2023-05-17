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
        Task<IEnumerable<ProductInSale>> GetAllAsync(bool trackChanges);
        Task<ProductInSale> GetProductInSaleById(int Id, bool trackChanges);
        void CreateProductInSale(ProductInSale entity);
        void DeleteProductInSale(ProductInSale entity);
    }
}
