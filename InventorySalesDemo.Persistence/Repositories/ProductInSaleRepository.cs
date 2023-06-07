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
    internal sealed class ProductInSaleRepository : RepositoryBase<ProductInSale>, IProductInSaleRepository
    {
        protected RepositoryContext _repositoryContext;
        public ProductInSaleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateProductInSale(ProductInSale entity)
        {
            CreateProductInSale(entity);
        }

        public void DeleteProductInSale(ProductInSale entity)
        {
            DeleteProductInSale(entity);
        }

        public async Task<IEnumerable<ProductInSale>> GetAllProductInSaleAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Product_Id)
                .ToListAsync();
        }

        public async Task<ProductInSale> GetProductInSaleById(int Id, bool trackChanges)
        {
            return FindByConditionAsync(x=> x.Product_Id == Id, trackChanges)
                .FirstOrDefault();
        }

        public void UpdateProductInSale(ProductInSale entity)
        {
            UpdateProductInSale(entity);
        }
    }
}
