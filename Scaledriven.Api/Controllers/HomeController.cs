using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Controllers
{
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    {
        [ProducesResponseType(200)]
        public ActionResult<string> Index() => "Hello from mack";
    }
}
