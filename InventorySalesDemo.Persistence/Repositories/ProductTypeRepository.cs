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
        protected RepositoryContext _repositoryContext;
        public ProductTypeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProductType(ProductType entity)
        {
            CreateProductType(entity);
        }

        public void DeleteProductType(ProductType entity)
        {
            DeleteProductType(entity);
        }

        public async Task<IEnumerable<ProductType>> GetAllProductTypeAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<ProductType> GetProductTypeById(int Id, bool trackChanges)
        {
            return FindByConditionAsync(x => x.Id == Id, trackChanges)
                .FirstOrDefault();
        }

        public void UpdateProductType(ProductType entity)
        {
            UpdateProductType(entity);
        }
    }
}
