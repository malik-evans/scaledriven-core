using Microsoft.AspNetCore.Mvc.Filters;
using Scaledriven.Database;

namespace Scaledriven.Shared
{
    public class ModelActionFilter : IActionFilter
    {

        public readonly ApplicationDbContext ApplicationDbContext;

        public ModelActionFilter(ApplicationDbContext applicationDbContext)
        {
            ApplicationDbContext = applicationDbContext;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            ApplicationDbContext.SaveChanges();
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
