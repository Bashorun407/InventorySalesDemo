using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForDisplay;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesDemo.ServiceContract.Interfaces
{
    public interface IDailyInventoryLevelService
    {
        Task<IEnumerable<DailyInventoryLevelForDisplayDto>> GetAllDailyInventoryLevelAsync(bool trackChanges);
        Task<DailyInventoryLevelForDisplayDto> GetDailyInventoryLevelByIdAsync(int Id, bool trackChanges);
        Task<DailyInventoryLevelForDisplayDto> CreateDailyInventoryLevelAsync(DailyInventoryLevelForCreationDto dailyInventoryLevelForCreationDto);
        Task UpdateDailyInventoryLevelAsync(int Id, DailyInventoryLevelForUpdateDto dailyInventoryLevelForUpdateDto, bool trackChanges);
        Task DeleteDailyInventoryLevelAsync(int Id, bool trackChanges);
    }
}
