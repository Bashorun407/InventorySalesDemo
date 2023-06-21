using InventorySales.CoreServiceContract.Common;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventorySalesDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public TestController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET: api/<TestController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _serviceManager.DailyInventoryLevelService.GetAllDailyInventoryLevelAsync(false);
            return Ok(result);  
        }

        // GET api/<TestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
