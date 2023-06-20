using InventorySales.CoreServiceContract.Common;
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

        [HttpGet]
        public async Task<ActionResult> GetAllDailyInventoryLevel()
        {
            var dailyInventoryLevels = await _serviceManager.DailyInventoryLevelService.GetAllDailyInventoryLevelAsync(trackChanges: false);
            return Ok(dailyInventoryLevels);
        }
    }
}
