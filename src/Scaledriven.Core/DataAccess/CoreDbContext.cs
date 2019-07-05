using Microsoft.EntityFrameworkCore;
using Scaledriven.Core.DataAccess.Models;

namespace Scaledriven.Core.DataAccess
{
    public class CoreDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public CoreDbContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // TODO build: primarily use mysql and if the connection fails use InMemory
            optionsBuilder.UseInMemoryDatabase("Scaledriven");
        }

    }
}
