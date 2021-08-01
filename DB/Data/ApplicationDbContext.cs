using DB.Models;
using Microsoft.EntityFrameworkCore;

namespace DB.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Shift>()
                .HasOne(c => c.Employee);

            base.OnModelCreating(builder);
        }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
