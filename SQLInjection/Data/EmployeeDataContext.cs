using Microsoft.EntityFrameworkCore;

namespace SQLInjection.Data
{
    public class EmployeeDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("EmployeeDB"));
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                    .HasData(
                new Employee { Id = 1, Name = "Frank", Username = "frank1", Password = "pass123" },
                new Employee { Id = 2, Name = "Bob", Username = "coolguy", Password = "safe321" },
                new Employee { Id = 3, Name = "Sarah", Username = "haras", Password ="word17"}
                );
        }
    }
}