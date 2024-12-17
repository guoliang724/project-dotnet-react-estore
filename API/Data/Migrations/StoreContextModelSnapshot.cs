﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("API.Entities.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuyerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("API.Entities.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasketId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("ProductId");

                    b.ToTable("BasketItems");
                });

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
                            Brand = "eSayClean",
                            Description = "Biodegradable dish soap made from natural ingredients, gentle on hands.",
                            Name = "Biodegradable dish soap",
                            PictureUrl = "imgs/products/product1.jpg",
                            Price = 13.99,
                            QuantityInStock = 13,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "eSayClean",
                            Description = "Non-toxic, plant-based laundry detergent for sensitive skin",
                            Name = "Non-toxic laundry detergent",
                            PictureUrl = "imgs/products/product2.jpg",
                            Price = 29.989999999999998,
                            QuantityInStock = 12,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "eSayClean",
                            Description = "Microfiber cleaning cloths, reusable and effective on all surfaces.",
                            Name = "Microfiber cleaning cloths",
                            PictureUrl = "imgs/products/product3.jpg",
                            Price = 18.989999999999998,
                            QuantityInStock = 18,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "eSayClean",
                            Description = "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.",
                            Name = "Net Core Super cleaner",
                            PictureUrl = "imgs/products/product4.jpg",
                            Price = 14.99,
                            QuantityInStock = 19,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "eSayClean",
                            Description = "Natural wood polish restores shine without harmful chemicals.",
                            Name = "Natural wood",
                            PictureUrl = "imgs/products/product5.jpg",
                            Price = 15.0,
                            QuantityInStock = 14,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "eSayClean",
                            Description = "Essential oil-infused room sprays for a fresh, natural scent.",
                            Name = "Typescript Entry sprays",
                            PictureUrl = "imgs/products/product6.jpg",
                            Price = 30.989999999999998,
                            QuantityInStock = 12,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "eSayClean",
                            Description = "Antibacterial hand sanitizer with moisturizing aloe vera gel.",
                            Name = "Hand sanitizer",
                            PictureUrl = "imgs/products/product7.jpg",
                            Price = 41.0,
                            QuantityInStock = 21,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "eSayClean",
                            Description = "Oxygen bleach alternative, safe for colors and the environment.",
                            Name = "Green eSayClean Woolen bleach",
                            PictureUrl = "imgs/products/product8.jpg",
                            Price = 23.0,
                            QuantityInStock = 32,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "eSayClean",
                            Description = "Citrus degreaser cuts through tough grease without harsh fumes.",
                            Name = "Citrus degreaser",
                            PictureUrl = "imgs/products/product9.jpg",
                            Price = 13.0,
                            QuantityInStock = 10,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "eSayClean",
                            Description = "Glass cleaner leaves streak-free shine, no residue left behind.",
                            Name = "Blue Code Cloths",
                            PictureUrl = "imgs/products/product10.jpg",
                            Price = 19.989999999999998,
                            QuantityInStock = 10,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "eSayClean",
                            Description = "Carpet shampooer with stain remover for deep cleaning carpets.",
                            Name = "Green Code Cloths",
                            PictureUrl = "imgs/products/product11.jpg",
                            Price = 15.99,
                            QuantityInStock = 100,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "eSayClean",
                            Description = "Enzyme-based drain cleaner safely breaks down organic matter.",
                            Name = "Enzyme-based drain cleaner",
                            PictureUrl = "imgs/products/product12.jpg",
                            Price = 19.989999999999998,
                            QuantityInStock = 12,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "eSayClean",
                            Description = "Mineral-based toilet bowl cleaner, effective and environmentally friendly.",
                            Name = "Mineral-based toilet bowl cleaner",
                            PictureUrl = "imgs/products/product13.jpg",
                            Price = 18.989999999999998,
                            QuantityInStock = 100,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "eSayClean",
                            Description = "Odor eliminator uses activated charcoal to absorb bad smells.",
                            Name = "eSayClean Red Cloths",
                            PictureUrl = "imgs/products/product14.jpg",
                            Price = 29.989999999999998,
                            QuantityInStock = 32,
                            Type = "Cloths"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "eSayClean",
                            Description = "Vinegar-free fabric softener, keeps clothes soft and fresh.",
                            Name = "Vinegar-free fabric softener",
                            PictureUrl = "imgs/products/product15.jpg",
                            Price = 34.0,
                            QuantityInStock = 12,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "eSayClean",
                            Description = "Eco-friendly car wash solution, biodegradable and non-toxic.",
                            Name = "Car wash solution",
                            PictureUrl = "imgs/products/product16.jpg",
                            Price = 43.0,
                            QuantityInStock = 100,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "eSayClean",
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            Name = "Stainless steel polish cleaner",
                            PictureUrl = "imgs/products/product17.jpg",
                            Price = 13.0,
                            QuantityInStock = 32,
                            Type = "Cleaner"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "eSayClean",
                            Description = "Air purifying plants that improve indoor air quality naturally.",
                            Name = "Air purifying plants",
                            PictureUrl = "imgs/products/product18.jpg",
                            Price = 22.0,
                            QuantityInStock = 22,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "eSayClean",
                            Description = "Long-handled back brush for easy reach and exfoliation.",
                            Name = "Long-handled back brush",
                            PictureUrl = "imgs/products/product19.jpg",
                            Price = 23.0,
                            QuantityInStock = 11,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 20,
                            Brand = "eSayClean",
                            Description = "Calligraphy brush with flexible bristles for expressive writing.",
                            Name = "eSayClean Blue Cloths",
                            PictureUrl = "imgs/products/product20.jpg",
                            Price = 24.0,
                            QuantityInStock = 23,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 21,
                            Brand = "eSayClean",
                            Description = "Bottle brush cleans hard-to-reach areas of containers.",
                            Name = "Pet grooming brush",
                            PictureUrl = "imgs/products/product21.jpg",
                            Price = 19.989999999999998,
                            QuantityInStock = 21,
                            Type = "Bath"
                        });
                });

            modelBuilder.Entity("API.Entities.BasketItem", b =>
                {
                    b.HasOne("API.Entities.Basket", "Basket")
                        .WithMany("Items")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("API.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
