using Microsoft.EntityFrameworkCore;
using Scaledriven.Api.Areas.App.Models;

namespace Scaledriven.Api.Areas.App.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("Scaledriven");
        }

    }
}
