using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using Scaledriven.Database;

namespace Scaledriven.Services
{

    /// <summary>
    /// Saves the state of the right after dbcontext during action execution
    /// </summary>
    public class SaveChangesResultFilter : Attribute, IResultFilter
    {
        private readonly ApplicationDbContext _dbContext;

        public SaveChangesResultFilter(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {

        }

        public void OnResultExecuted(ResultExecutedContext context)
        {
            _dbContext.SaveChanges();
        }
    }
}
