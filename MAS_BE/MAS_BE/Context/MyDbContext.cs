using MAS_BE.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace MAS_BE.Context
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }

        public virtual DbSet<ProductCategory> ProductCategories { get; set; }

        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

       

            modelBuilder.Entity<Product>(t =>
            {
                t.HasData(
                    new Product { IdProduct = 1, Title = "Pizza", Price = 3.7f, IdProductCategory = 1 },
                    new Product { IdProduct = 2, Title = "Burger", Price = 11f, IdProductCategory = 1 },
                    new Product { IdProduct = 3, Title = "Sushi", Price = 9.5f, IdProductCategory = 1 },
                    new Product { IdProduct = 4, Title = "Cosmopolitan", Price = 4.8f, IdProductCategory = 2 },
                    new Product { IdProduct = 5, Title = "Old Fashion", Price = 6.2f, IdProductCategory = 2 },
                    new Product { IdProduct = 6, Title = "Pornstar Martini", Price = 8.2f, IdProductCategory = 2 });
            });

            modelBuilder.Entity<ProductCategory>(t =>
            {
                t.HasData(
                    new ProductCategory { IdProductCategory = 1, Title = "Food" },
                    new ProductCategory { IdProductCategory = 2, Title = "Drink" });

            });

            modelBuilder.Entity<Order>(t =>
            {
                t.HasData(
                    new Order { IdOrder = 1, Sum = 30.4f, CreateAt = new DateTime()},
                    new Order { IdOrder = 2, Sum = 13f, CreateAt = new DateTime()});
            });

            modelBuilder.Entity<OrderProduct>(t =>
            {
                t.HasData(
                    new OrderProduct { IdOrderProduct = 1, IdOrder = 1, IdProduct = 1 },
                    new OrderProduct { IdOrderProduct = 2, IdOrder = 1, IdProduct = 2 },
                    new OrderProduct { IdOrderProduct = 3, IdOrder = 1, IdProduct = 3 },
                    new OrderProduct { IdOrderProduct = 4, IdOrder = 1, IdProduct = 5 },
                    new OrderProduct { IdOrderProduct = 5, IdOrder = 2, IdProduct = 4 },
                    new OrderProduct { IdOrderProduct = 6, IdOrder = 2, IdProduct = 6 });

            });

        }
    }
}
