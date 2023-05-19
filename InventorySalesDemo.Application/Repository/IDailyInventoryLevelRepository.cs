using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.Application.Repository
{
    public interface IDailyInventoryLevelRepository
    {
        Task<ICollection<DailyInventoryLevel>> GetAllDailyInventoryLevel();
        Task<DailyInventoryLevel> GetDailyInventoryLevelById(int id);
        void Add(DailyInventoryLevel dailyInventoryLevel);
        void Update(DailyInventoryLevel dailyInventoryLevel);
        void Delete(DailyInventoryLevel dailyInventoryLevel);
    }
}

