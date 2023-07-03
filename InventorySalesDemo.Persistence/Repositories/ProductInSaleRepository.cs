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
        public ProductInSaleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddProductInSale(ProductInSale productInSale)
        {
            Add(productInSale);
        }

        public void DeleteProductInSale(ProductInSale productInSale)
        {
            Delete(productInSale);
        }

        public async Task<IEnumerable<ProductInSale>> GetAllProductInSaleAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<ProductInSale?> GetProductInSaleByIdAsync(int Id, bool trackChanges)
        {
            var ProductInSale = await FindByConditionAsync(productInSale => productInSale.Id.Equals(Id), trackChanges).ToListAsync();
            return ProductInSale.FirstOrDefault();
        }
    }
}
