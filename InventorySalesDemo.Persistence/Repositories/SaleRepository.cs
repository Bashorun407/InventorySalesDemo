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
    internal sealed class SaleRepository : RepositoryBase<Sale>, ISaleRepository
    {
        public SaleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddSale(Sale sale)
        {
            Add(sale);
        }

        public void DeleteSale(Sale sale)
        {
            Delete(sale);
        }

        public async Task<IEnumerable<Sale>> GetAllSaleAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x =>x.Id)
                .ToListAsync();
        }

        public async Task<Sale?> GetSaleByIdAsync(int Id, bool trackChanges)
        {
            var sale = await FindByConditionAsync(sale => sale.Id.Equals(Id), trackChanges).ToListAsync();
            return sale.FirstOrDefault();           
        }
    }
}
