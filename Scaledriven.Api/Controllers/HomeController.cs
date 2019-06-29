using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Api.Controllers
{
    [Route("api/[Controller]")]
    public class HomeController : ControllerBase
    {
        [ProducesResponseType(200)]
        public ActionResult<string> Index() => "Hello from mack";
    }
}
