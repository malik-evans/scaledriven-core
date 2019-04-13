using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Database;
using Scaledriven.Models;

namespace Scaledriven.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController
    {

        protected readonly ApplicationDbContext _applicationDbContext;

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
