using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Association.Database;
using Scaledriven.Areas.Association.Design;
using Scaledriven.Areas.Association.Service;

namespace Scaledriven.Areas.Association.Api
{
    public class CompanyController : AssociationApiControllerBase
    {
        public CompanyController(AssociationDbContext context) : base(context)
        {
        }

        [HttpGet]
        [ProducesResponseType(typeof(MemberInfo), 200)]
        public IActionResult Index()
        {
            MemberInfo[] occupationInfo = typeof(OccupationType).GetMembers();
            return Ok(occupationInfo);
        }
    }
}
