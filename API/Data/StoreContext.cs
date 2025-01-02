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
        public DbSet<Basket> Baskets { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Biodegradable dish soap made from natural ingredients, gentle on hands.",
                    Description = @"<div class='product-description'>
  <h2>Biodegradable Dish Soap - Gentle on Hands</h2>
  <p>
    Keep your dishes sparkling clean while caring for the environment with our 
    <strong>Biodegradable Dish Soap</strong>. Made from 
    <em>natural ingredients</em>, this soap is tough on grease but gentle on your hands.
  </p>
  <ul>
    <li><strong>Eco-Friendly:</strong> Completely biodegradable, reducing environmental impact.</li>
    <li><strong>Natural Formula:</strong> Made with plant-based ingredients for a safer clean.</li>
    <li><strong>Gentle on Skin:</strong> Perfect for sensitive hands with no harsh chemicals.</li>
    <li><strong>Powerful Cleaning:</strong> Effectively cuts through grease and grime.</li>
  </ul>
  <p>
    Choose a product that combines <strong>sustainability</strong> and <strong>effectiveness</strong>. 
    Make dishwashing a cleaner, greener experience today!
  </p>
</div>",
                    Price = 13.99,
                    PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product1.jpg",
                    Brand = "Leon's Cleaning",
                    Type = "Bath",
                    QuantityInStock = 13,
                    DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-1-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-1-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-1-3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-1-4.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-1-5.webp"
                        }
                },
                new Product
                {
                    Id = 2,
                    Name = "Non-toxic, plant-based laundry detergent for sensitive skin",
                    Description = @"<div class='product-description'>
  <h2>Non-Toxic, Plant-Based Laundry Detergent for Sensitive Skin</h2>
  <p>
    Experience a gentle yet effective clean with our 
    <strong>Non-Toxic, Plant-Based Laundry Detergent</strong>. Specially formulated for those with 
    <em>sensitive skin</em>, this detergent is free from harsh chemicals and powered by natural ingredients.
  </p>
  <ul>
    <li><strong>Gentle on Skin:</strong> Perfect for individuals with allergies or sensitivities.</li>
    <li><strong>Plant-Based Formula:</strong> Made with eco-friendly, biodegradable ingredients.</li>
    <li><strong>Non-Toxic:</strong> Free from harmful chemicals, ensuring a safe and clean wash.</li>
    <li><strong>Fresh Clean:</strong> Effectively removes stains and odors while leaving your clothes soft.</li>
  </ul>
  <p>
    Make the switch to a detergent that’s as kind to your skin as it is to the planet. 
    Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.
  </p>
</div>",
                    Price = 29.99,
                    PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product2.jpg",
                    Brand = "eSayClean",
                    Type = "Bath",
                    QuantityInStock = 12,
                    DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-2-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-2-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-2-3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-2-4.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-2-5.webp"
                        }
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
                    Name = "Glass cleaner leaves streak-free shine, no residue left behind",
                    Description = @"<p>
                Elevate your bathroom or spa experience with our
                <strong>luxuriously soft white rolled towels</strong>. Made from
                premium-quality cotton, these towels are ultra-absorbent,
                durable, and gentle on the skin, making them perfect for
                everyday use or special occasions. Each towel is elegantly
                rolled and displayed on a stylish macrame swing, showcasing a
                clean, minimalist aesthetic that blends effortlessly into any
                décor. Whether you're upgrading your bathroom essentials or
                looking for a thoughtful gift, these towels combine practicality
                with timeless sophistication.
              </p>
              <ul className='list-disc list-inside'>
                <li>
                  <strong>Material</strong>: 100% Premium Cotton
                </li>
                <li>
                  <strong>Features</strong>: Highly absorbent, quick-drying, and
                  soft to the touch
                </li>
                <li>
                  <strong>Ideal For</strong>: Bathrooms, spas, or as decorative
                  accents
                </li>
                <li>
                  <strong>Care Instructions</strong>: Machine washable, tumble
                  dry on low
                </li>
              </ul>
              <p>
                Bring a touch of elegance and comfort to your home with these
                versatile and beautifully designed towels.
              </p>",
                    Price = 19.99,
                    PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product10.webp",
                    Brand = "eSayClean",
                    Type = "Cloths",
                    QuantityInStock = 10,
                    DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/4.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/5.webp"
                        }
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