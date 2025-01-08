
using API.Entities;
using API.Entities.OrderAggregate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
  public class StoreContext : IdentityDbContext<User, Role, int>
  {
    public StoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Basket> Baskets { get; set; }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<User>()
      .HasOne(a => a.Address)
      .WithOne()
      .HasForeignKey<UserAddress>(a => a.Id)
      .OnDelete(DeleteBehavior.Cascade);


      modelBuilder.Entity<Product>().HasData(
          new Product
          {
            Id = 1,
            Name = "Biodegradable dish.",
            literalDescription = "Biodegradable dish soap made from natural ingredients, gentle on hands.",
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
            literalDescription = "Make the switch to a detergent that’s as kind to your skin as it is to the planet. Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.",
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
            Name = "Microfiber cleaning cloths, reusable and effective on all surfaces.",
            literalDescription = "Say goodbye to dirt and streaks with our premium Microfiber Cleaning Cloths. Designed to be gentle yet powerful, these cloths are perfect for cleaning all types of surfaces, from glass to wood and everything in between.",
            Description = @"<div class='product-description'>
  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>
  <p>
    Say goodbye to dirt and streaks with our premium 
    <strong>Microfiber Cleaning Cloths</strong>. Designed to be 
    <em>gentle yet powerful</em>, these cloths are perfect for cleaning 
    <strong>all types of surfaces</strong>, from glass to wood and everything in between.
  </p>
  <ul>
    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>
    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>
    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>
    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>
  </ul>
  <p>
    Upgrade your cleaning routine with these versatile and environmentally-friendly 
    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are 
    the ultimate cleaning companion.
  </p>
</div>",
            Price = 18.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product3.webp",
            Brand = "Timerland",
            Type = "Cloths",
            QuantityInStock = 18,
            DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-3-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-3-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-3-3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-3-4.webp",
                  }
          },
          new Product
          {
            Id = 4,
            Name = "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.",
            Description = @"<div class='product-description'>
  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>
  <p>
    Say goodbye to dirt and streaks with our premium 
    <strong>Microfiber Cleaning Cloths</strong>. Designed to be 
    <em>gentle yet powerful</em>, these cloths are perfect for cleaning 
    <strong>all types of surfaces</strong>, from glass to wood and everything in between.
  </p>
  <ul>
    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>
    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>
    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>
    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>
  </ul>
  <p>
    Upgrade your cleaning routine with these versatile and environmentally-friendly 
    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are 
    the ultimate cleaning companion.
  </p>
</div>",
            Price = 14.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product4.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 19,
            DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-4-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-4-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-4-3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-4-4.webp",
                  }
          },
          new Product
          {
            Id = 5,
            Name = "Natural wood polish restores shine without harmful chemicals.Combining functionality and sustainability, this collection is perfect for a mindful, environmentally conscious lifestyle",
            Description = @"<div class='product-description'>
  <h2>Natural and Sustainable Beauty Essentials</h2>
  <p>
    Transform your self-care routine with this thoughtfully curated set of 
    <strong>eco-friendly beauty essentials</strong>. Combining functionality 
    and sustainability, this collection is perfect for a mindful, 
    environmentally conscious lifestyle.
  </p>
  <ul>
    <li><strong>Natural Wooden Body Brush:</strong> Features soft, natural bristles for gentle exfoliation and improved circulation.</li>
    <li><strong>Powdered Skincare:</strong> A jar of gentle exfoliating powder to refresh and rejuvenate your skin.</li>
    <li><strong>Reusable Cotton Pads:</strong> Soft and durable, ideal for makeup removal and reducing waste.</li>
    <li><strong>Handcrafted Soap Bar:</strong> Made with natural ingredients, perfect for a luxurious cleanse.</li>
    <li><strong>Textured Fabric Pouch:</strong> A stylish and practical addition for storing your beauty essentials.</li>
  </ul>
  <p>
    Embrace a <strong>minimalistic aesthetic</strong> while caring for the planet. 
    This set is designed to elevate your skincare experience, bringing together 
    beauty, sustainability, and simplicity in one luxurious package.
  </p>
</div>",
            Price = 15.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product5.webp",
            Brand = "eSayClean",
            Type = "Bath",
            QuantityInStock = 14,
            DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-5-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-5-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-5-3.webp",                  }
          },
          new Product
          {
            Id = 6,
            Name = "This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.",
            literalDescription = "Combining effective antibacterial action with the nourishing benefits of aloe vera, this hand sanitizer is a must-have for maintaining hygiene without compromising on skin care. Ideal for everyday use and suitable for all skin types.",
            Description = @"<div class='product-description'>
  <h1>Whimsical Cat-Themed Ceramic Tea Set</h1>
  <p>
    Add a touch of charm to your tea time with this delightful <strong>cat-themed ceramic tea set</strong>. Featuring playful cat illustrations with vibrant umbrellas, this set is both functional and a beautiful piece of art. Perfect for cat lovers and tea enthusiasts alike!
  </p>
  <p><strong>What's Included:</strong></p>
  <ul>
    <li>1 Teapot with a sturdy handle and whimsical design</li>
    <li>Matching teacups with playful cat and umbrella illustrations</li>
    <li>Beautifully crafted saucers to complete the set</li>
  </ul>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>High-Quality Ceramic:</strong> Durable, heat-resistant material for long-lasting use.</li>
    <li><strong>Adorable Design:</strong> Colorful and playful cat illustrations with umbrella accents.</li>
    <li><strong>Perfect for Any Occasion:</strong> Ideal for tea parties, casual use, or as a unique gift.</li>
    <li><strong>Easy to Clean:</strong> Smooth surface makes cleaning a breeze.</li>
  </ul>
  <p><strong>Specifications:</strong></p>
  <ul>
    <li>Material: High-quality ceramic</li>
    <li>Teapot Capacity: 1.2 liters</li>
    <li>Number of Cups: 6 matching teacups</li>
    <li>Design: Playful cats with colorful umbrellas</li>
  </ul>
  <p>
    This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.8/5) - 'Such a cute tea set! The cat designs are adorable, and the quality is excellent.'
  </p>
