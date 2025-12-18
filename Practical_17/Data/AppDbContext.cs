using Microsoft.EntityFrameworkCore;
using Practical_17.Models;

namespace Practical_17.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Roles>().HasData(
                new Roles() { RoleId = 1, RoleName = "Admin" },
                new Roles() { RoleId = 2, RoleName = "NormalUser" }
                );

            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                    UserId = 1,
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@test.com",
                    MobileNumber = "9999999999",
                    Password = "Admin@123",
                    RoleId = 1
                },
                new Users
                {
                    UserId = 2,
                    FirstName = "Normal",
                    LastName = "User",
                    Email = "user@test.com",
                    MobileNumber = "8888888888",
                    Password = "User@123",
                    RoleId = 2
                });
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
