using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ApiTestPad.Controllers
{
    [ApiController]
    [Route("{*url}")]
    public class MaintenanceController : ControllerBase
    {
        private readonly ILogger<MaintenanceController> _logger;

        public MaintenanceController(ILogger<MaintenanceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(503);
        }


        [HttpPost]
        public IActionResult Post()
        {
            return StatusCode(503);
        }

        [HttpPut]
        public IActionResult Put()
        {
            return StatusCode(503);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return StatusCode(503);
        }
    }
}
