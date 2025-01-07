using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateproduct34 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Subtotal",
                table: "Orders",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "OrderItem",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-3-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-4.webp\"]", "<div class='product-description'>\r\n  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>\r\n  <p>\r\n    Say goodbye to dirt and streaks with our premium \r\n    <strong>Microfiber Cleaning Cloths</strong>. Designed to be \r\n    <em>gentle yet powerful</em>, these cloths are perfect for cleaning \r\n    <strong>all types of surfaces</strong>, from glass to wood and everything in between.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>\r\n    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>\r\n    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>\r\n    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>\r\n  </ul>\r\n  <p>\r\n    Upgrade your cleaning routine with these versatile and environmentally-friendly \r\n    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are \r\n    the ultimate cleaning companion.\r\n  </p>\r\n</div>", "Microfiber cleaning cloths, reusable and effective on all surfaces.", "https://blobstorage1114.blob.core.windows.net/images/product3.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-4-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-4.webp\"]", "<div class='product-description'>\r\n  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>\r\n  <p>\r\n    Say goodbye to dirt and streaks with our premium \r\n    <strong>Microfiber Cleaning Cloths</strong>. Designed to be \r\n    <em>gentle yet powerful</em>, these cloths are perfect for cleaning \r\n    <strong>all types of surfaces</strong>, from glass to wood and everything in between.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>\r\n    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>\r\n    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>\r\n    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>\r\n  </ul>\r\n  <p>\r\n    Upgrade your cleaning routine with these versatile and environmentally-friendly \r\n    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are \r\n    the ultimate cleaning companion.\r\n  </p>\r\n</div>", "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.", "https://blobstorage1114.blob.core.windows.net/images/product4.webp" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Subtotal",
                table: "Orders",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "OrderItem",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Microfiber cleaning cloths, reusable and effective on all surfaces.", "Microfiber cleaning cloths", "imgs/products/product3.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DemoImages", "Description", "Name", "PictureUrl" },
                values: new object[] { null, "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.", "Net Core Super cleaner", "imgs/products/product4.jpg" });
        }
    }
}
