using DependencyInjectionInASP.NET_Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionInASP.NET_Core.Controllers
{
    [Route("api/di/v1/[controller]/get")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IMyService _myService;

        public MyController(IMyService myService)
        {
            _myService = myService;
        }

        [HttpGet("nickname")]
        public IActionResult GetNickName()
        {
            var message = _myService.GetNickName();
            return Ok(message);
        }   
        [HttpGet("message")]
        public IActionResult GetMessage()
        {
            var message = _myService.GetMessage();
            return Ok(message);
        }
    }
}
