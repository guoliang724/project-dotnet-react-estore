using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateproduct12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "Leon's Cleaning", "[\"https://blobstorage1114.blob.core.windows.net/images/product-1-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-5.webp\"]", "<div class='product-description'>\r\n  <h2>Biodegradable Dish Soap - Gentle on Hands</h2>\r\n  <p>\r\n    Keep your dishes sparkling clean while caring for the environment with our \r\n    <strong>Biodegradable Dish Soap</strong>. Made from \r\n    <em>natural ingredients</em>, this soap is tough on grease but gentle on your hands.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Eco-Friendly:</strong> Completely biodegradable, reducing environmental impact.</li>\r\n    <li><strong>Natural Formula:</strong> Made with plant-based ingredients for a safer clean.</li>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for sensitive hands with no harsh chemicals.</li>\r\n    <li><strong>Powerful Cleaning:</strong> Effectively cuts through grease and grime.</li>\r\n  </ul>\r\n  <p>\r\n    Choose a product that combines <strong>sustainability</strong> and <strong>effectiveness</strong>. \r\n    Make dishwashing a cleaner, greener experience today!\r\n  </p>\r\n</div>", "Biodegradable dish soap made from natural ingredients, gentle on hands.", "https://blobstorage1114.blob.core.windows.net/images/product1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-2-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-5.webp\"]", "<div class='product-description'>\r\n  <h2>Non-Toxic, Plant-Based Laundry Detergent for Sensitive Skin</h2>\r\n  <p>\r\n    Experience a gentle yet effective clean with our \r\n    <strong>Non-Toxic, Plant-Based Laundry Detergent</strong>. Specially formulated for those with \r\n    <em>sensitive skin</em>, this detergent is free from harsh chemicals and powered by natural ingredients.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for individuals with allergies or sensitivities.</li>\r\n    <li><strong>Plant-Based Formula:</strong> Made with eco-friendly, biodegradable ingredients.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harmful chemicals, ensuring a safe and clean wash.</li>\r\n    <li><strong>Fresh Clean:</strong> Effectively removes stains and odors while leaving your clothes soft.</li>\r\n  </ul>\r\n  <p>\r\n    Make the switch to a detergent that’s as kind to your skin as it is to the planet. \r\n    Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.\r\n  </p>\r\n</div>", "Non-toxic, plant-based laundry detergent for sensitive skin", "https://blobstorage1114.blob.core.windows.net/images/product2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "eSayClean", null, "Biodegradable dish soap made from natural ingredients, gentle on hands.", "Biodegradable dish soap", "imgs/products/product1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Non-toxic, plant-based laundry detergent for sensitive skin", "Non-toxic laundry detergent", "imgs/products/product2.jpg" });
        }
    }
}
