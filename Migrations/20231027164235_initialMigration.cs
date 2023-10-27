using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComboItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ComboId = table.Column<Guid>(type: "uuid", nullable: false),
                    ItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComboItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Discount = table.Column<float>(type: "real", nullable: false),
                    BurgerId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ShortHand = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    IdentityUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_OrderTypes_OrderTypeId",
                        column: x => x.OrderTypeId,
                        principalTable: "OrderTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_UserProfiles_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_UserProfiles_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Burgers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Burgers_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDrinks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DrinkId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDrinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDrinks_Drinks_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDrinks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderSides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SideId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ComboItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSides_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderSides_Sides_SideId",
                        column: x => x.SideId,
                        principalTable: "Sides",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BurgerToppings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BurgerId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToppingId = table.Column<Guid>(type: "uuid", nullable: false),
                    Extra = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BurgerToppings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BurgerToppings_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burgers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BurgerToppings_Toppings_ToppingId",
                        column: x => x.ToppingId,
                        principalTable: "Toppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76f3405d-c548-4d39-8df5-5fd105406eaf", null, "Employee", "employee" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "adfbdde0-4137-4da0-a236-940faca4bbf0", 0, "9f939765-72ee-472c-a530-dc6d89dd3a60", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDeBs0VYHb6pXMB95/K4xEffRFgQAXnvIrCi050U3rZpIfnONHG+MLTrNhc8wAf1+g==", null, false, "0b42ed69-8dc9-4cd7-b9d1-ba7a1e26cb6b", false, "ekrabs" },
                    { "b06e00ba-4ca2-467e-9dab-0cc033063a8e", 0, "3ef0eec0-fcf0-47f9-ae8a-5acb389a1d5a", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEGUGk35h8rYEHkuxHbkN+lQeCnAMaNOJ3ZIJ6Litznv2DJlLaBSpPXGLyjNKxSjNdA==", null, false, "c88b737e-46b0-402d-9a4b-a979b50cf764", false, "pstar" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "65ab3a02-2cc4-4791-8c13-0f0162c9764c", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAEAkRP4XHi4knBHgNS10YpjPQeWgeHqQwtfEUX8MHLeMvkHm6WZsumu4M/gAsKCEHxA==", null, false, "904bbfb2-9b00-434a-9c3f-b37eee6a81c1", false, "Administrator" },
                    { "f45c916f-1254-4845-8c6f-aa2a8c73fab9", 0, "5c055536-8787-4f13-9dcd-17acaa2acd7a", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEOlEecGwv7Pcx3USDFtVY+jLr8hCsxzCoDgYAMKg2u5cYqVSUAwWBk5pzvJ2lrPnQg==", null, false, "2c9118dd-716c-4a66-a4d9-9ef08ca250de", false, "ssquarepants" },
                    { "fda0ed28-b9ca-40e6-9037-eba5832459b9", 0, "59759cd5-18e7-4c58-8fab-b6cf76e8dc30", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAELHDwJEu4B7zKY2YaPurq3Pf/UEJms6gTMSOXMhpV/PjMKyCtplCn5++pYv3mHKZrw==", null, false, "73dc81cb-a4c6-4320-ac0f-4234c59972c3", false, "stentacles" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, "double krabby patty", null, 1 },
                    { new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, "krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("6f433746-1e6f-4b8a-89ef-12a5b42bed3c"), new Guid("002ea8cf-c0cb-4df9-a01a-4f8643355a32"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb") },
                    { new Guid("7bf1755e-0b70-4533-9bec-c61647a5f54c"), new Guid("002ea8cf-c0cb-4df9-a01a-4f8643355a32"), new Guid("034c2400-e07a-4642-8147-e1a4f5f27333"), new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb") },
                    { new Guid("ad2c73b8-06e4-4bda-b506-3a01dc5d818b"), new Guid("002ea8cf-c0cb-4df9-a01a-4f8643355a32"), new Guid("2fa7d04c-3cb8-4e80-844f-f7c3e870be9a"), new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("002ea8cf-c0cb-4df9-a01a-4f8643355a32"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), -1.25f, false, "double krabby patty combo" },
                    { new Guid("e44b6e20-493b-4f8f-86bb-dccc29a4f3fe"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), -1f, false, "krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("00856106-03e6-4b79-928b-adc13311f92c"), false, "dr. kelp", 1f },
                    { new Guid("4dfe9945-5b5c-4ac3-a693-3391d888dfed"), false, "diet dr. kelp", 1f },
                    { new Guid("9ccf65fe-6216-4570-9889-e6661e3334a4"), false, "water", 0.1f },
                    { new Guid("a728417d-4b6f-4b11-b0e6-cf3e4c7f9b0c"), false, "kelp shake", 1.5f },
                    { new Guid("d28b90a8-fe7c-463d-9ddb-7af68864ff45"), false, "red tide", 1f },
                    { new Guid("e03f0e6b-699c-4452-a3bf-a23f528cec7c"), false, "seafoam soda", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a9b9b55-22c0-44b8-83cd-cf06a16982c0"), "pickup" },
                    { new Guid("8b9196b0-3cf7-45ae-95ec-cc369c34464b"), "togo" },
                    { new Guid("c43dac35-214d-45ab-9777-237818dfbbcf"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("18614fbd-91ce-4329-80dc-754fabe4bf4f"), false, "kelp fries", 1.25f },
                    { new Guid("2727c75e-92b9-4e97-a576-e0957fbd2c5f"), false, "seaweed salad", 2f },
                    { new Guid("4ccd58b2-57de-47af-98ef-da75a315ab78"), false, "coral bits", 1.25f },
                    { new Guid("b59f5921-fb41-4c89-beae-340473a25990"), false, "oyster skins", 1.25f },
                    { new Guid("e9e89f13-e3d3-4bfd-ab1d-a6b7dd6bdc0e"), false, "barnacle rings", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("24428db6-9d06-45f3-a02f-3eb06cf63669"), "small", 0f, "sm" },
                    { new Guid("373462c5-f90b-4125-9a59-efc3692b1d7a"), "medium", 0.2f, "md" },
                    { new Guid("cc92aca0-fe16-4b18-88a0-6c798a508469"), "large", 0.45f, "lg" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("19d53262-c2ba-4c5b-80f6-2cb0c70f468c"), false, "onion", 0.05f },
                    { new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299"), false, "patty", 1f },
                    { new Guid("292c221d-94f4-4bb5-843c-dbf66a2d10f3"), false, "pickle", 0.05f },
                    { new Guid("3835b77e-d016-48e3-8f68-d0e9ab5f8739"), false, "ketchup", 0f },
                    { new Guid("3cdcab2b-8e87-473a-8d79-cbaf65010e77"), false, "lettuce", 0.05f },
                    { new Guid("47605247-b3c4-445a-a62c-cc08f938c1a4"), false, "secret sauce", 0f },
                    { new Guid("51bae8ec-0e4c-4e62-aa73-8ea1248139c4"), false, "tomato", 0.05f },
                    { new Guid("62a34a87-60ce-443c-90f5-108dbe4e2dd7"), false, "sea cheese", 0.25f },
                    { new Guid("a7527fc4-86d7-4730-a97a-18b8b554a77e"), false, "bun", 0.2f },
                    { new Guid("ce3dcf04-d1d7-4152-876a-e96782569b08"), false, "mustard", 0f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "adfbdde0-4137-4da0-a236-940faca4bbf0" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" },
                    { "76f3405d-c548-4d39-8df5-5fd105406eaf", "f45c916f-1254-4845-8c6f-aa2a8c73fab9" },
                    { "76f3405d-c548-4d39-8df5-5fd105406eaf", "fda0ed28-b9ca-40e6-9037-eba5832459b9" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0bcbedd2-99f8-4b08-86f0-90edce6dbd52"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("47605247-b3c4-445a-a62c-cc08f938c1a4") },
                    { new Guid("0e57fc9b-19e5-4ab3-acab-ee0c58ad4628"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("ce3dcf04-d1d7-4152-876a-e96782569b08") },
                    { new Guid("1894f331-49e3-48d7-b4a3-5ef8897ab56b"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("292c221d-94f4-4bb5-843c-dbf66a2d10f3") },
                    { new Guid("1f57633c-9243-4d66-a37f-6828cb823bf4"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299") },
                    { new Guid("29058c1a-53bb-4c64-9b85-ebffe72c3cbd"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("a7527fc4-86d7-4730-a97a-18b8b554a77e") },
                    { new Guid("33047f9a-e740-4fc0-81cf-84d2d0afd4c5"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("47605247-b3c4-445a-a62c-cc08f938c1a4") },
                    { new Guid("45e23aa5-d296-442a-8344-375b5802ae45"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("3835b77e-d016-48e3-8f68-d0e9ab5f8739") },
                    { new Guid("59f79e4d-441c-4e5f-a7d0-65b22957fc03"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("3cdcab2b-8e87-473a-8d79-cbaf65010e77") },
                    { new Guid("6dae9d4d-ec46-458b-a67f-7fb1f285c54b"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299") },
                    { new Guid("920c3d25-0710-4cbe-be30-0cff1e7b49d7"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("19d53262-c2ba-4c5b-80f6-2cb0c70f468c") },
                    { new Guid("9294fc26-9698-47c9-82dd-0ece19c7c37e"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("a7527fc4-86d7-4730-a97a-18b8b554a77e") },
                    { new Guid("92aff036-6066-48e7-bc44-b5f06462a60a"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("3835b77e-d016-48e3-8f68-d0e9ab5f8739") },
                    { new Guid("a02ca4f5-f98a-4c5e-8b2c-f053c74983cf"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("292c221d-94f4-4bb5-843c-dbf66a2d10f3") },
                    { new Guid("a739380c-0887-4a5a-835f-f390457408b5"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("3cdcab2b-8e87-473a-8d79-cbaf65010e77") },
                    { new Guid("b6ce29c1-6ac6-4ffe-8841-0fc4216987e5"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("ce3dcf04-d1d7-4152-876a-e96782569b08") },
                    { new Guid("c1031eba-a255-47bd-9a4c-b76f7b65dc10"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("19d53262-c2ba-4c5b-80f6-2cb0c70f468c") },
                    { new Guid("c42bc2c5-6155-47ac-8f55-48100b1cd383"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299") },
                    { new Guid("d0374f34-2ff3-43bd-8821-7fb3faabc2ff"), new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"), false, new Guid("51bae8ec-0e4c-4e62-aa73-8ea1248139c4") },
                    { new Guid("ecf72ae4-79f0-450c-b3ce-cfe2c201455b"), new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"), false, new Guid("51bae8ec-0e4c-4e62-aa73-8ea1248139c4") }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("12c557a5-c321-4131-b0bd-b1520b68655b"), "120 Conch Street", "Patrick", "b06e00ba-4ca2-467e-9dab-0cc033063a8e", "Star" },
                    { new Guid("23170bda-5e4e-4183-a1c3-1cf6ac1d9059"), "122 Conch Street", "Squidward", "fda0ed28-b9ca-40e6-9037-eba5832459b9", "Tentacles" },
                    { new Guid("b78f00c3-e837-48dc-a1ed-db755bcf5263"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" },
                    { new Guid("fe06653f-cbde-456e-a447-aa6f1480d219"), "3541 Anchor Way", "Eugene", "adfbdde0-4137-4da0-a236-940faca4bbf0", "Krabs" },
                    { new Guid("ff1c6961-8579-49a0-ba4f-14944976a561"), "124 Conch Street", "SpongeBob", "f45c916f-1254-4845-8c6f-aa2a8c73fab9", "SquarePants" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb"), new Guid("12c557a5-c321-4131-b0bd-b1520b68655b"), new Guid("23170bda-5e4e-4183-a1c3-1cf6ac1d9059"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c43dac35-214d-45ab-9777-237818dfbbcf") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, null, new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("034c2400-e07a-4642-8147-e1a4f5f27333"), new Guid("d28b90a8-fe7c-463d-9ddb-7af68864ff45"), new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb"), 1, new Guid("373462c5-f90b-4125-9a59-efc3692b1d7a") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("2fa7d04c-3cb8-4e80-844f-f7c3e870be9a"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb"), 1, new Guid("4ccd58b2-57de-47af-98ef-da75a315ab78"), new Guid("cc92aca0-fe16-4b18-88a0-6c798a508469") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("08a85525-16ad-4c58-841a-f758dff3f1d6"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("51bae8ec-0e4c-4e62-aa73-8ea1248139c4") },
                    { new Guid("63b68222-9bb5-4769-adc0-e30c1ae2c77c"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("292c221d-94f4-4bb5-843c-dbf66a2d10f3") },
                    { new Guid("67422b0c-11b2-4283-8181-6293e42f578b"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("47605247-b3c4-445a-a62c-cc08f938c1a4") },
                    { new Guid("6fc7712a-210a-4635-b1e5-0b2c5e249dfe"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("ce3dcf04-d1d7-4152-876a-e96782569b08") },
                    { new Guid("8c28630d-5b27-4c93-b12f-ae30562c45c8"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("19d53262-c2ba-4c5b-80f6-2cb0c70f468c") },
                    { new Guid("cbf27de8-9c74-481d-81f3-6f71796e3fd1"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("3835b77e-d016-48e3-8f68-d0e9ab5f8739") },
                    { new Guid("cd8008d6-4d57-47b4-9391-c5b366e487f9"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299") },
                    { new Guid("d19085b0-175a-4179-b327-503f0e18af0f"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("3cdcab2b-8e87-473a-8d79-cbaf65010e77") },
                    { new Guid("ed645e77-bc25-45e9-b429-a93c7f9d29e6"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299") },
                    { new Guid("f8ebaeb0-bf22-4efb-8479-fa857a7eb4e9"), new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"), false, new Guid("a7527fc4-86d7-4730-a97a-18b8b554a77e") }
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
                name: "IX_Burgers_OrderId",
                table: "Burgers",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerToppings_BurgerId",
                table: "BurgerToppings",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_BurgerToppings_ToppingId",
                table: "BurgerToppings",
                column: "ToppingId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_DrinkId",
                table: "OrderDrinks",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_OrderId",
                table: "OrderDrinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSides_OrderId",
                table: "OrderSides",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSides_SideId",
                table: "OrderSides",
                column: "SideId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_IdentityUserId",
                table: "UserProfiles",
                column: "IdentityUserId");
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
                name: "BurgerToppings");

            migrationBuilder.DropTable(
                name: "ComboItems");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "OrderDrinks");

            migrationBuilder.DropTable(
                name: "OrderSides");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderTypes");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
