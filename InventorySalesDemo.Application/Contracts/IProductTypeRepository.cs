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
        Task<IEnumerable<ProductType>> GetAllAsync(bool trackChanges);
        Task<ProductType> GetProductTypeById(int Id, bool trackChanges);
        void CreateProductType(ProductType entity);
        void DeleteProductType(ProductType entity);
    }
}
