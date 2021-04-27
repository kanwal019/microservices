 using Microsoft.AspNetCore.Mvc;
 
namespace Api.Gateway.Controllers
{
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get() => Content("Hello from Home Controller !!");
    }
}