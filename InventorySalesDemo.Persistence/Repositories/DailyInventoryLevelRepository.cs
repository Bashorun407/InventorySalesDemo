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
    internal sealed class DailyInventoryLevelRepository : RepositoryBase<DailyInventoryLevel>, IDailyInventoryLevelRepository
    {
        protected RepositoryContext _repositoryContext;

        public DailyInventoryLevelRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateDailyInventoryLevel(DailyInventoryLevel entity)
        {
            CreateDailyInventoryLevel(entity);
        }

        public void DeleteDailyInventoryLevel(DailyInventoryLevel entity)
        {
            DeleteDailyInventoryLevel(entity);
        }
        
        public async Task<IEnumerable<DailyInventoryLevel>> GetAllDailyInventoryLevelAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<DailyInventoryLevel> GetDailyInventoryLevelById(int Id, bool trackChanges)
        {
            return await FindByConditionAsync(x => x.Product_Id == Id, trackChanges)
                .FirstOrDefaultAsync();
        }

        public void UpdateDailyInventoryLevel(DailyInventoryLevel entity)
        {
            UpdateDailyInventoryLevel(entity);
        }
    }
}
