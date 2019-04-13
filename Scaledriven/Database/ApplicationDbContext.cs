using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Scaledriven.Models;

namespace Scaledriven.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;uid=root;pwd=password;database=Scaledriven-core");
        }

    }
}
