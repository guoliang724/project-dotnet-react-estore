using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.migrations
{
    /// <inheritdoc />
    public partial class product814 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-8-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-8-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-8-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-8-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-8-5.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { "[\"https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product7.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp\"]", "https://blobstorage1114.blob.core.windows.net/images/product-7-3.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-11-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-11-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-11-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-11-4.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-12-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-12-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-12-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-12-4.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-13-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-13-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-13-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-13-4.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-14-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-14-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-14-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-14-4.webp\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "DemoImages",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DemoImages", "PictureUrl" },
                values: new object[] { null, "https://blobstorage1114.blob.core.windows.net/images/product9.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "DemoImages",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "DemoImages",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "DemoImages",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "DemoImages",
                value: null);
        }
    }
}
