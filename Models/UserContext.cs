using Microsoft.EntityFrameworkCore;

namespace TrelloBackend.Models
{
    public class TrelloContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Column> Columns { get; set; } = null!;
        public DbSet<Card> Cards { get; set; } = null!;

        public TrelloContext(DbContextOptions<TrelloContext> options)
               : base(options)
        {
           // Database.EnsureDeleted();
            //Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Name = "admin", Password = "qwerty" },
                    new User { Id = 2, Name = "tim", Password = "tim" },
                    new User { Id = 3, Name = "user", Password = "password" }
            );
            modelBuilder.Entity<Column>().HasData(
                    new Column { Id = 1, NameColumn = "test"});

            modelBuilder.Entity<Column>().ToTable("Columns");
            modelBuilder.Entity<Card>().ToTable("Cards");
        }
    }
}