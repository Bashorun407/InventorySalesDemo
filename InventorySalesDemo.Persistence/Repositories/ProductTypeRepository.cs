using InventorySalesDemo.Application.Contracts;
using InventorySalesDemo.Domain.Entities;
using InventorySalesDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Repositories
{
    internal sealed class ProductTypeRepository : RepositoryBase<ProductType>, IProductTypeRepository
    {
        public ProductTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddProductType(ProductType productType)
        {
            Add(productType);
        }

        public void DeleteProductType(ProductType productType)
        {
            Delete(productType);
        }

        public async Task<IEnumerable<ProductType>> GetAllProductTypeAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<ProductType?> GetProductTypeByIdAsync(int Id, bool trackChanges)
        {
            var productType = await FindByConditionAsync(productType => productType.Id.Equals(Id), trackChanges).ToListAsync();
            return  productType.FirstOrDefault();
        }
    }
}
