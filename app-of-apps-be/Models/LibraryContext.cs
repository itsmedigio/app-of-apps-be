using Microsoft.EntityFrameworkCore;
using app_of_apps_be.Models;

namespace app_of_apps_be.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.HasDefaultSchema("public");
        }

        public DbSet<Book> Books { get; set; }
  }
}
