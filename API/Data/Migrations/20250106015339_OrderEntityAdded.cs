using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class OrderEntityAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuyerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BuyerId = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_FullName = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_Address1 = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_Address2 = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_City = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_State = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_Zip = table.Column<string>(type: "TEXT", nullable: true),
                    ShippingAddress_Country = table.Column<string>(type: "TEXT", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Subtotal = table.Column<long>(type: "INTEGER", nullable: false),
                    DeliveryFee = table.Column<long>(type: "INTEGER", nullable: false),
                    OrderStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false),
                    DemoImages = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: true),
                    Address1 = table.Column<string>(type: "TEXT", nullable: true),
                    Address2 = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true),
                    Zip = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAddress_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ItemOrdered_ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    ItemOrdered_Name = table.Column<string>(type: "TEXT", nullable: true),
                    ItemOrdered_PictureUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    BasketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "DemoImages", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type" },
                values: new object[,]
                {
                    { 1, "Leon's Cleaning", "[\"https://blobstorage1114.blob.core.windows.net/images/product-1-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-5.webp\"]", "<div class='product-description'>\r\n  <h2>Biodegradable Dish Soap - Gentle on Hands</h2>\r\n  <p>\r\n    Keep your dishes sparkling clean while caring for the environment with our \r\n    <strong>Biodegradable Dish Soap</strong>. Made from \r\n    <em>natural ingredients</em>, this soap is tough on grease but gentle on your hands.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Eco-Friendly:</strong> Completely biodegradable, reducing environmental impact.</li>\r\n    <li><strong>Natural Formula:</strong> Made with plant-based ingredients for a safer clean.</li>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for sensitive hands with no harsh chemicals.</li>\r\n    <li><strong>Powerful Cleaning:</strong> Effectively cuts through grease and grime.</li>\r\n  </ul>\r\n  <p>\r\n    Choose a product that combines <strong>sustainability</strong> and <strong>effectiveness</strong>. \r\n    Make dishwashing a cleaner, greener experience today!\r\n  </p>\r\n</div>", "Biodegradable dish soap made from natural ingredients, gentle on hands.", "https://blobstorage1114.blob.core.windows.net/images/product1.jpg", 13.99, 13, "Bath" },
                    { 2, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-2-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-5.webp\"]", "<div class='product-description'>\r\n  <h2>Non-Toxic, Plant-Based Laundry Detergent for Sensitive Skin</h2>\r\n  <p>\r\n    Experience a gentle yet effective clean with our \r\n    <strong>Non-Toxic, Plant-Based Laundry Detergent</strong>. Specially formulated for those with \r\n    <em>sensitive skin</em>, this detergent is free from harsh chemicals and powered by natural ingredients.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for individuals with allergies or sensitivities.</li>\r\n    <li><strong>Plant-Based Formula:</strong> Made with eco-friendly, biodegradable ingredients.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harmful chemicals, ensuring a safe and clean wash.</li>\r\n    <li><strong>Fresh Clean:</strong> Effectively removes stains and odors while leaving your clothes soft.</li>\r\n  </ul>\r\n  <p>\r\n    Make the switch to a detergent that’s as kind to your skin as it is to the planet. \r\n    Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.\r\n  </p>\r\n</div>", "Non-toxic, plant-based laundry detergent for sensitive skin", "https://blobstorage1114.blob.core.windows.net/images/product2.jpg", 29.989999999999998, 12, "Bath" },
                    { 3, "eSayClean", null, "Microfiber cleaning cloths, reusable and effective on all surfaces.", "Microfiber cleaning cloths", "imgs/products/product3.jpg", 18.989999999999998, 18, "Cloths" },
                    { 4, "eSayClean", null, "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.", "Net Core Super cleaner", "imgs/products/product4.jpg", 14.99, 19, "Cleaner" },
                    { 5, "eSayClean", null, "Natural wood polish restores shine without harmful chemicals.", "Natural wood", "imgs/products/product5.jpg", 15.0, 14, "Bath" },
                    { 6, "eSayClean", null, "Essential oil-infused room sprays for a fresh, natural scent.", "Typescript Entry sprays", "imgs/products/product6.jpg", 30.989999999999998, 12, "Cleaner" },
                    { 7, "eSayClean", null, "Antibacterial hand sanitizer with moisturizing aloe vera gel.", "Hand sanitizer", "imgs/products/product7.jpg", 41.0, 21, "Cleaner" },
                    { 8, "eSayClean", null, "Oxygen bleach alternative, safe for colors and the environment.", "Green eSayClean Woolen bleach", "imgs/products/product8.jpg", 23.0, 32, "Cleaner" },
                    { 9, "eSayClean", null, "Citrus degreaser cuts through tough grease without harsh fumes.", "Citrus degreaser", "imgs/products/product9.jpg", 13.0, 10, "Cloths" },
                    { 10, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/5.webp\"]", "<p>\r\n                Elevate your bathroom or spa experience with our\r\n                <strong>luxuriously soft white rolled towels</strong>. Made from\r\n                premium-quality cotton, these towels are ultra-absorbent,\r\n                durable, and gentle on the skin, making them perfect for\r\n                everyday use or special occasions. Each towel is elegantly\r\n                rolled and displayed on a stylish macrame swing, showcasing a\r\n                clean, minimalist aesthetic that blends effortlessly into any\r\n                décor. Whether you're upgrading your bathroom essentials or\r\n                looking for a thoughtful gift, these towels combine practicality\r\n                with timeless sophistication.\r\n              </p>\r\n              <ul className='list-disc list-inside'>\r\n                <li>\r\n                  <strong>Material</strong>: 100% Premium Cotton\r\n                </li>\r\n                <li>\r\n                  <strong>Features</strong>: Highly absorbent, quick-drying, and\r\n                  soft to the touch\r\n                </li>\r\n                <li>\r\n                  <strong>Ideal For</strong>: Bathrooms, spas, or as decorative\r\n                  accents\r\n                </li>\r\n                <li>\r\n                  <strong>Care Instructions</strong>: Machine washable, tumble\r\n                  dry on low\r\n                </li>\r\n              </ul>\r\n              <p>\r\n                Bring a touch of elegance and comfort to your home with these\r\n                versatile and beautifully designed towels.\r\n              </p>", "Glass cleaner leaves streak-free shine, no residue left behind", "https://blobstorage1114.blob.core.windows.net/images/product10.webp", 19.989999999999998, 10, "Cloths" },
                    { 11, "eSayClean", null, "Carpet shampooer with stain remover for deep cleaning carpets.", "Green Code Cloths", "imgs/products/product11.jpg", 15.99, 100, "Cloths" },
                    { 12, "eSayClean", null, "Enzyme-based drain cleaner safely breaks down organic matter.", "Enzyme-based drain cleaner", "imgs/products/product12.jpg", 19.989999999999998, 12, "Cloths" },
                    { 13, "eSayClean", null, "Mineral-based toilet bowl cleaner, effective and environmentally friendly.", "Mineral-based toilet bowl cleaner", "imgs/products/product13.jpg", 18.989999999999998, 100, "Cleaner" },
                    { 14, "eSayClean", null, "Odor eliminator uses activated charcoal to absorb bad smells.", "eSayClean Red Cloths", "imgs/products/product14.jpg", 29.989999999999998, 32, "Cloths" },
                    { 15, "eSayClean", null, "Vinegar-free fabric softener, keeps clothes soft and fresh.", "Vinegar-free fabric softener", "imgs/products/product15.jpg", 34.0, 12, "Cleaner" },
                    { 16, "eSayClean", null, "Eco-friendly car wash solution, biodegradable and non-toxic.", "Car wash solution", "imgs/products/product16.jpg", 43.0, 100, "Bath" },
                    { 17, "eSayClean", null, "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.", "Stainless steel polish cleaner", "imgs/products/product17.jpg", 13.0, 32, "Cleaner" },
                    { 18, "eSayClean", null, "Air purifying plants that improve indoor air quality naturally.", "Air purifying plants", "imgs/products/product18.jpg", 22.0, 22, "Bath" },
                    { 19, "eSayClean", null, "Long-handled back brush for easy reach and exfoliation.", "Long-handled back brush", "imgs/products/product19.jpg", 23.0, 11, "Bath" },
                    { 20, "eSayClean", null, "Calligraphy brush with flexible bristles for expressive writing.", "eSayClean Blue Cloths", "imgs/products/product20.jpg", 24.0, 23, "Bath" },
                    { 21, "eSayClean", null, "Bottle brush cleans hard-to-reach areas of containers.", "Pet grooming brush", "imgs/products/product21.jpg", 19.989999999999998, 21, "Bath" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "UserAddress");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
