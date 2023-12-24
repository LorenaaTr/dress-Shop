using DressShop.Models;
using Microsoft.EntityFrameworkCore;

namespace DressShop.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elegant", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Simple", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Leather", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Title = "Satin Red Dress", 
                    ListPrice = 105,
                    Price = 75,
                    Price50 = 50, 
                    Price100 = 25 },
                 new Product
                 {
                     Id = 2,
                     Title = "Foil Print Slip Dress",
                     ListPrice = 125,
                     Price = 85,
                     Price50 = 40,
                     Price100 = 35
                 },
                   new Product
                   {
                       Id = 3,
                       Title = "Shirt Dress With Belt",
                       ListPrice = 125,
                       Price = 85,
                       Price50 = 40,
                       Price100 = 35
                   },
                    new Product
                    {
                        Id = 4,
                        Title = "Shiny Midi Dress",
                        ListPrice = 55,
                        Price = 30,
                        Price50 = 20,
                        Price100 = 10
                    },
                     new Product
                     {
                         Id = 5,
                         Title = "Draped Faux Long Leather Dress",
                         ListPrice = 92,
                         Price = 80,
                         Price50 = 55,
                         Price100 = 25
                     },
                      new Product
                      {
                          Id = 6,
                          Title = "Short Draped Faux Leather Dress ",
                          ListPrice = 35,
                          Price = 25,
                          Price50 = 10,
                          Price100 = 5
                      }
                );
        }
    }
}
