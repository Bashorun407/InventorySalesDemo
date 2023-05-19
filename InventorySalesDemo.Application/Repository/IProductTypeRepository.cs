using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface IProductTypeRepository
    {
        Task<ICollection<ProductType>> GetAllProductType();
        Task<ProductType> GetProductTypeById(int id);
        void Add(ProductType productType);
        void Update(ProductType productType);
        void Delete(ProductType productType);

    }
}
