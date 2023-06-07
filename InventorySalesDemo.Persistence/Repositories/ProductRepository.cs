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
    internal sealed class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        protected RepositoryContext _repositoryContext;

        public ProductRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateProduct(Product entity)
        {
            CreateProduct(entity);
        }

        public void DeleteProduct(Product entity)
        {
            DeleteProduct(entity);
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<Product> GetProductById(int Id, bool trackChanges)
        {
            return FindByConditionAsync(x => x.Id == Id, trackChanges)
                .FirstOrDefault();
        }

        public void UpdateProduct(Product entity)
        {
            UpdateProduct(entity);
        }
    }
}
