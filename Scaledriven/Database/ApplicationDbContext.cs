using Microsoft.EntityFrameworkCore;
using Scaledriven.Areas.Messaging.Models;
using Scaledriven.Interfaces;
using Scaledriven.Models;

namespace Scaledriven.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected readonly ICreator<Message> _messageFactory;

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options, ICreator<Message> messageFactory) : base(options)
        {
            _messageFactory = messageFactory;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("App");
        }

    }
}
