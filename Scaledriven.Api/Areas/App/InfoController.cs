using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Scaledriven.Core.AspNetCore;
using Scaledriven.Core.AspNetCore.Design;
using Scaledriven.Core.DataAccess;
using Scaledriven.Core.DataAccess.Models;

namespace Scaledriven.Api.Areas.App
{
    [Area("api/App")]
    [Route("[area]/[controller]")]
    [ServiceFilter(typeof(ModelActionFilter))]
    public class InfoController : ControllerBase
    {

        public readonly IRepository<User> _Repository;
        public readonly CoreDbContext _Context;
        public readonly IActionDescriptorCollectionProvider _ActionDescriptorCollectionProvider;

        public InfoController(IRepository<User> repository, CoreDbContext context, IActionDescriptorCollectionProvider actionDescriptorCollectionProvider)
        {
            _Repository = repository;
            _Context = context;
            _ActionDescriptorCollectionProvider = actionDescriptorCollectionProvider;
        }

        [HttpGet]
        public IEnumerable<User> Index() => _Repository.Get();

        [HttpGet("Friends")]
        public void AddFriends(User user)
        {
            user.Parent.FirstName = "Jeff";
        }

        [HttpGet("User")]
        public ActionResult<User> GetUserByName([FromQuery] string firstName)
        {
            User user = _Context.Users
                .Where(u => u.FirstName == firstName)
                .FirstOrDefault();

            if (user == null)
            {
                return BadRequest();
            }

            return user;
        }

        [HttpPost("User")]
        public void CreateUser()
        {
            _Context.Add(new User
            {
               FirstName = "Jeff"
            });
        }


        [HttpPut("Parent/Name")]
        public void Parent(string userId, string newName)
        {
            User user = _Context.Users.Find(new {UserId = userId});

            user.UpdateParentName(newName);
        }

        [HttpGet("Action/Description")]
        public IEnumerable<ControllerActionDescriptor> ActionDescription()
        {
            return _ActionDescriptorCollectionProvider
                .ActionDescriptors
                .Items
                .OfType<ControllerActionDescriptor>()
                .Select(a => a);
        }
    }
}
