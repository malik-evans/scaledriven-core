using Microsoft.EntityFrameworkCore;
using Scaledriven.Areas.Association.Models;

namespace Scaledriven.Areas.Association.Database
{

    /// <summary>
    /// Only filters can write to this context
    /// </summary>
    public class AssociativeActivityDbContext : DbContext
    {
        public DbSet<CustomActionDescriptor> ActionDescriptors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("Activity");
        }
    }
}
