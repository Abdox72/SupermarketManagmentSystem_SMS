using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Models;
using SupermarketManagmentSystem_SMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagmentSystem_SMS.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //make national id unique
            builder.Entity<User>()
                .HasIndex(u => u.NationalID)
                .IsUnique();


            builder.Entity<User>().HasData(
                new User
                {
                    ID = 1,
                    FirstName = "Abdo",
                    LastName = "Mustafa",
                    NationalID = "12345678901234",
                    PasswordHash = AuthenticationService.HashPassword("admin123"),
                    Role = Utilities.UserRole.Admin
                },
                new User
                {
                    ID = 2,
                    FirstName = "Ahmed",
                    LastName = "Ali",
                    NationalID = "23456789012345",
                    PasswordHash = AuthenticationService.HashPassword("cashier123"),
                    Role = Utilities.UserRole.Cashier
                }
            );
            builder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Fruits"},
                new Category { CategoryID = 2, Name = "Vegetables" }
            );
            builder.Entity<Product>().HasData(
                new Product { ProductID = 1, Barcode = "111", Name = "Apple", Price = 1.2m, CategoryID = 1, Quantity = 50 },
                new Product { ProductID = 2, Barcode = "222", Name = "Banana", Price = 0.8m, CategoryID = 1, Quantity = 20 },
                new Product { ProductID = 3, Barcode = "333", Name = "Carrot", Price = 0.5m, CategoryID = 2, Quantity = 15 },
                new Product { ProductID = 4, Barcode = "444", Name = "Broccoli", Price = 1.0m, CategoryID = 2, Quantity = 12 }
            );

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }

        
    }
}
