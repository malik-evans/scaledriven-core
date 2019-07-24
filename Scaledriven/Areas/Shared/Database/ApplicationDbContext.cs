using Microsoft.EntityFrameworkCore;
using Scaledriven.Areas.Shared.Models;

namespace Scaledriven.Areas.Shared.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("app");
        }
    }
}
