using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface IDailyInventoryLevelService
    {
        Task<IEnumerable<DailyInventoryLevelDtoForDisplay>> GetAllDailyInventoryLevelAsync(bool trackChanges);
        Task<DailyInventoryLevelDtoForDisplay> GetDailyInventoryLevelById(int id, bool trackChanges);
        void CreateDailyInventoryLevel(DailyInventoryLevelDtoForCreation dailyInventoryLevel);
        void UpdateDailyInventoryLevel(int id, DailyInventoryLevelDtoForUpdate dailyInventoryLevel, bool trackChanges);
        void DeleteDailyInventoryLevel(int id, bool trackChanges);
    }
}
