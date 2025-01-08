using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "literalDescription",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "literalDescription" },
                values: new object[] { "Biodegradable dish.", "Biodegradable dish soap made from natural ingredients, gentle on hands." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "literalDescription",
                value: "Make the switch to a detergent that’s as kind to your skin as it is to the planet. Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "literalDescription",
                value: "Say goodbye to dirt and streaks with our premium Microfiber Cleaning Cloths. Designed to be gentle yet powerful, these cloths are perfect for cleaning all types of surfaces, from glass to wood and everything in between.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "literalDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "literalDescription",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Whimsical Cat-Themed Ceramic Tea Set</h1>\r\n  <p>\r\n    Add a touch of charm to your tea time with this delightful <strong>cat-themed ceramic tea set</strong>. Featuring playful cat illustrations with vibrant umbrellas, this set is both functional and a beautiful piece of art. Perfect for cat lovers and tea enthusiasts alike!\r\n  </p>\r\n  <p><strong>What's Included:</strong></p>\r\n  <ul>\r\n    <li>1 Teapot with a sturdy handle and whimsical design</li>\r\n    <li>Matching teacups with playful cat and umbrella illustrations</li>\r\n    <li>Beautifully crafted saucers to complete the set</li>\r\n  </ul>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>High-Quality Ceramic:</strong> Durable, heat-resistant material for long-lasting use.</li>\r\n    <li><strong>Adorable Design:</strong> Colorful and playful cat illustrations with umbrella accents.</li>\r\n    <li><strong>Perfect for Any Occasion:</strong> Ideal for tea parties, casual use, or as a unique gift.</li>\r\n    <li><strong>Easy to Clean:</strong> Smooth surface makes cleaning a breeze.</li>\r\n  </ul>\r\n  <p><strong>Specifications:</strong></p>\r\n  <ul>\r\n    <li>Material: High-quality ceramic</li>\r\n    <li>Teapot Capacity: 1.2 liters</li>\r\n    <li>Number of Cups: 6 matching teacups</li>\r\n    <li>Design: Playful cats with colorful umbrellas</li>\r\n  </ul>\r\n  <p>\r\n    This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.8/5) - 'Such a cute tea set! The cat designs are adorable, and the quality is excellent.'\r\n  </p>\r\n</div>", "Combining effective antibacterial action with the nourishing benefits of aloe vera, this hand sanitizer is a must-have for maintaining hygiene without compromising on skin care. Ideal for everyday use and suitable for all skin types." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Antibacterial Hand Sanitizer with Moisturizing Aloe Vera Gel</h1>\r\n  <p>\r\n    Keep your hands clean and germ-free with our <strong>antibacterial hand sanitizer</strong>. Infused with <em>moisturizing aloe vera gel</em>, it provides effective protection while keeping your skin soft and hydrated.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Powerful Germ Protection:</strong> Eliminates 99.9% of bacteria and viruses.</li>\r\n    <li><strong>Moisturizing Formula:</strong> Enriched with aloe vera to prevent dryness and irritation.</li>\r\n    <li><strong>Quick Absorption:</strong> Non-sticky, fast-drying formula for hassle-free use.</li>\r\n    <li><strong>Portable and Convenient:</strong> Ideal for use at home, work, or on the go.</li>\r\n  </ul>\r\n  <p>\r\n    This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★☆ (4.5/5) - 'Keeps my hands feeling fresh and moisturized. Love the aloe vera scent!'\r\n  </p>\r\n</div>", "Antibacterial hand sanitizer", "This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PictureUrl", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "https://blobstorage1114.blob.core.windows.net/images/product8.webp", "Oxygen bleach alternative, safe for colors and the environment." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PictureUrl", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "https://blobstorage1114.blob.core.windows.net/images/product9.webp", "Citrus degreaser cuts through tough grease without harsh fumes." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "literalDescription",
                value: "Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Carpet shampooer with stain remover for deep cleaning carpets." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Enzyme-based drain cleaner safely breaks down organic matter." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Mineral-based toilet bowl cleaner, effective and environmentally friendly." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Odor eliminator uses activated charcoal to absorb bad smells." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Vinegar-free fabric softener, keeps clothes soft and fresh." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "literalDescription" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Eco-friendly car wash solution, biodegradable and non-toxic." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "literalDescription",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Biodegradable dish soap made from natural ingredients, gentle on hands.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "<div class='product-description'>\r\n  <h1>Whimsical Cat-Themed Ceramic Tea Set</h1>\r\n  <p>\r\n    Add a touch of charm to your tea time with this delightful <strong>cat-themed ceramic tea set</strong>. Featuring playful cat illustrations with vibrant umbrellas, this set is both functional and a beautiful piece of art. Perfect for cat lovers and tea enthusiasts alike!\r\n  </p>\r\n  <h2>What's Included:</h2>\r\n  <ul>\r\n    <li>1 Teapot with a sturdy handle and whimsical design</li>\r\n    <li>Matching teacups with playful cat and umbrella illustrations</li>\r\n    <li>Beautifully crafted saucers to complete the set</li>\r\n  </ul>\r\n  <h2>Key Features:</h2>\r\n  <ul>\r\n    <li><strong>High-Quality Ceramic:</strong> Durable, heat-resistant material for long-lasting use.</li>\r\n    <li><strong>Adorable Design:</strong> Colorful and playful cat illustrations with umbrella accents.</li>\r\n    <li><strong>Perfect for Any Occasion:</strong> Ideal for tea parties, casual use, or as a unique gift.</li>\r\n    <li><strong>Easy to Clean:</strong> Smooth surface makes cleaning a breeze.</li>\r\n  </ul>\r\n  <h2>Product Specifications:</h2>\r\n  <table>\r\n    <tr>\r\n      <th>Material</th>\r\n      <td>High-quality ceramic</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Teapot Capacity</th>\r\n      <td>1.2 liters</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Number of Cups</th>\r\n      <td>6 matching teacups</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Design</th>\r\n      <td>Playful cats with colorful umbrellas</td>\r\n    </tr>\r\n  </table>\r\n  <h2>Why You'll Love It:</h2>\r\n  <p>\r\n    This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.\r\n  </p>\r\n  <h2>Customer Reviews:</h2>\r\n  <p>\r\n    ★★★★★ (4.8/5) - 'Such a cute tea set! The cat designs are adorable, and the quality is excellent.'\r\n  </p>\r\n</div>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<div class='product-description'>\r\n  <h1>Antibacterial Hand Sanitizer with Moisturizing Aloe Vera Gel</h1>\r\n  <p>\r\n    Stay protected and keep your hands germ-free with our <strong>antibacterial hand sanitizer</strong>. Formulated with <em>moisturizing aloe vera gel</em>, it effectively kills 99.9% of germs while ensuring your hands remain soft and hydrated.\r\n  </p>\r\n  <h2>Key Features:</h2>\r\n  <ul>\r\n    <li><strong>Powerful Germ Protection:</strong> Eliminates 99.9% of bacteria and viruses.</li>\r\n    <li><strong>Moisturizing Formula:</strong> Enriched with aloe vera to prevent dryness and irritation.</li>\r\n    <li><strong>Quick Absorption:</strong> Non-sticky, fast-drying formula for hassle-free use.</li>\r\n    <li><strong>Portable and Convenient:</strong> Perfect for use at home, work, or on the go.</li>\r\n  </ul>\r\n  <h2>Why Choose This Product?</h2>\r\n  <p>\r\n    Combining effective antibacterial action with the nourishing benefits of aloe vera, this hand sanitizer is a must-have for maintaining hygiene without compromising on skin care. Ideal for everyday use and suitable for all skin types.\r\n  </p>\r\n  <h2>Specifications:</h2>\r\n  <table>\r\n    <tr>\r\n      <th>Volume</th>\r\n      <td>250ml</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Fragrance</th>\r\n      <td>Fresh Aloe Vera</td>\r\n    </tr>\r\n    <tr>\r\n      <th>Usage</th>\r\n      <td>Apply a small amount and rub hands together until dry.</td>\r\n    </tr>\r\n  </table>\r\n  <h2>Customer Reviews:</h2>\r\n  <p>\r\n    ★★★★☆ (4.5/5) - 'Leaves my hands feeling clean and soft. Love the aloe vera touch!'\r\n  </p>\r\n</div>", "Antibacterial hand sanitizer with moisturizing aloe vera gel." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "PictureUrl" },
                values: new object[] { "Oxygen bleach alternative, safe for colors and the environment.", "imgs/products/product8.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "PictureUrl" },
                values: new object[] { "Citrus degreaser cuts through tough grease without harsh fumes.", "imgs/products/product9.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Carpet shampooer with stain remover for deep cleaning carpets.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Enzyme-based drain cleaner safely breaks down organic matter.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Mineral-based toilet bowl cleaner, effective and environmentally friendly.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Odor eliminator uses activated charcoal to absorb bad smells.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Vinegar-free fabric softener, keeps clothes soft and fresh.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Eco-friendly car wash solution, biodegradable and non-toxic.");
        }
    }
}
