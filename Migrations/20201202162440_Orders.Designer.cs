﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20201202162440_Orders")]
    partial class Orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Data.Shoes.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryName");

                    b.Property<string>("desc");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shop.Data.Shoes.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress");

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<DateTime>("orderTime");

                    b.Property<string>("phone");

                    b.Property<string>("surname");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shop.Data.Shoes.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ShoesID");

                    b.Property<int>("orderID");

                    b.Property<long>("price");

                    b.Property<int?>("productid");

                    b.HasKey("id");

                    b.HasIndex("orderID");

                    b.HasIndex("productid");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Shop.Data.Shoes.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("available");

                    b.Property<int>("categoryID");

                    b.Property<string>("ing");

                    b.Property<bool>("isFavorite");

                    b.Property<string>("longDesc");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<string>("shortDesc");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Shop.Data.Shoes.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<int>("price");

                    b.Property<int?>("productid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Shop.Data.Shoes.OrderDetail", b =>
                {
                    b.HasOne("Shop.Data.Shoes.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.Data.Shoes.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");
                });

            modelBuilder.Entity("Shop.Data.Shoes.Product", b =>
                {
                    b.HasOne("Shop.Data.Shoes.Category", "Category")
                        .WithMany("shoes")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Shop.Data.Shoes.ShopCartItem", b =>
                {
                    b.HasOne("Shop.Data.Shoes.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");
                });
#pragma warning restore 612, 618
        }
    }
}
