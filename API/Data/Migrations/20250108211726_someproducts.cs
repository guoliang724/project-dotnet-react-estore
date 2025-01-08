using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class someproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Brand",
                value: "Timerland");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-5-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-5-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-5-3.webp\"]", "<div class='product-description'>\r\n  <h2>Natural and Sustainable Beauty Essentials</h2>\r\n  <p>\r\n    Transform your self-care routine with this thoughtfully curated set of \r\n    <strong>eco-friendly beauty essentials</strong>. Combining functionality \r\n    and sustainability, this collection is perfect for a mindful, \r\n    environmentally conscious lifestyle.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Natural Wooden Body Brush:</strong> Features soft, natural bristles for gentle exfoliation and improved circulation.</li>\r\n    <li><strong>Powdered Skincare:</strong> A jar of gentle exfoliating powder to refresh and rejuvenate your skin.</li>\r\n    <li><strong>Reusable Cotton Pads:</strong> Soft and durable, ideal for makeup removal and reducing waste.</li>\r\n    <li><strong>Handcrafted Soap Bar:</strong> Made with natural ingredients, perfect for a luxurious cleanse.</li>\r\n    <li><strong>Textured Fabric Pouch:</strong> A stylish and practical addition for storing your beauty essentials.</li>\r\n  </ul>\r\n  <p>\r\n    Embrace a <strong>minimalistic aesthetic</strong> while caring for the planet. \r\n    This set is designed to elevate your skincare experience, bringing together \r\n    beauty, sustainability, and simplicity in one luxurious package.\r\n  </p>\r\n</div>", "Natural wood polish restores shine without harmful chemicals.Combining functionality and sustainability, this collection is perfect for a mindful, environmentally conscious lifestyle", "https://blobstorage1114.blob.core.windows.net/images/product5.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-6-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\"]", "<div class='product-description'>\r\n  <h1>Whimsical Cat-Themed Ceramic Tea Set</h1>\r\n  <p>\r\n    Add a touch of charm to your tea time with this delightful <strong>cat-themed ceramic tea set</strong>. Featuring playful cat illustrations with vibrant umbrellas, this set is both functional and a beautiful piece of art. Perfect for cat lovers and tea enthusiasts alike!\r\n  </p>\r\n  <h2>What's Included:</h2>\r\n  <ul>\r\n    <li>1 Teapot with a sturdy handle and whimsical design</li>\r\n    <li>Matching teacups with playful cat and umbrella illustrations</li>\r\n    <li>Beautifully crafted saucers to complete the set</li>\r\n  </ul>\r\n  <h2>Key Features:</h2>\r\n  <ul>\r\n    <li><strong>High-Quality Ceramic:</strong> Durable, heat-resistant material for long-lasting use.</li>\r\n    <li><strong>Adorable Design:</strong> Colorful and playful cat illustrations with umbrella accents.</li>\r\n    <li><strong>Perfect for Any Occasion:</strong> Ideal for tea parties, casual use, or as a unique gift.</li>\r\n    <li><strong>Easy to Clean:</strong> Smooth surface makes cleaning a breeze.</li>\r\n  </ul>\r\n  <h2>Product Specifications:</h2>\r\n  <table>\r\n    <tr>\r\n      <th>Material</th>\r\n      <td>High-quality ceramic</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Teapot Capacity</th>\r\n      <td>1.2 liters</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Number of Cups</th>\r\n      <td>6 matching teacups</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Design</th>\r\n      <td>Playful cats with colorful umbrellas</td>\r\n    </tr>\r\n  </table>\r\n  <h2>Why You'll Love It:</h2>\r\n  <p>\r\n    This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.\r\n  </p>\r\n  <h2>Customer Reviews:</h2>\r\n  <p>\r\n    ★★★★★ (4.8/5) - 'Such a cute tea set! The cat designs are adorable, and the quality is excellent.'\r\n  </p>\r\n</div>", "This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.", "https://blobstorage1114.blob.core.windows.net/images/product6.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp\"]", "<div class='product-description'>\r\n  <h1>Antibacterial Hand Sanitizer with Moisturizing Aloe Vera Gel</h1>\r\n  <p>\r\n    Stay protected and keep your hands germ-free with our <strong>antibacterial hand sanitizer</strong>. Formulated with <em>moisturizing aloe vera gel</em>, it effectively kills 99.9% of germs while ensuring your hands remain soft and hydrated.\r\n  </p>\r\n  <h2>Key Features:</h2>\r\n  <ul>\r\n    <li><strong>Powerful Germ Protection:</strong> Eliminates 99.9% of bacteria and viruses.</li>\r\n    <li><strong>Moisturizing Formula:</strong> Enriched with aloe vera to prevent dryness and irritation.</li>\r\n    <li><strong>Quick Absorption:</strong> Non-sticky, fast-drying formula for hassle-free use.</li>\r\n    <li><strong>Portable and Convenient:</strong> Perfect for use at home, work, or on the go.</li>\r\n  </ul>\r\n  <h2>Why Choose This Product?</h2>\r\n  <p>\r\n    Combining effective antibacterial action with the nourishing benefits of aloe vera, this hand sanitizer is a must-have for maintaining hygiene without compromising on skin care. Ideal for everyday use and suitable for all skin types.\r\n  </p>\r\n  <h2>Specifications:</h2>\r\n  <table>\r\n    <tr>\r\n      <th>Volume</th>\r\n      <td>250ml</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Fragrance</th>\r\n      <td>Fresh Aloe Vera</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Usage</th>\r\n      <td>Apply a small amount and rub hands together until dry.</td>\r\n    </tr>\r\n  </table>\r\n  <h2>Customer Reviews:</h2>\r\n  <p>\r\n    ★★★★☆ (4.5/5) - 'Leaves my hands feeling clean and soft. Love the aloe vera touch!'\r\n  </p>\r\n</div>", "Antibacterial hand sanitizer with moisturizing aloe vera gel.", "https://blobstorage1114.blob.core.windows.net/images/product7.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product11.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product12.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product13.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product14.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product15.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product16.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Brand",
                value: "eSayClean");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Natural wood polish restores shine without harmful chemicals.", "Natural wood", "imgs/products/product5.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Essential oil-infused room sprays for a fresh, natural scent.", "Typescript Entry sprays", "imgs/products/product6.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Antibacterial hand sanitizer with moisturizing aloe vera gel.", "Hand sanitizer", "imgs/products/product7.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "PictureUrl",
                value: "imgs/products/product11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "PictureUrl",
                value: "imgs/products/product12.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "PictureUrl",
                value: "imgs/products/product13.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "PictureUrl",
                value: "imgs/products/product14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "PictureUrl",
                value: "imgs/products/product15.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "PictureUrl",
                value: "imgs/products/product16.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "DemoImages", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 17, "eSayClean", null, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.", "Stainless steel polish cleaner", "imgs/products/product17.jpg", 13.0, 32, "Cleaner" },
                    { 18, "eSayClean", null, "Air purifying plants that improve indoor air quality naturally.", "Air purifying plants", "imgs/products/product18.jpg", 22.0, 22, "Bath" },
                    { 19, "eSayClean", null, "Long-handled back brush for easy reach and exfoliation.", "Long-handled back brush", "imgs/products/product19.jpg", 23.0, 11, "Bath" },
                    { 20, "eSayClean", null, "Calligraphy brush with flexible bristles for expressive writing.", "eSayClean Blue Cloths", "imgs/products/product20.jpg", 24.0, 23, "Bath" },
                    { 21, "eSayClean", null, "Bottle brush cleans hard-to-reach areas of containers.", "Pet grooming brush", "imgs/products/product21.jpg", 19.989999999999998, 21, "Bath" }
                });
        }
    }
}
