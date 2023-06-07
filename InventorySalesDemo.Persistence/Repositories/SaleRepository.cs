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
        protected RepositoryContext _repositoryContext; 
        public SaleRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public void CreateSale(Sale entity)
        {
            CreateSale(entity);
        }

        public void DeleteSale(Sale entity)
        {
            DeleteSale(entity);
        }

        public async Task<IEnumerable<Sale>> GetAllSaleAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Sale> GetSaleById(int Id, bool trackChanges)
        {
            return await FindByConditionAsync(x => x.Id == Id, trackChanges)
                .FirstOrDefaultAsync();
        }

        public void UpdateSale(Sale entity)
        {
            UpdateSale(entity);
        }
    }
}
