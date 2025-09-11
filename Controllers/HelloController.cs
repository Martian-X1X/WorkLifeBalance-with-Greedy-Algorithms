using Microsoft.AspNetCore.Mvc;

namespace WorkforceScheduler.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("🚀 Workforce Scheduler API is running!");
        }
    }
}
