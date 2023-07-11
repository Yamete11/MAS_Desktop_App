using MAS_BE.Entities;
using Microsoft.EntityFrameworkCore;

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

        }
    }
}
