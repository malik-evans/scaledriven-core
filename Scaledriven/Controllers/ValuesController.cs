using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Scaledriven.Database;
using Scaledriven.Models;

namespace Scaledriven.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        protected ApplicationDbContext _applicationDbContext { get; set; }

        public ValuesController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // GET api/values
        [HttpGet]
        public JsonResult Get()
        {
            _applicationDbContext.Users.Add(new User
            {
                FirstName = "Malik Evans"
            });

            _applicationDbContext.SaveChanges();

            return new JsonResult(_applicationDbContext.Users.First());
        }


    }
}
