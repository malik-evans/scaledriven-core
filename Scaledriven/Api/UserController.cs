using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Scaledriven.Database;
using Scaledriven.Models;
using Scaledriven.Services;

namespace Scaledriven.Api
{

    [Route("api/[controller]/[action]")]
    [ServiceFilter(typeof(SaveChangesResultFilter))]
    public class UserController : ControllerBase
    {
        private readonly DbSet<User> _users;
        private readonly IFactory<User> _factory;

        public UserController(ApplicationDbContext context, IFactory<User> factory)
        {
            _factory = factory;
            _users = context.Users;
        }

        [HttpGet("Fake")]
        [ProducesResponseType(typeof(User), 200)]
        public IActionResult Fake()
        {
            return Ok(_factory.Create());
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<User>), 200)]
        public IActionResult Index()
        {
            List<User> users = new List<User>();

            return Ok(users);
        }


        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Create(User model)
        {
            _users.Add(model);

            return Ok();
        }

        [HttpPost("CreateMany")]
        [ProducesResponseType(200)]
        public IActionResult CreateMany(IEnumerable<User> model)
        {
            _users.AddRange(model);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] string Id)
        {

            // todo prove that the post belongs the requesting user
            User targetUser = _users.Find(new {Id});

            if (targetUser!= null)
            {
                return BadRequest();
            }

            _users.Remove(targetUser);

            return Ok();
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(User), 200)]
        public IActionResult Show([FromRoute] string Id)
        {
            User post = _users.Find(new {Id});

            if (post == null)
            {
                return BadRequest("Post record is not found");
            }

            return Ok(post);
        }

    }


}
