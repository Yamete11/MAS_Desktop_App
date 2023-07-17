﻿// <auto-generated />
using System;
using MAS_BE.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MAS_BE.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MAS_BE.Entities.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("ClosedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdOrderType")
                        .HasColumnType("int");

                    b.Property<float>("Sum")
                        .HasColumnType("real");

                    b.Property<int?>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("IdOrder");

                    b.HasIndex("IdOrderType");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            IdOrder = 1,
                            CreateAt = new DateTime(2023, 7, 17, 16, 56, 5, 571, DateTimeKind.Local).AddTicks(5612),
                            IdOrderType = 1,
                            Sum = 30.4f
                        },
                        new
                        {
                            IdOrder = 2,
                            CreateAt = new DateTime(2023, 7, 17, 16, 56, 5, 573, DateTimeKind.Local).AddTicks(7813),
                            IdOrderType = 1,
                            Sum = 13f
                        });
                });

            modelBuilder.Entity("MAS_BE.Entities.OrderProduct", b =>
                {
                    b.Property<int>("IdOrderProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOrder")
                        .HasColumnType("int");

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.HasKey("IdOrderProduct");

                    b.HasIndex("IdOrder");

                    b.HasIndex("IdProduct");

                    b.ToTable("OrderProducts");

                    b.HasData(
                        new
                        {
                            IdOrderProduct = 1,
                            IdOrder = 1,
                            IdProduct = 1
                        },
                        new
                        {
                            IdOrderProduct = 2,
                            IdOrder = 1,
                            IdProduct = 2
                        },
                        new
                        {
                            IdOrderProduct = 3,
                            IdOrder = 1,
                            IdProduct = 3
                        },
                        new
                        {
                            IdOrderProduct = 4,
                            IdOrder = 1,
                            IdProduct = 5
                        },
                        new
                        {
                            IdOrderProduct = 5,
                            IdOrder = 2,
                            IdProduct = 4
                        },
                        new
                        {
                            IdOrderProduct = 6,
                            IdOrder = 2,
                            IdProduct = 6
                        });
                });

            modelBuilder.Entity("MAS_BE.Entities.OrderType", b =>
                {
                    b.Property<int>("IdOrderType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOrderType");

                    b.ToTable("OrderTypes");

                    b.HasData(
                        new
                        {
                            IdOrderType = 1,
                            Title = "Take away"
                        },
                        new
                        {
                            IdOrderType = 2,
                            Title = "For here"
                        });
                });

            modelBuilder.Entity("MAS_BE.Entities.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProductCategory")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdProductCategory");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            IdProduct = 1,
                            IdProductCategory = 1,
                            Price = 3.7f,
                            Title = "Pizza"
                        },
                        new
                        {
                            IdProduct = 2,
                            IdProductCategory = 1,
                            Price = 11f,
                            Title = "Burger"
                        },
                        new
                        {
                            IdProduct = 3,
                            IdProductCategory = 1,
                            Price = 9.5f,
                            Title = "Sushi"
                        },
                        new
                        {
                            IdProduct = 4,
                            IdProductCategory = 2,
                            Price = 4.8f,
                            Title = "Cosmopolitan"
                        },
                        new
                        {
                            IdProduct = 5,
                            IdProductCategory = 2,
                            Price = 6.2f,
                            Title = "Old Fashion"
                        },
                        new
                        {
                            IdProduct = 6,
                            IdProductCategory = 2,
                            Price = 8.2f,
                            Title = "Pornstar Martini"
                        });
                });

            modelBuilder.Entity("MAS_BE.Entities.ProductCategory", b =>
                {
                    b.Property<int>("IdProductCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProductCategory");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            IdProductCategory = 1,
                            Title = "Food"
                        },
                        new
                        {
                            IdProductCategory = 2,
                            Title = "Drink"
                        });
                });

            modelBuilder.Entity("MAS_BE.Entities.Order", b =>
                {
                    b.HasOne("MAS_BE.Entities.OrderType", "OrderType")
                        .WithMany("Orders")
                        .HasForeignKey("IdOrderType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderType");
                });

            modelBuilder.Entity("MAS_BE.Entities.OrderProduct", b =>
                {
                    b.HasOne("MAS_BE.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("IdOrder")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MAS_BE.Entities.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MAS_BE.Entities.Product", b =>
                {
                    b.HasOne("MAS_BE.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("IdProductCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("MAS_BE.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("MAS_BE.Entities.OrderType", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MAS_BE.Entities.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("MAS_BE.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
