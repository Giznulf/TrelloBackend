using Microsoft.EntityFrameworkCore;

namespace TrelloBackend.Models
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public UsersContext(DbContextOptions<UsersContext> options)
               : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
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