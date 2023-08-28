using Microsoft.EntityFrameworkCore;
using app_of_apps_be.Models;
using System.Collections.Generic;

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
        
        }
    }
}
