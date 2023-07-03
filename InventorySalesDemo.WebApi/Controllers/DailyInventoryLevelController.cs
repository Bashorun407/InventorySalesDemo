using InventorySalesDemo.Application.DTOs.DtoForCreation;
using InventorySalesDemo.Application.DTOs.DtoForUpdate;
using InventorySalesDemo.ServiceContract.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DailyInventoryLevelController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DailyInventoryLevelController(IServiceManager service)
        {
            _serviceManager = service;  
        }
        
        [HttpPost]
        public void CreateDailyInventoryLevel(DailyInventoryLevelForCreationDto dailyInventoryLevelForCreationDto)
        {
            _serviceManager.DailyInventoryLevelService.CreateDailyInventoryLevelAsync(dailyInventoryLevelForCreationDto);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDailyInventoryLevel()
        {
            var dailyInventoryLevels = await _serviceManager.DailyInventoryLevelService.GetAllDailyInventoryLevelAsync(trackChanges: false);
            return Ok(dailyInventoryLevels);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetDailyInventoryLevel(int Id)
        {
            var dailyInventoryLevels = await _serviceManager.DailyInventoryLevelService.GetDailyInventoryLevelByIdAsync(Id, trackChanges: false);
            return Ok(dailyInventoryLevels);
        }
        [HttpDelete]
        public void DeleteDailyInventoryLevel(int Id)
        {
            _serviceManager.DailyInventoryLevelService.DeleteDailyInventoryLevelAsync(Id, trackChanges: false);
        }
        [HttpPut]
        public void UpdateDailyInventoryLevel(int Id, DailyInventoryLevelForUpdateDto dailyInventoryLevelForUpdateDto)
        {
            _serviceManager.DailyInventoryLevelService.UpdateDailyInventoryLevelAsync(Id, dailyInventoryLevelForUpdateDto, trackChanges: false);
        }

    }
}
