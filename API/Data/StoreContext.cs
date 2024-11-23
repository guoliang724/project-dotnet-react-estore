using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Biodegradable dish soap",
                    Description = "Biodegradable dish soap made from natural ingredients, gentle on hands.",
                    Price = 13.99,
                    PictureUrl = "imgs/products/product1.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 13,
                },
                new Product
                {
                    Id = 2,
                    Name = "Non-toxic laundry detergent",
                    Description = "Non-toxic, plant-based laundry detergent for sensitive skin",
                    Price = 29.99,
                    PictureUrl = "imgs/products/product2.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 12,
                },
                new Product
                {
                    Id = 3,
                    Name = "Microfiber cleaning cloths",
                    Description = "Microfiber cleaning cloths, reusable and effective on all surfaces.",
                    Price = 18.99,
                    PictureUrl = "imgs/products/product3.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 18,
                },
                new Product
                {
                    Id = 4,
                    Name = "Net Core Super cleaner",
                    Description = "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.",
                    Price = 14.99,
                    PictureUrl = "imgs/products/product4.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 19,
                },
                new Product
                {
                    Id = 5,
                    Name = "Natural wood",
                    Description = "Natural wood polish restores shine without harmful chemicals.",
                    Price = 15.00,
                    PictureUrl = "imgs/products/product5.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 14,
                },
                new Product
                {
                    Id = 6,
                    Name = "Typescript Entry sprays",
                    Description = "Essential oil-infused room sprays for a fresh, natural scent.",
                    Price = 30.99,
                    PictureUrl = "imgs/products/product6.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 12,
                },
                new Product
                {
                    Id = 7,
                    Name = "Hand sanitizer",
                    Description = "Antibacterial hand sanitizer with moisturizing aloe vera gel.",
                    Price = 41.00,
                    PictureUrl = "imgs/products/product7.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 21,
                },
                new Product
                {
                    Id = 8,
                    Name = "Green eSayClean Woolen bleach",
                    Description = "Oxygen bleach alternative, safe for colors and the environment.",
                    Price = 23.00,
                    PictureUrl = "imgs/products/product8.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 32,
                },
                new Product
                {
                    Id = 9,
                    Name = "Citrus degreaser",
                    Description = "Citrus degreaser cuts through tough grease without harsh fumes.",
                    Price = 13.00,
                    PictureUrl = "imgs/products/product9.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 10,
                },
                new Product
                {
                    Id = 10,
                    Name = "Blue Code Cloths",
                    Description = "Glass cleaner leaves streak-free shine, no residue left behind.",
                    Price = 19.99,
                    PictureUrl = "imgs/products/product10.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 10,
                },
                new Product
                {
                    Id = 11,
                    Name = "Green Code Cloths",
                    Description = "Carpet shampooer with stain remover for deep cleaning carpets.",
                    Price = 15.99,
                    PictureUrl = "imgs/products/product11.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 100,
                },
                new Product
                {
                    Id = 12,
                    Name = "Enzyme-based drain cleaner",
                    Description = "Enzyme-based drain cleaner safely breaks down organic matter.",
                    Price = 19.99,
                    PictureUrl = "imgs/products/product12.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 12,
                },
                new Product
                {
                    Id = 13,
                    Name = "Mineral-based toilet bowl cleaner",
                    Description = "Mineral-based toilet bowl cleaner, effective and environmentally friendly.",
                    Price = 18.99,
                    PictureUrl = "imgs/products/product13.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 100,
                },
                new Product
                {
                    Id = 14,
                    Name = "eSayClean Red Cloths",
                    Description = "Odor eliminator uses activated charcoal to absorb bad smells.",
                    Price = 29.99,
                    PictureUrl = "imgs/products/product14.jpg",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 32,
                },
                new Product
                {
                    Id = 15,
                    Name = "Vinegar-free fabric softener",
                    Description = "Vinegar-free fabric softener, keeps clothes soft and fresh.",
                    Price = 34.00,
                    PictureUrl = "imgs/products/product15.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 12,
                },
                new Product
                {
                    Id = 16,
                    Name = "Car wash solution",
                    Description = "Eco-friendly car wash solution, biodegradable and non-toxic.",
                    Price = 43.00,
                    PictureUrl = "imgs/products/product16.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 100,
                },
                new Product
                {
                    Id = 17,
                    Name = "Stainless steel polish cleaner",
                    Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                    Price = 13.00,
                    PictureUrl = "imgs/products/product17.jpg",
                    Brand = "eSayClean",
                    Type = "Cleaner",
                    QuantityInStock = 32,
                },
                new Product
                {
                    Id = 18,
                    Name = "Air purifying plants",
                    Description = "Air purifying plants that improve indoor air quality naturally.",
                    Price = 22.00,
                    PictureUrl = "imgs/products/product18.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 22,
                },
                new Product
                {
                    Id = 19,
                    Name = "Long-handled back brush",
                    Description = "Long-handled back brush for easy reach and exfoliation.",
                    Price = 23,
                    PictureUrl = "imgs/products/product19.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 11,
                },
                new Product
                {
                    Id = 20,
                    Name = "eSayClean Blue Cloths",
                    Description = "Calligraphy brush with flexible bristles for expressive writing.",
                    Price = 24.00,
                    PictureUrl = "imgs/products/product20.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 23,
                },
                new Product
                {
                    Id = 21,
                    Name = "Pet grooming brush",
                    Description = "Bottle brush cleans hard-to-reach areas of containers.",
                    Price = 19.99,
                    PictureUrl = "imgs/products/product21.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 21,
                }
            );
        }
    }
}