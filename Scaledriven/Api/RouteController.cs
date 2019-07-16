using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Scaledriven.Api
{
    [Route("api/[controller]/[action]")]
    public class RouteController : Controller
    {
        public readonly IActionDescriptorCollectionProvider _CollectionProvider;

        public RouteController(IActionDescriptorCollectionProvider collectionProvider)
        {
            _CollectionProvider = collectionProvider;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ActionDescriptor>), 200)]
        public IActionResult Index()
        {
            var desc = _CollectionProvider
                .ActionDescriptors
                .Items
                .OfType<ControllerActionDescriptor>()
                .Select(c => { return new
                {
                    c.DisplayName,
                    c.RouteValues
                }; });

            return Ok(desc);
        }
    }
}
