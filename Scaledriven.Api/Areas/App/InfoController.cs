using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Api.Areas.App
{
    [Area("api/App")]
    [Route("[area]/[controller]")]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public string Index() => "Scaledriven";
    }
}
