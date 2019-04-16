using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scaledriven.Database;
using Scaledriven.Models;
using Scaledriven.Services;

namespace Scaledriven.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        protected readonly ApplicationDbContext _applicationDbContext;
        protected readonly IGitHubApiService _githubService;

        public UsersController(ApplicationDbContext applicationDbContext, IGitHubApiService githubService)
        {
            _applicationDbContext = applicationDbContext;
            _githubService = githubService;
        }

        /// <summary>
        /// A list of user instances
        /// </summary>
        /// <returns></returns>
        [Area("Home")]
        [ActionName("Get_Home_Users")]
        [HttpGet("/api/[area]/[controller]")]
        public IActionResult HomeUsers()
        {
            User user = _applicationDbContext.Users.First();
            return new JsonResult(user);
        }

        [Area("Home")]
        [ActionName("[POST] User")]
        [HttpPost("/api/[area]/[controller]")]
        [ProducesResponseType(typeof(User), 200)]
        public IActionResult Users([FromBody] CreateUserModel createUserModel)
        {
            User userInstance = new User
            {
                FirstName =  createUserModel.FirstName,
                IsActive = createUserModel.IsActive,
                Email =  createUserModel.Email
            };

            _applicationDbContext.Users.Add(userInstance);

            _applicationDbContext.SaveChanges();

            return Ok(new
            {
                InMemory = _applicationDbContext.Database.IsInMemory()
            });
        }

        [Area("Github")]
        [HttpGet("/api/[area]/[controller]")]
        public JsonResult Github() =>
            new JsonResult(_githubService.Users());

        [Area("Github")]
        [HttpGet("/api/[area]/[controller]/{username}")]
        public JsonResult Github([FromRoute] string username) =>
            new JsonResult(_githubService.User(username).Result.Content.ReadAsStringAsync());

    }
}
