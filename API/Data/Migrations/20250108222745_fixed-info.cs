using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedinfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "literalDescription",
                value: "Say goodbye to dirt and streaks with our premium Microfiber Cleaning Cloths. Designed to be gentle yet powerful, these cloths are perfect for cleaning all types of surfaces, from glass to wood and everything in between.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "literalDescription" },
                values: new object[] { "Natural wood polish restores shine without harmful chemicals", "Natural wood polish restores shine without harmful chemicals.Combining functionality and sustainability, this collection is perfect for a mindful, environmentally conscious lifestyle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Teapot with a sturdy handle and whimsical design");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Name", "literalDescription" },
                values: new object[] { "Natural wood polish restores shine without harmful chemicals.Combining functionality and sustainability, this collection is perfect for a mindful, environmentally conscious lifestyle", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.");
        }
    }
}