</div>",
            Price = 30.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product6.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 12,
            DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-6-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-6-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp",
                         "https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp",                     }
          },
          new Product
          {
            Id = 7,
            Name = "Antibacterial hand sanitizer",
            literalDescription = "This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care.",
            Description = @"<div class='product-description'>
  <h1>Antibacterial Hand Sanitizer with Moisturizing Aloe Vera Gel</h1>
  <p>
    Keep your hands clean and germ-free with our <strong>antibacterial hand sanitizer</strong>. Infused with <em>moisturizing aloe vera gel</em>, it provides effective protection while keeping your skin soft and hydrated.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Powerful Germ Protection:</strong> Eliminates 99.9% of bacteria and viruses.</li>
    <li><strong>Moisturizing Formula:</strong> Enriched with aloe vera to prevent dryness and irritation.</li>
    <li><strong>Quick Absorption:</strong> Non-sticky, fast-drying formula for hassle-free use.</li>
    <li><strong>Portable and Convenient:</strong> Ideal for use at home, work, or on the go.</li>
  </ul>
  <p>
    This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★☆ (4.5/5) - 'Keeps my hands feeling fresh and moisturized. Love the aloe vera scent!'
  </p>
</div>",
            Price = 41.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product7.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 21,
            DemoImages = new(){
                        "https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-7-3.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp",
                        "https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp",                }

          },
          new Product
          {
            Id = 8,
            Name = "Green eSayClean Woolen bleach",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Oxygen bleach alternative, safe for colors and the environment.",
            Price = 23.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product8.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 32,
          },
          new Product
          {
            Id = 9,
            Name = "Citrus degreaser",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Citrus degreaser cuts through tough grease without harsh fumes.",
            Price = 13.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product9.webp",
            Brand = "eSayClean",
            Type = "Cloths",
            QuantityInStock = 10,
          },
          new Product
          {
            Id = 10,
            Name = "Glass cleaner leaves streak-free shine, no residue left behind",
            literalDescription = "Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.",
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
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Carpet shampooer with stain remover for deep cleaning carpets.",
            Price = 15.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product11.webp",
            Brand = "eSayClean",
            Type = "Cloths",
            QuantityInStock = 100,
          },
          new Product
          {
            Id = 12,
            Name = "Enzyme-based drain cleaner",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Enzyme-based drain cleaner safely breaks down organic matter.",
            Price = 19.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product12.webp",
            Brand = "eSayClean",
            Type = "Cloths",
            QuantityInStock = 12,
          },
          new Product
          {
            Id = 13,
            Name = "Mineral-based toilet bowl cleaner",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Mineral-based toilet bowl cleaner, effective and environmentally friendly.",
            Price = 18.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product13.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 100,
          },
          new Product
          {
            Id = 14,
            Name = "eSayClean Red Cloths",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Odor eliminator uses activated charcoal to absorb bad smells.",
            Price = 29.99,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product14.webp",
            Brand = "eSayClean",
            Type = "Cloths",
            QuantityInStock = 32,
          },
          new Product
          {
            Id = 15,
            Name = "Vinegar-free fabric softener",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Vinegar-free fabric softener, keeps clothes soft and fresh.",
            Price = 34.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product15.webp",
            Brand = "eSayClean",
            Type = "Cleaner",
            QuantityInStock = 12,
          },
          new Product
          {
            Id = 16,
            Name = "Car wash solution",
            Description = @"<div class='product-description'>
  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>
  <p>
    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.
  </p>
  <p><strong>Key Features:</strong></p>
  <ul>
    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>
    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>
    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>
    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>
  </ul>
  <p>
    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.
  </p>
  <p><strong>Customer Reviews:</strong></p>
  <p>
    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'
  </p>
</div>",
            literalDescription = "Eco-friendly car wash solution, biodegradable and non-toxic.",
            Price = 43.00,
            PictureUrl = "https://blobstorage1114.blob.core.windows.net/images/product16.webp",
            Brand = "eSayClean",
            Type = "Bath",
            QuantityInStock = 100,
          }
      );


      modelBuilder.Entity<Role>().HasData(
          new Role { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
          new Role { Id = 2, Name = "Member", NormalizedName = "MEMBER" }
      );


    }
  }
}