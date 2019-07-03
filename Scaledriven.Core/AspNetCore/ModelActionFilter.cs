using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Scaledriven.Core.DataAccess;

namespace Scaledriven.Core.AspNetCore
{
    public class ModelActionFilter : IResultFilter
    {
        readonly CoreDbContext _context;

        public ModelActionFilter(CoreDbContext context)
        {
            _context = context;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            _context.SaveChanges();
        }
    }
}
