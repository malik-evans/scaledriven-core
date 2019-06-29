using Microsoft.EntityFrameworkCore;
using Scaledriven.Api.Models;

namespace Scaledriven.Api.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("App");
        }

    }
}
