using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class addseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Products",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product1.png", 13.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product2.png", 29.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product3.png", 18.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product4.png", 14.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product5.png", 15.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product6.png", 30.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product7.png", 41.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product8.png", 23.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product9.png", 13.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product10.png", 19.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product11.png", 15.99 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product12.png", 19.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product13.png", 18.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product14.png", 29.989999999999998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product15.png", 34.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product16.png", 43.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product17.png", 13.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "../../img/products/product18.png", 22.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 19, "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", "../../img/products/product19.png", 23.0, 100, "Boots" },
                    { 20, "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", "../../img/products/product20.png", 24.0, 100, "Boots" },
                    { 21, "Angular", "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.", "Angular Blue Boots", "../../img/products/product21.png", 19.989999999999998, 100, "Boots" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-ang1.png", 20000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-ang2.png", 15000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-core1.png", 18000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-core2.png", 30000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-react1.png", 25000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/sb-ts1.png", 12000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/hat-core1.png", 1000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/hat-react1.png", 8000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/hat-react2.png", 1500L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/glove-code1.png", 1800L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/glove-code2.png", 1500L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/glove-react1.png", 1600L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/glove-react2.png", 1400L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/boot-redis1.png", 25000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/boot-core2.png", 18999L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/boot-core1.png", 19999L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/boot-ang2.png", 15000L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PictureUrl", "Price" },
                values: new object[] { "/images/products/boot-ang1.png", 18000L });
        }
    }
}
