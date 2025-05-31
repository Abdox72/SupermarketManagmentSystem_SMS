using Microsoft.EntityFrameworkCore;
using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Managment_System_SMS.Data
{
    public class ApplicationDContext: DbContext
    {
        public ApplicationDContext(DbContextOptions<ApplicationDContext> options)
            : base(options)
        {
        }

        public ApplicationDContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=SupermarketManagementSystem.db");
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
                    PasswordHash = "admin123",
                    Role = SupermarketManagmentSystem_SMS.Utilities.UserRole.Admin
                },
                new User
                {
                    ID = 2,
                    FirstName = "Ahmed",
                    LastName = "Ali",
                    NationalID = "23456789012345",
                    PasswordHash = "cashier123",
                    Role = SupermarketManagmentSystem_SMS.Utilities.UserRole.Cashier
                }
            );
            builder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Fruits"},
                new Category { CategoryID = 2, Name = "Vegetables" }
            );
            builder.Entity<Product>().HasData(
                new Product { ProductID = 1, Name = "Apple", Price = 1.2m, CategoryID = 1 },
                new Product { ProductID = 2, Name = "Banana", Price = 0.8m, CategoryID = 1 },
                new Product { ProductID = 3, Name = "Carrot", Price = 0.5m, CategoryID = 2 },
                new Product { ProductID = 4, Name = "Broccoli", Price = 1.0m, CategoryID = 2 }
            );

        }

        public DbSet<User> User { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
    }
}
