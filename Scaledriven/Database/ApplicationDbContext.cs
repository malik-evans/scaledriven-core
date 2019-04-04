using Microsoft.EntityFrameworkCore;
using Scaledriven.Models;

namespace Scaledriven.Database
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
