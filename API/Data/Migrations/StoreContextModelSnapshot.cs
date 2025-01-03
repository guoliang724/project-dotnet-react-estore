﻿// <auto-generated />
using System;
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
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

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

                    b.Property<string>("DemoImages")
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
                            Brand = "Leon's Cleaning",
                            DemoImages = "[\"https://blobstorage1114.blob.core.windows.net/images/product-1-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-5.webp\"]",
                            Description = "<div class='product-description'>\r\n  <h2>Biodegradable Dish Soap - Gentle on Hands</h2>\r\n  <p>\r\n    Keep your dishes sparkling clean while caring for the environment with our \r\n    <strong>Biodegradable Dish Soap</strong>. Made from \r\n    <em>natural ingredients</em>, this soap is tough on grease but gentle on your hands.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Eco-Friendly:</strong> Completely biodegradable, reducing environmental impact.</li>\r\n    <li><strong>Natural Formula:</strong> Made with plant-based ingredients for a safer clean.</li>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for sensitive hands with no harsh chemicals.</li>\r\n    <li><strong>Powerful Cleaning:</strong> Effectively cuts through grease and grime.</li>\r\n  </ul>\r\n  <p>\r\n    Choose a product that combines <strong>sustainability</strong> and <strong>effectiveness</strong>. \r\n    Make dishwashing a cleaner, greener experience today!\r\n  </p>\r\n</div>",
                            Name = "Biodegradable dish soap made from natural ingredients, gentle on hands.",
                            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product1.jpg",
                            Price = 13.99,
                            QuantityInStock = 13,
                            Type = "Bath"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "eSayClean",
                            DemoImages = "[\"https://blobstorage1114.blob.core.windows.net/images/product-2-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-5.webp\"]",
                            Description = "<div class='product-description'>\r\n  <h2>Non-Toxic, Plant-Based Laundry Detergent for Sensitive Skin</h2>\r\n  <p>\r\n    Experience a gentle yet effective clean with our \r\n    <strong>Non-Toxic, Plant-Based Laundry Detergent</strong>. Specially formulated for those with \r\n    <em>sensitive skin</em>, this detergent is free from harsh chemicals and powered by natural ingredients.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for individuals with allergies or sensitivities.</li>\r\n    <li><strong>Plant-Based Formula:</strong> Made with eco-friendly, biodegradable ingredients.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harmful chemicals, ensuring a safe and clean wash.</li>\r\n    <li><strong>Fresh Clean:</strong> Effectively removes stains and odors while leaving your clothes soft.</li>\r\n  </ul>\r\n  <p>\r\n    Make the switch to a detergent that’s as kind to your skin as it is to the planet. \r\n    Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.\r\n  </p>\r\n</div>",
                            Name = "Non-toxic, plant-based laundry detergent for sensitive skin",
                            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product2.jpg",
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
                            DemoImages = "[\"https://blobstorage1114.blob.core.windows.net/images/1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/5.webp\"]",
                            Description = "<p>\r\n                Elevate your bathroom or spa experience with our\r\n                <strong>luxuriously soft white rolled towels</strong>. Made from\r\n                premium-quality cotton, these towels are ultra-absorbent,\r\n                durable, and gentle on the skin, making them perfect for\r\n                everyday use or special occasions. Each towel is elegantly\r\n                rolled and displayed on a stylish macrame swing, showcasing a\r\n                clean, minimalist aesthetic that blends effortlessly into any\r\n                décor. Whether you're upgrading your bathroom essentials or\r\n                looking for a thoughtful gift, these towels combine practicality\r\n                with timeless sophistication.\r\n              </p>\r\n              <ul className='list-disc list-inside'>\r\n                <li>\r\n                  <strong>Material</strong>: 100% Premium Cotton\r\n                </li>\r\n                <li>\r\n                  <strong>Features</strong>: Highly absorbent, quick-drying, and\r\n                  soft to the touch\r\n                </li>\r\n                <li>\r\n                  <strong>Ideal For</strong>: Bathrooms, spas, or as decorative\r\n                  accents\r\n                </li>\r\n                <li>\r\n                  <strong>Care Instructions</strong>: Machine washable, tumble\r\n                  dry on low\r\n                </li>\r\n              </ul>\r\n              <p>\r\n                Bring a touch of elegance and comfort to your home with these\r\n                versatile and beautifully designed towels.\r\n              </p>",
                            Name = "Glass cleaner leaves streak-free shine, no residue left behind",
                            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product10.webp",
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

            modelBuilder.Entity("API.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "c64b9068-86e2-40f3-99bd-299edaf9c740",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "4e3d51c0-88b8-4fdb-b3aa-fe259b2c6a8f",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.Basket", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
