using Microsoft.AspNetCore.Mvc;

namespace EnvironmentStatusApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SystemController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;

        public SystemController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet("status")]
        public IActionResult GetStatus()
        {
            if (_env.IsDevelopment())
            {
                return Ok("Status: Running, Environment: Development, Debug Mode: ON");
            }
            else
            {
                return Ok("Status: API is running.");
            }
        }
    }
}
