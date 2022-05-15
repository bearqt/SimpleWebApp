using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers
{
    [ApiController]
    [Route("/api")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet("healthCheck")]
        public ActionResult HealthCheck()
        {
            return Ok();
        }
    }
}