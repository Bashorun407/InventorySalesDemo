using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Contracts
{
    public interface IDailyInventoryLevelRepository
    {
        Task<IEnumerable<DailyInventoryLevel>> GetAllDailyInventoryLevelAsync(bool trackChanges);
        Task<DailyInventoryLevel?> GetDailyInventoryLevelByIdAsync(int Id, bool trackChanges);
        void AddDailyInventoryLevel(DailyInventoryLevel dailyInventoryLevel);
        void DeleteDailyInventoryLevel(DailyInventoryLevel dailyInventoryLevel);
    }
}
