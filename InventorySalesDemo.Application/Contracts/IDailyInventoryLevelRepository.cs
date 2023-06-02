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
        Task<DailyInventoryLevel> GetDailyInventoryLevelById(int Id, bool trackChanges);
        void CreateDailyInventoryLevel(DailyInventoryLevel entity);
        void UpdateDailyInventoryLevel(DailyInventoryLevel entity);
        void DeleteDailyInventoryLevel(DailyInventoryLevel entity);
    }
}
