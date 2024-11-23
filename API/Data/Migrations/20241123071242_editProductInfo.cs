using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class editProductInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Biodegradable dish soap made from natural ingredients, gentle on hands.", "Biodegradable dish soap", 13, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Non-toxic, plant-based laundry detergent for sensitive skin", "Non-toxic laundry detergent", 12, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Microfiber cleaning cloths, reusable and effective on all surfaces.", "Microfiber cleaning cloths", 18, "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "Description", "Name", "Price", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.", "Net Core Super cleaner", 14.99, 19, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Natural wood polish restores shine without harmful chemicals.", "Natural wood", 14, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Essential oil-infused room sprays for a fresh, natural scent.", "Typescript Entry sprays", 12, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Antibacterial hand sanitizer with moisturizing aloe vera gel.", "Hand sanitizer", 21, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Oxygen bleach alternative, safe for colors and the environment.", "Green eSayClean Woolen bleach", 32, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Citrus degreaser cuts through tough grease without harsh fumes.", "Citrus degreaser", 10, "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "Description", "Name", "Price", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Glass cleaner leaves streak-free shine, no residue left behind.", "Blue Code Cloths", 19.989999999999998, 10, "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "eSayClean", "Carpet shampooer with stain remover for deep cleaning carpets.", "Green Code Cloths", "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Enzyme-based drain cleaner safely breaks down organic matter.", "Enzyme-based drain cleaner", 12, "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "eSayClean", "Mineral-based toilet bowl cleaner, effective and environmentally friendly.", "Mineral-based toilet bowl cleaner", "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Odor eliminator uses activated charcoal to absorb bad smells.", "eSayClean Red Cloths", 32, "Cloths" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Vinegar-free fabric softener, keeps clothes soft and fresh.", "Vinegar-free fabric softener", 12, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "eSayClean", "Eco-friendly car wash solution, biodegradable and non-toxic.", "Car wash solution", "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Brand", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Stainless steel polish cleaner", 32, "Cleaner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Air purifying plants that improve indoor air quality naturally.", "Air purifying plants", 22, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Long-handled back brush for easy reach and exfoliation.", "Long-handled back brush", 11, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Calligraphy brush with flexible bristles for expressive writing.", "eSayClean Blue Cloths", 23, "Bath" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "eSayClean", "Bottle brush cleans hard-to-reach areas of containers.", "Pet grooming brush", 21, "Bath" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Angular Speedster Board 2000", 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.", "Green Angular Board 3000", 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "NetCore", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Core Board Speed Rush 3", 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Brand", "Description", "Name", "Price", "QuantityInStock", "Type" },
                values: new object[] { "NetCore", "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Net Core Super Board", 14.0, 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "React", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "React Board Super Whizzy Fast", 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "TypeScript", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Typescript Entry Board", 100, "Boards" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "NetCore", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Core Blue Hat", 100, "Hats" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green React Woolen Hat", 100, "Hats" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Purple React Woolen Hat", 100, "Hats" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Brand", "Description", "Name", "Price", "QuantityInStock", "Type" },
                values: new object[] { "VS Code", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Blue Code Gloves", 19.0, 100, "Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "VS Code", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green Code Gloves", "Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Purple React Gloves", 100, "Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "React", "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Green React Gloves", "Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Redis", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Redis Red Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "NetCore", "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.", "Core Red Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Brand", "Description", "Name", "Type" },
                values: new object[] { "NetCore", "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.", "Core Purple Boots", "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Brand", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Angular Purple Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", 100, "Boots" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Brand", "Description", "Name", "QuantityInStock", "Type" },
                values: new object[] { "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", 100, "Boots" });
        }
    }
}
