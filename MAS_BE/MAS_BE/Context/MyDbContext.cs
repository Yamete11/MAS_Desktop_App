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
        public virtual DbSet<OrderType> OrderTypes { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Ingridient> Ingridients { get; set; }
        public virtual DbSet<ProductIngridient> ProductIngridients { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Waiter> Waiters { get; set; }

        public MyDbContext()
        {

        }

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Waiter>(t =>
            {
                t.HasData(
                    new Waiter { IdWaiter = 1, FirstName = "Gleb", LastName = "Ivanov", Student = true, Adress = "Adress", Email = "email@gmail.com", TelNumber = "14312412", DateOfBirthday = DateTime.Now });

            });

            modelBuilder.Entity<Manager>(t =>
            {
                t.HasData(
                    new Manager { IdManager = 1, SALARY = 12f, Code = "123", DateOfBirthday = DateTime.Now, FirstName = "Gleb", LastName = "Ivanov", Adress = "Adress", Email = "email@gmail.com", Student = true, TelNumber = "14312412"});

            });

            modelBuilder.Entity<Client>(t =>
            {
                t.HasData(
                    new Client { IdClient = 1, FirstName = "Gleb", LastName = "Ivanov", Discount = true, Email = "email@gmail.com", TelNumber = "12312341"});

            });


            modelBuilder.Entity<Report>(t =>
            {
                t.HasData(
                    new Report { IdReport = 1, CreateAt = DateTime.Now, Revenue = 100f, OrderQuantity = 3, IdManger = 1});

            });


            modelBuilder.Entity<Ingridient>(t =>
            {
                t.HasData(
                    new Ingridient { IdIngridient = 1, Title = "First Ingridient", Weight = 23.5f},
                    new Ingridient { IdIngridient = 2, Title = "Second Ingridient", Weight = 25.5f },
                    new Ingridient { IdIngridient = 3, Title = "Third Ingridient", Weight = 21.5f });

            });

            modelBuilder.Entity<ProductIngridient>(t =>
            {
                t.HasData(
                    new ProductIngridient { IdProductIngridient = 1, IdProduct = 1, IdIngridient = 1},
                    new ProductIngridient { IdProductIngridient = 2, IdProduct = 1, IdIngridient = 3},
                    new ProductIngridient { IdProductIngridient = 3, IdProduct = 2, IdIngridient = 2});

            });


            modelBuilder.Entity<Product>(t =>
            {
                t.HasData(
                    new Product { IdProduct = 1, Title = "Pizza", Price = 3.7f, IdProductCategory = 1},
                    new Product { IdProduct = 2, Title = "Burger", Price = 11f, IdProductCategory = 1 },
                    new Product { IdProduct = 3, Title = "Sushi", Price = 9.5f, IdProductCategory = 1 },
                    new Product { IdProduct = 4, Title = "Cosmopolitan", Price = 4.8f, IdProductCategory = 2 },
                    new Product { IdProduct = 5, Title = "Old Fashion", Price = 6.2f, IdProductCategory = 2 },
                    new Product { IdProduct = 6, Title = "Pornstar Martini", Price = 8.2f, IdProductCategory = 2 });
            });

            modelBuilder.Entity<Receipt>(t =>
            {
                t.HasData(
                    new Receipt { IdReceipt = 1, createdAt = DateTime.Now, Sum = 30.4f, PaymentMethod = PaymentMethod.Cash});

            });

            modelBuilder.Entity<ProductCategory>(t =>
            {
                t.HasData(
                    new ProductCategory { IdProductCategory = 1, Title = "Food" },
                    new ProductCategory { IdProductCategory = 2, Title = "Drink" });

            });

            modelBuilder.Entity<OrderType>(t =>
            {
                t.HasData(
                    new OrderType { IdOrderType = 1, Title = "Take away" },
                    new OrderType { IdOrderType = 2, Title = "For here" });

            });

            modelBuilder.Entity<Order>(t =>
            {
                t.HasData(
                    new Order { IdOrder = 1, Sum = 30.4f, CreateAt = DateTime.Now, IdOrderType = 1, ClosedAt = DateTime.Now , IdReceipt = 1, IdClient = 1},
                    new Order { IdOrder = 2, Sum = 13f, CreateAt = DateTime.Now, IdOrderType = 1, IdClient = 1});
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
