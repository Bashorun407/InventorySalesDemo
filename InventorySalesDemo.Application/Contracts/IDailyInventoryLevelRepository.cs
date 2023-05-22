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
        Task<IEnumerable<DailyInventoryLevel>> GetAllAsync(bool trackChanges);
        Task<DailyInventoryLevel> GetDailyInventoryLevelById(int Id, bool trackChanges);
        void CreateDailyInventoryLevel(DailyInventoryLevel entity);
        void DeleteDailyInventoryLevel(DailyInventoryLevel entity);
    }
}
