using InventorySalesDemo.Application.Contracts;
using InventorySalesDemo.Domain.Entities;
using InventorySalesDemo.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Persistence.Repositories
{
    internal sealed class DailyInventoryLevelRepository : RepositoryBase<DailyInventoryLevel>, IDailyInventoryLevelRepository
    {
        public DailyInventoryLevelRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void AddDailyInventoryLevel(DailyInventoryLevel dailyInventoryLevel)
        {
            Add(dailyInventoryLevel);
        }

        public void DeleteDailyInventoryLevel(DailyInventoryLevel dailyInventoryLevel)
        {
            Delete(dailyInventoryLevel);
        }

        public async Task<IEnumerable<DailyInventoryLevel>> GetAllDailyInventoryLevelAsync(bool trackChanges)
        {
            return await FindAllAsync(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<DailyInventoryLevel?> GetDailyInventoryLevelByIdAsync(int Id, bool trackChanges)
        {
            var dailyInventoryLevel = await FindByConditionAsync(dailyInventoryLevel => dailyInventoryLevel.Id.Equals(Id), trackChanges).ToListAsync();
            return dailyInventoryLevel.FirstOrDefault();
        }
    }
}
