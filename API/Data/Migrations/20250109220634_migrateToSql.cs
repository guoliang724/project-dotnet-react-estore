using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.migrations
{
    /// <inheritdoc />
    public partial class migrateToSql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuyerId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentIntentId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClientSecret = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BuyerId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_Address1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_Address2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_Zip = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingAddress_Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Subtotal = table.Column<double>(type: "double", nullable: false),
                    DeliveryFee = table.Column<long>(type: "bigint", nullable: false),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentIntentId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    PictureUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantityInStock = table.Column<int>(type: "int", nullable: false),
                    DemoImages = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    literalDescription = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Zip = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ItemOrdered_ProductId = table.Column<int>(type: "int", nullable: true),
                    ItemOrdered_Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ItemOrdered_PictureUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<double>(type: "double", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                columns: new[] { "Id", "Brand", "DemoImages", "Description", "Name", "PictureUrl", "Price", "QuantityInStock", "Type", "literalDescription" },
                values: new object[,]
                {
                    { 1, "Leon's Cleaning", "[\"https://blobstorage1114.blob.core.windows.net/images/product-1-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-1-5.webp\"]", "<div class='product-description'>\r\n  <h2>Biodegradable Dish Soap - Gentle on Hands</h2>\r\n  <p>\r\n    Keep your dishes sparkling clean while caring for the environment with our \r\n    <strong>Biodegradable Dish Soap</strong>. Made from \r\n    <em>natural ingredients</em>, this soap is tough on grease but gentle on your hands.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Eco-Friendly:</strong> Completely biodegradable, reducing environmental impact.</li>\r\n    <li><strong>Natural Formula:</strong> Made with plant-based ingredients for a safer clean.</li>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for sensitive hands with no harsh chemicals.</li>\r\n    <li><strong>Powerful Cleaning:</strong> Effectively cuts through grease and grime.</li>\r\n  </ul>\r\n  <p>\r\n    Choose a product that combines <strong>sustainability</strong> and <strong>effectiveness</strong>. \r\n    Make dishwashing a cleaner, greener experience today!\r\n  </p>\r\n</div>", "Biodegradable dish.", "https://blobstorage1114.blob.core.windows.net/images/product1.jpg", 13.99, 13, "Bath", "Biodegradable dish soap made from natural ingredients, gentle on hands." },
                    { 2, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-2-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-2-5.webp\"]", "<div class='product-description'>\r\n  <h2>Non-Toxic, Plant-Based Laundry Detergent for Sensitive Skin</h2>\r\n  <p>\r\n    Experience a gentle yet effective clean with our \r\n    <strong>Non-Toxic, Plant-Based Laundry Detergent</strong>. Specially formulated for those with \r\n    <em>sensitive skin</em>, this detergent is free from harsh chemicals and powered by natural ingredients.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Gentle on Skin:</strong> Perfect for individuals with allergies or sensitivities.</li>\r\n    <li><strong>Plant-Based Formula:</strong> Made with eco-friendly, biodegradable ingredients.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harmful chemicals, ensuring a safe and clean wash.</li>\r\n    <li><strong>Fresh Clean:</strong> Effectively removes stains and odors while leaving your clothes soft.</li>\r\n  </ul>\r\n  <p>\r\n    Make the switch to a detergent that’s as kind to your skin as it is to the planet. \r\n    Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry.\r\n  </p>\r\n</div>", "Non-toxic, plant-based laundry detergent for sensitive skin", "https://blobstorage1114.blob.core.windows.net/images/product2.jpg", 29.989999999999998, 12, "Bath", "Make the switch to a detergent that’s as kind to your skin as it is to the planet. Try our plant-powered solution today and embrace a healthier, more sustainable way to do laundry." },
                    { 3, "Timerland", "[\"https://blobstorage1114.blob.core.windows.net/images/product-3-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-3-4.webp\"]", "<div class='product-description'>\r\n  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>\r\n  <p>\r\n    Say goodbye to dirt and streaks with our premium \r\n    <strong>Microfiber Cleaning Cloths</strong>. Designed to be \r\n    <em>gentle yet powerful</em>, these cloths are perfect for cleaning \r\n    <strong>all types of surfaces</strong>, from glass to wood and everything in between.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>\r\n    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>\r\n    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>\r\n    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>\r\n  </ul>\r\n  <p>\r\n    Upgrade your cleaning routine with these versatile and environmentally-friendly \r\n    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are \r\n    the ultimate cleaning companion.\r\n  </p>\r\n</div>", "Microfiber cleaning cloths, reusable and effective on all surfaces.", "https://blobstorage1114.blob.core.windows.net/images/product3.webp", 18.989999999999998, 18, "Cloths", "Say goodbye to dirt and streaks with our premium Microfiber Cleaning Cloths. Designed to be gentle yet powerful, these cloths are perfect for cleaning all types of surfaces, from glass to wood and everything in between." },
                    { 4, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-4-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-4-4.webp\"]", "<div class='product-description'>\r\n  <h2>Microfiber Cleaning Cloths - Reusable and Effective</h2>\r\n  <p>\r\n    Say goodbye to dirt and streaks with our premium \r\n    <strong>Microfiber Cleaning Cloths</strong>. Designed to be \r\n    <em>gentle yet powerful</em>, these cloths are perfect for cleaning \r\n    <strong>all types of surfaces</strong>, from glass to wood and everything in between.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Reusable and Durable:</strong> Built to last, these cloths can be washed and reused, reducing waste.</li>\r\n    <li><strong>Effective on All Surfaces:</strong> Safely cleans glass, mirrors, countertops, stainless steel, and more.</li>\r\n    <li><strong>Lint-Free and Scratch-Free:</strong> Leaves surfaces spotless without causing damage.</li>\r\n    <li><strong>Eco-Friendly Choice:</strong> A sustainable alternative to disposable cleaning supplies.</li>\r\n  </ul>\r\n  <p>\r\n    Upgrade your cleaning routine with these versatile and environmentally-friendly \r\n    <strong>microfiber cloths</strong>. Perfect for homes, offices, and cars, they are \r\n    the ultimate cleaning companion.\r\n  </p>\r\n</div>", "Concentrated all-purpose cleaner, eco-friendly and powerful against grime.", "https://blobstorage1114.blob.core.windows.net/images/product4.webp", 14.99, 19, "Cleaner", "Say goodbye to dirt and streaks with our premium Microfiber Cleaning Cloths. Designed to be gentle yet powerful, these cloths are perfect for cleaning all types of surfaces, from glass to wood and everything in between." },
                    { 5, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-5-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-5-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-5-3.webp\"]", "<div class='product-description'>\r\n  <h2>Natural and Sustainable Beauty Essentials</h2>\r\n  <p>\r\n    Transform your self-care routine with this thoughtfully curated set of \r\n    <strong>eco-friendly beauty essentials</strong>. Combining functionality \r\n    and sustainability, this collection is perfect for a mindful, \r\n    environmentally conscious lifestyle.\r\n  </p>\r\n  <ul>\r\n    <li><strong>Natural Wooden Body Brush:</strong> Features soft, natural bristles for gentle exfoliation and improved circulation.</li>\r\n    <li><strong>Powdered Skincare:</strong> A jar of gentle exfoliating powder to refresh and rejuvenate your skin.</li>\r\n    <li><strong>Reusable Cotton Pads:</strong> Soft and durable, ideal for makeup removal and reducing waste.</li>\r\n    <li><strong>Handcrafted Soap Bar:</strong> Made with natural ingredients, perfect for a luxurious cleanse.</li>\r\n    <li><strong>Textured Fabric Pouch:</strong> A stylish and practical addition for storing your beauty essentials.</li>\r\n  </ul>\r\n  <p>\r\n    Embrace a <strong>minimalistic aesthetic</strong> while caring for the planet. \r\n    This set is designed to elevate your skincare experience, bringing together \r\n    beauty, sustainability, and simplicity in one luxurious package.\r\n  </p>\r\n</div>", "Natural wood polish restores shine without harmful chemicals", "https://blobstorage1114.blob.core.windows.net/images/product5.webp", 15.0, 14, "Bath", "Natural wood polish restores shine without harmful chemicals.Combining functionality and sustainability, this collection is perfect for a mindful, environmentally conscious lifestyle" },
                    { 6, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-6-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-6-3.webp\"]", "<div class='product-description'>\r\n  <h1>Whimsical Cat-Themed Ceramic Tea Set</h1>\r\n  <p>\r\n    Add a touch of charm to your tea time with this delightful <strong>cat-themed ceramic tea set</strong>. Featuring playful cat illustrations with vibrant umbrellas, this set is both functional and a beautiful piece of art. Perfect for cat lovers and tea enthusiasts alike!\r\n  </p>\r\n  <p><strong>What's Included:</strong></p>\r\n  <ul>\r\n    <li>1 Teapot with a sturdy handle and whimsical design</li>\r\n    <li>Matching teacups with playful cat and umbrella illustrations</li>\r\n    <li>Beautifully crafted saucers to complete the set</li>\r\n  </ul>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>High-Quality Ceramic:</strong> Durable, heat-resistant material for long-lasting use.</li>\r\n    <li><strong>Adorable Design:</strong> Colorful and playful cat illustrations with umbrella accents.</li>\r\n    <li><strong>Perfect for Any Occasion:</strong> Ideal for tea parties, casual use, or as a unique gift.</li>\r\n    <li><strong>Easy to Clean:</strong> Smooth surface makes cleaning a breeze.</li>\r\n  </ul>\r\n  <p><strong>Specifications:</strong></p>\r\n  <ul>\r\n    <li>Material: High-quality ceramic</li>\r\n    <li>Teapot Capacity: 1.2 liters</li>\r\n    <li>Number of Cups: 6 matching teacups</li>\r\n    <li>Design: Playful cats with colorful umbrellas</li>\r\n  </ul>\r\n  <p>\r\n    This tea set combines practicality with a whimsical design that will delight anyone who sees it. Whether you're hosting guests or enjoying a quiet tea moment, this set will bring joy and style to your experience.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.8/5) - 'Such a cute tea set! The cat designs are adorable, and the quality is excellent.'\r\n  </p>\r\n</div>", "Teapot with a sturdy handle and whimsical design", "https://blobstorage1114.blob.core.windows.net/images/product6.webp", 30.989999999999998, 12, "Cleaner", "Combining effective antibacterial action with the nourishing benefits of aloe vera, this hand sanitizer is a must-have for maintaining hygiene without compromising on skin care. Ideal for everyday use and suitable for all skin types." },
                    { 7, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/product-7-1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/product-7-5.webp\"]", "<div class='product-description'>\r\n  <h1>Antibacterial Hand Sanitizer with Moisturizing Aloe Vera Gel</h1>\r\n  <p>\r\n    Keep your hands clean and germ-free with our <strong>antibacterial hand sanitizer</strong>. Infused with <em>moisturizing aloe vera gel</em>, it provides effective protection while keeping your skin soft and hydrated.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Powerful Germ Protection:</strong> Eliminates 99.9% of bacteria and viruses.</li>\r\n    <li><strong>Moisturizing Formula:</strong> Enriched with aloe vera to prevent dryness and irritation.</li>\r\n    <li><strong>Quick Absorption:</strong> Non-sticky, fast-drying formula for hassle-free use.</li>\r\n    <li><strong>Portable and Convenient:</strong> Ideal for use at home, work, or on the go.</li>\r\n  </ul>\r\n  <p>\r\n    This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★☆ (4.5/5) - 'Keeps my hands feeling fresh and moisturized. Love the aloe vera scent!'\r\n  </p>\r\n</div>", "Antibacterial hand sanitizer", "https://blobstorage1114.blob.core.windows.net/images/product7.webp", 41.0, 21, "Cleaner", "This hand sanitizer combines superior germ-fighting power with the soothing benefits of aloe vera, making it perfect for daily use. It's an essential addition to your hygiene routine, ensuring cleanliness without compromising on skin care." },
                    { 8, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Green eSayClean Woolen bleach", "https://blobstorage1114.blob.core.windows.net/images/product8.webp", 23.0, 32, "Cleaner", "Oxygen bleach alternative, safe for colors and the environment." },
                    { 9, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Citrus degreaser", "https://blobstorage1114.blob.core.windows.net/images/product9.webp", 13.0, 10, "Cloths", "Citrus degreaser cuts through tough grease without harsh fumes." },
                    { 10, "eSayClean", "[\"https://blobstorage1114.blob.core.windows.net/images/1.webp\",\"https://blobstorage1114.blob.core.windows.net/images/2.webp\",\"https://blobstorage1114.blob.core.windows.net/images/3.webp\",\"https://blobstorage1114.blob.core.windows.net/images/4.webp\",\"https://blobstorage1114.blob.core.windows.net/images/5.webp\"]", "<p>\r\n                Elevate your bathroom or spa experience with our\r\n                <strong>luxuriously soft white rolled towels</strong>. Made from\r\n                premium-quality cotton, these towels are ultra-absorbent,\r\n                durable, and gentle on the skin, making them perfect for\r\n                everyday use or special occasions. Each towel is elegantly\r\n                rolled and displayed on a stylish macrame swing, showcasing a\r\n                clean, minimalist aesthetic that blends effortlessly into any\r\n                décor. Whether you're upgrading your bathroom essentials or\r\n                looking for a thoughtful gift, these towels combine practicality\r\n                with timeless sophistication.\r\n              </p>\r\n              <ul className='list-disc list-inside'>\r\n                <li>\r\n                  <strong>Material</strong>: 100% Premium Cotton\r\n                </li>\r\n                <li>\r\n                  <strong>Features</strong>: Highly absorbent, quick-drying, and\r\n                  soft to the touch\r\n                </li>\r\n                <li>\r\n                  <strong>Ideal For</strong>: Bathrooms, spas, or as decorative\r\n                  accents\r\n                </li>\r\n                <li>\r\n                  <strong>Care Instructions</strong>: Machine washable, tumble\r\n                  dry on low\r\n                </li>\r\n              </ul>\r\n              <p>\r\n                Bring a touch of elegance and comfort to your home with these\r\n                versatile and beautifully designed towels.\r\n              </p>", "Glass cleaner leaves streak-free shine, no residue left behind", "https://blobstorage1114.blob.core.windows.net/images/product10.webp", 19.989999999999998, 10, "Cloths", "Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment." },
                    { 11, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Green Code Cloths", "https://blobstorage1114.blob.core.windows.net/images/product11.webp", 15.99, 100, "Cloths", "Carpet shampooer with stain remover for deep cleaning carpets." },
                    { 12, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Enzyme-based drain cleaner", "https://blobstorage1114.blob.core.windows.net/images/product12.webp", 19.989999999999998, 12, "Cloths", "Enzyme-based drain cleaner safely breaks down organic matter." },
                    { 13, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Mineral-based toilet bowl cleaner", "https://blobstorage1114.blob.core.windows.net/images/product13.webp", 18.989999999999998, 100, "Cleaner", "Mineral-based toilet bowl cleaner, effective and environmentally friendly." },
                    { 14, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "eSayClean Red Cloths", "https://blobstorage1114.blob.core.windows.net/images/product14.webp", 29.989999999999998, 32, "Cloths", "Odor eliminator uses activated charcoal to absorb bad smells." },
                    { 15, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Vinegar-free fabric softener", "https://blobstorage1114.blob.core.windows.net/images/product15.webp", 34.0, 12, "Cleaner", "Vinegar-free fabric softener, keeps clothes soft and fresh." },
                    { 16, "eSayClean", null, "<div class='product-description'>\r\n  <h1>Oxygen Bleach Alternative - Safe for Colors and the Environment</h1>\r\n  <p>\r\n    Discover a powerful and eco-friendly solution for your laundry needs with our <strong>oxygen bleach alternative</strong>. This versatile product is designed to brighten whites, clean tough stains, and maintain the vibrancy of your colored fabrics, all while being gentle on the environment.\r\n  </p>\r\n  <p><strong>Key Features:</strong></p>\r\n  <ul>\r\n    <li><strong>Safe for Colors:</strong> Protects the vibrancy of colored fabrics while effectively removing stains.</li>\r\n    <li><strong>Environmentally Friendly:</strong> Biodegradable formula that is safe for the planet.</li>\r\n    <li><strong>Versatile Use:</strong> Ideal for laundry, cleaning surfaces, and more.</li>\r\n    <li><strong>Non-Toxic:</strong> Free from harsh chemicals and chlorine.</li>\r\n  </ul>\r\n  <p>\r\n    This oxygen bleach alternative is perfect for those who want a cleaner, greener home. It offers powerful cleaning without the use of harsh chemicals, making it a safe choice for your family and the environment.\r\n  </p>\r\n  <p><strong>Customer Reviews:</strong></p>\r\n  <p>\r\n    ★★★★★ (4.7/5) - 'Works wonderfully on my laundry and is safe for all my colored clothes. Highly recommend!'\r\n  </p>\r\n</div>", "Car wash solution", "https://blobstorage1114.blob.core.windows.net/images/product16.webp", 43.0, 100, "Bath", "Eco-friendly car wash solution, biodegradable and non-toxic." }
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
