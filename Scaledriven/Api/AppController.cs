using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Api
{

    [Route("api/[controller]")]
    public class AppController : ControllerBase
    {
        [HttpGet]
        public IActionResult Settings() => Content("Title");
    }
}
