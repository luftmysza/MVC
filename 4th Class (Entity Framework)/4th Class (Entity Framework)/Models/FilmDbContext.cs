using Microsoft.EntityFrameworkCore;

namespace _4th_Class__Entity_Framework_.Models
{
    public class FilmDbContext : DbContext
    {
        public FilmDbContext(DbContextOptions<FilmDbContext> options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Unknown" },
            new Category { Id = 2, Name = "Comedy" },
            new Category { Id = 3, Name = "Action" },
            new Category { Id = 4, Name = "Drama" }
            );
        }
    }
}
