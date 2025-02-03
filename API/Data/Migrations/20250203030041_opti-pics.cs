using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.migrations
{
    /// <inheritdoc />
    public partial class optipics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-1-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-2-0.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-3-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-4-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-5-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-6-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-4.webp\"]", "https://blobstorage1114.blob.core.windows.net/images/product-6-0.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-7-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-8-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-0.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-10-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-10-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-10-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-10-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-10-5.webp\"]", "https://blobstorage1114.blob.core.windows.net/images/product-10-0.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-11-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-12-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-13-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-14-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-15-0.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product-16-0.webp");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product2.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product3.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product4.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product5.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-6-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\"]", "https://blobstorage1114.blob.core.windows.net/images/product6.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product7.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "PictureUrl",
                value: "https://blobstorage1114.blob.core.windows.net/images/product8.webp");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product7.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/5.webp\"]", "https://blobstorage1114.blob.core.windows.net/images/product10.webp" });

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
    }
}
