using Microsoft.AspNetCore.Mvc;
using Scaledriven.Areas.Association.Database;
using Scaledriven.Services;

namespace Scaledriven.Areas.Association.Design
{


    /**
     * remember:
     * route template: [Route("[area]/[controller]/[action]")] for ViewControllers
     * causes route confusion
     *
     * For ViewControllers, use [Route("[area]/[controller]")] instead
     */
    /// <summary>
    ///  ViewControllerBase.
    /// </summary>
    /// <summary>
    ///  route template: [Route("[area]/[controller]")] is high priority
    /// </summary>
    [Area("Association")]
    [Route("[area]/[controller]")]
    [ServiceFilter(typeof(SaveChangesResultFilter))]
    public abstract class AssociationControllerBase : Controller
    {
        /*
           Repeat members below in derived controllers
        */
        private readonly AssociationDbContext _context;

        protected AssociationControllerBase(AssociationDbContext context)
        {
            _context = context;
        }
    }

    /// <summary>
    /// Association controllers inherit from controller base
    /// to defeat biolerplate attribution
    /// </summary>
    [Area("Association")]
    [Route("api/[area]/[controller]/[action]")]        // route templat differences are very impo
    [ServiceFilter(typeof(SaveChangesResultFilter))]
    public abstract class AssociationApiControllerBase : ControllerBase
    {
        /*
           Repeat members below in derived controllers
        */
        private readonly AssociationDbContext _context;

        protected AssociationApiControllerBase(AssociationDbContext context)
        {
            _context = context;
        }
    }


}
