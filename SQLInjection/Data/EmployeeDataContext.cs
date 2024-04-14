using Microsoft.EntityFrameworkCore;

namespace SQLInjection.Data
{
    public class UserDataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public UserDataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("UserDB"));
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<User>()
                    .HasData(
                new User { Id = 1, Name = "Frank", Username = "frank1", Password = "pass123" },
                new User { Id = 2, Name = "Bob", Username = "coolguy", Password = "safe321" },
                new User { Id = 3, Name = "Sarah", Username = "haras", Password ="word17"}
                );
        }
    }
}