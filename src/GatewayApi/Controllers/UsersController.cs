using Library.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System.Threading.Tasks;

namespace API.Gateway.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClient;

        public UsersController(IBusClient busClient)
        {
            _busClient = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] CreateUser command)
        {
            await _busClient.PublishAsync(command);
            return Accepted();
        }
    }
}
