using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.ApiControllers
{

    [Route("api/[controller]")]
    public class AppController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public IActionResult Settings() => Ok( new { ControllerName = nameof(AppController) });
    }
}
