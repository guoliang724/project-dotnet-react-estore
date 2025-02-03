using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.migrations
{
    /// <inheritdoc />
    public partial class product1416 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-15-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-15-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-15-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-15-4.webp\"]");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DemoImages",
                value: "[\"https://blobstorage1114.blob.core.windows.net/images/product-16-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-16-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-16-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-16-4.webp\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "DemoImages",
                value: null);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "DemoImages",
                value: null);
        }
    }
}
