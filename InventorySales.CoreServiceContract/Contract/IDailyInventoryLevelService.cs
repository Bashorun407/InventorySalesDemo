using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySales.CoreServiceContract.Contract
{
    public interface IDailyInventoryLevelService
    {
        Task CreateDailyInventoryLevel(DailyInventoryLevelDtoForCreation dailyInventoryLevelDtoForCreation);
        Task UpdateDailyInventoryLevel(DailyInventoryLevelDtoForUpdate dailyInventoryLevelDtoForUpdate, bool trackChanges);
        Task DeleteDailyInventoryLevel(int dailyInventoryLevelId);
        Task<IEnumerable<DailyInventoryLevelDtoForDisplay>> GetAllDailyInventoryLevels();
        Task<DailyInventoryLevelDtoForDisplay> GetDailyInventoryLevelById(int dailyInventoryLevelId);

    }
}
