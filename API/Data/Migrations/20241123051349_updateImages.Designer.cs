﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20241123051349_updateImages")]
    partial class updateImages
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("API.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Angular",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Angular Speedster Board 2000",
                            PictureUrl = "../../img/products/product1.jpg",
                            Price = 13.99,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Angular",
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            Name = "Green Angular Board 3000",
                            PictureUrl = "../../img/products/product2.jpg",
                            Price = 29.989999999999998,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "NetCore",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Core Board Speed Rush 3",
                            PictureUrl = "../../img/products/product3.jpg",
                            Price = 18.989999999999998,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Net Core Super Board",
                            PictureUrl = "../../img/products/product4.jpg",
                            Price = 14.0,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "React",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "React Board Super Whizzy Fast",
                            PictureUrl = "../../img/products/product5.jpg",
                            Price = 15.0,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "TypeScript",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Typescript Entry Board",
                            PictureUrl = "../../img/products/product6.jpg",
                            Price = 30.989999999999998,
                            QuantityInStock = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "NetCore",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Blue Hat",
                            PictureUrl = "../../img/products/product7.jpg",
                            Price = 41.0,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Woolen Hat",
                            PictureUrl = "../../img/products/product8.jpg",
                            Price = 23.0,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Woolen Hat",
                            PictureUrl = "../../img/products/product9.jpg",
                            Price = 13.0,
                            QuantityInStock = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Blue Code Gloves",
                            PictureUrl = "../../img/products/product10.jpg",
                            Price = 19.0,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green Code Gloves",
                            PictureUrl = "../../img/products/product11.jpg",
                            Price = 15.99,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Gloves",
                            PictureUrl = "../../img/products/product12.jpg",
                            Price = 19.989999999999998,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Gloves",
                            PictureUrl = "../../img/products/product13.jpg",
                            Price = 18.989999999999998,
                            QuantityInStock = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Redis",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Redis Red Boots",
                            PictureUrl = "../../img/products/product14.jpg",
                            Price = 29.989999999999998,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "NetCore",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Red Boots",
                            PictureUrl = "../../img/products/product15.jpg",
                            Price = 34.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Core Purple Boots",
                            PictureUrl = "../../img/products/product16.jpg",
                            Price = 43.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "Angular",
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            Name = "Angular Purple Boots",
                            PictureUrl = "../../img/products/product17.jpg",
                            Price = 13.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "../../img/products/product18.jpg",
                            Price = 22.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "../../img/products/product19.jpg",
                            Price = 23.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 20,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "../../img/products/product20.jpg",
                            Price = 24.0,
                            QuantityInStock = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 21,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "../../img/products/product21.jpg",
                            Price = 19.989999999999998,
                            QuantityInStock = 100,
                            Type = "Boots"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
