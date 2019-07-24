using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Association.Database;
using Scaledriven.Areas.Association.Service;

namespace Scaledriven.ApiControllers
{
    public class CompanyController : ControllerBase
    {

        [HttpGet]
        [ProducesResponseType(typeof(MemberInfo), 200)]
        public IActionResult Index()
        {
            MemberInfo[] occupationInfo = typeof(OccupationType).GetMembers();
            return Ok(occupationInfo);
        }
    }
}
