using InventorySales.CoreServiceContract.Common;
using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyInventoryLevelController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DailyInventoryLevelController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        [HttpPost]
        public void CreateDailyInventoryLevel(DailyInventoryLevelDtoForCreation dailyInventoryLevelDtoForCreation)
        {
            _serviceManager.DailyInventoryLevelService.CreateDailyInventoryLevel(dailyInventoryLevelDtoForCreation);
        }

        [HttpDelete]
        public void DeleteDailyInventoryLevel(int id)
        {
            _serviceManager.DailyInventoryLevelService.DeleteDailyInventoryLevel(id, trackChanges: false);
        }


        [HttpGet]
        public async Task<ActionResult> GetAllDailyInventoryLevel()
        {
            var dailyInventoryLevels = await _serviceManager.DailyInventoryLevelService.GetAllDailyInventoryLevelAsync(trackChanges: false);
            return Ok(dailyInventoryLevels);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetDailyInventoryLevel(int id)
        {
            var dailyInventoryLevel = await _serviceManager.DailyInventoryLevelService.GetDailyInventoryLevelById(id, trackChanges: false);
                return Ok(dailyInventoryLevel);
            
        }

        [HttpPut]
        public void UpdateDailyInventoryLevel(int id, DailyInventoryLevelDtoForUpdate dailyInventoryLevelDtoForUpdate)
        {
            _serviceManager.DailyInventoryLevelService.UpdateDailyInventoryLevel(id, dailyInventoryLevelDtoForUpdate, trackChanges: false);
        }

    }
}
