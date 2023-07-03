using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface IProductTypeRepository
    {
        Task<IEnumerable<ProductType>> GetAllProductTypeAsync(bool trackChanges);
        Task<ProductType?> GetProductTypeByIdAsync(int Id, bool trackChanges);
        void AddProductType(ProductType productType);
        void DeleteProductType(ProductType productType);
    }
}
