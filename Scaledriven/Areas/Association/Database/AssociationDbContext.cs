using Microsoft.EntityFrameworkCore;
using Scaledriven.Areas.Association.Models;

namespace Scaledriven.Areas.Association.Database
{
    public class AssociationDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Statement> Statements { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }

        public AssociationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("Association");
        }
    }
}
