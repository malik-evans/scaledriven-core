using Microsoft.AspNetCore.Mvc;

namespace Scaledriven.Areas.Association.Controllers
{
    [Area("Association")]
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
