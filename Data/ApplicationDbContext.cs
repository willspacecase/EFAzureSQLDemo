using EFAzureSQLDemo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFAzureSQLDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(x => {
                x.HasData(new List<Customer> { 
                    new Customer() { FirstName = "Will", LastName = "Smith", Address = "Hollywood", Id = 1 },
                    new Customer() { FirstName = "Chris", LastName = "Rock", Address = "Brentwood", Id = 2}
                });
            });
        }
    }
}
