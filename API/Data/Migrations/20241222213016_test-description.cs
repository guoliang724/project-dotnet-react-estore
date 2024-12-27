using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class testdescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "<p>\r\n                Elevate your bathroom or spa experience with our\r\n                <strong>luxuriously soft white rolled towels</strong>. Made from\r\n                premium-quality cotton, these towels are ultra-absorbent,\r\n                durable, and gentle on the skin, making them perfect for\r\n                everyday use or special occasions. Each towel is elegantly\r\n                rolled and displayed on a stylish macrame swing, showcasing a\r\n                clean, minimalist aesthetic that blends effortlessly into any\r\n                décor. Whether you're upgrading your bathroom essentials or\r\n                looking for a thoughtful gift, these towels combine practicality\r\n                with timeless sophistication.\r\n              </p>\r\n              <ul className='list-disc list-inside'>\r\n                <li>\r\n                  <strong>Material</strong>: 100% Premium Cotton\r\n                </li>\r\n                <li>\r\n                  <strong>Features</strong>: Highly absorbent, quick-drying, and\r\n                  soft to the touch\r\n                </li>\r\n                <li>\r\n                  <strong>Ideal For</strong>: Bathrooms, spas, or as decorative\r\n                  accents\r\n                </li>\r\n                <li>\r\n                  <strong>Care Instructions</strong>: Machine washable, tumble\r\n                  dry on low\r\n                </li>\r\n              </ul>\r\n              <p>\r\n                Bring a touch of elegance and comfort to your home with these\r\n                versatile and beautifully designed towels.\r\n              </p>", "Glass cleaner leaves streak-free shine, no residue left behind" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Glass cleaner leaves streak-free shine, no residue left behind.", "Blue Code Cloths" });
        }
    }
}
