using dressShop_Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace dressShop_Razor.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elegant", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Simple", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Leather", DisplayOrder = 3 }
                );
        }
    }
}