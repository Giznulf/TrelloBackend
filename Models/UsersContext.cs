using Microsoft.EntityFrameworkCore;

namespace TrelloBackend.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;


        public UsersContext() => Database.EnsureCreated(); // создаем базу данных при первом обращении

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user=root;password=12345678;database=usersdb;",
                new MySqlServerVersion(new Version(8, 0, 31)));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "admin", Password = "qwerty" },
                    new User { Id = 2, Name = "tim", Password = "tim" },
                    new User { Id = 3, Name = "user", Password = "password" }
            );
        }
    }
}