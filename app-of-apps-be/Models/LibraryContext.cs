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

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity mappings or apply any additional configurations here
            // For example, you can specify the primary key, indexes, relationships, etc.
        }
    }
}
