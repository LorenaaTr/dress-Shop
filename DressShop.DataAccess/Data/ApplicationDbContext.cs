using DressShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DressShop.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }                      //Table Name
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Elegant", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Simple", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Leather", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
               new Company { Id = 1, Name = "ZaraShop",StreetAddress="123 Albi Mall", 
                  City="Prishtina", State="Kosova", PostalCode="10000", PhoneNumber="038111222"},
               new Company { Id = 2, Name = "S.Oliver", StreetAddress = "123 Albi Mall",
                   City = "Prishtina", State = "Kosova",PostalCode = "10000", PhoneNumber = "038111222" },
               new Company { Id = 3, Name = "Bershka",StreetAddress = "123 Albi Mall",
                   City = "Prishtina",State = "Kosova", PostalCode = "10000",PhoneNumber = "038111222"  }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product {
                    Id = 1,
                    Title = "Satin Red Dress", 
                    ListPrice = 105,
                    Price = 75,
                    Price50 = 50, 
                    Price100 = 25,
                    CategoryId = 1,
                    ImageUrl = "",
                    Description = "Elegant Satin dress perfect for wedding"
                },
                 new Product
                 {
                     Id = 2,
                     Title = "Foil Print Slip Dress",
                     ListPrice = 125,
                     Price = 85,
                     Price50 = 40,
                     Price100 = 35,
                     CategoryId = 1,
                     ImageUrl = "",
                     Description = "Classy and Unique dress, made with love to celebreate feelings"
                 },
                   new Product
                   {
                       Id = 3,
                       Title = "Shirt Dress With Belt",
                       ListPrice = 125,
                       Price = 85,
                       Price50 = 40,
                       Price100 = 35,
                       CategoryId = 2,
                       ImageUrl = "",
                       Description = "Casual dress, perfect for holidays fashion week"
                   },
                    new Product
                    {
                        Id = 4,
                        Title = "Shiny Midi Dress",
                        ListPrice = 55,
                        Price = 30,
                        Price50 = 20,
                        Price100 = 10,
                        CategoryId = 2,
                        ImageUrl = "",
                        Description = "Casual every day dress, look stylish"
                    },
                     new Product
                     {
                         Id = 5,
                         Title = "Draped Faux Long Leather Dress",
                         ListPrice = 92,
                         Price = 80,
                         Price50 = 55,
                         Price100 = 25,
                         CategoryId = 6,
                         ImageUrl = "",
                         Description = "Black Leather dress for unforgettable look"
                     },
                      new Product
                      {
                          Id = 6,
                          Title = "Short Draped Faux Leather Dress ",
                          ListPrice = 35,
                          Price = 25,
                          Price50 = 10,
                          Price100 = 5,
                          CategoryId = 6,
                          ImageUrl = "",
                          Description = "Short leather dress, best choise for date night"
                      }
                );
        }
    }
}
