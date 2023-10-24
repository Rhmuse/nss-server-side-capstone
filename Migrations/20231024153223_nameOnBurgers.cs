using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class nameOnBurgers : Migration
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
                    BurgerId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    ShortHand = table.Column<string>(type: "text", nullable: false)
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
                    Price = table.Column<float>(type: "real", nullable: false)
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
                    Quantity = table.Column<int>(type: "integer", nullable: false)
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
                    ToppingId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" },
                    { "dc3b483f-72fc-4bee-a519-387151ccda89", null, "Employee", "employee" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02281be4-0d95-4711-99a8-0c64b640799b", 0, "452c8282-9173-4574-9dc6-5e2bae126137", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEI7rkYAq2A/pI522xDCj7p0/OejBMYPE6c6m9AmdmBeq9Zp0KlBpkExcdcUBIHbKjA==", null, false, "0443c1c0-2dfd-4022-aae8-9e08fcbbab37", false, "stentacles" },
                    { "099cbd77-4110-43f3-b771-3bd2dd976d5b", 0, "b6822f2c-aa86-4945-9430-945c6d1f2561", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAECvuTYSkBST7u3yx6c/r8o/zPQPjklrzwGK1dKigr8GRc77Fg7GKwdQvbc76riR6mQ==", null, false, "4b48d669-5419-4d8d-a876-9f3f0ab9fc0f", false, "ekrabs" },
                    { "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c", 0, "e550af3d-2a05-42c8-b4e6-91b3cf7caa14", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJJMVfH0B+FTz53kA7L1nxthZhw8C7/XR5KF1UDnDlzg/dpqZh4O5XGH7XL0EvcVBw==", null, false, "146c831e-34f4-402a-aad5-618f1537892f", false, "ssquarepants" },
                    { "c32c4039-3085-44f9-b190-eabc0db206b7", 0, "696bd78c-bfcc-48e0-88a9-0b7a77338401", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEM/loJoQPhZh4HBiyJX/DzOwGtgeyVBlpa0cpYvHjnvfme1bSzzLepGKXsPa0VZ9pg==", null, false, "2be63c57-cd7b-4b67-925a-31fe39a79a41", false, "pstar" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "f3bd03d8-0929-40ef-8122-d405c4563835", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAEJIM1Hgi5upDYkaXc4/z+AD07VZY26jCGLZMa0T3xtNaQAlSkhBMKN7H/HR5dhQB+g==", null, false, "401307f8-5813-4a7c-a0eb-dcfd786abff6", false, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), "krabby patty", null, 1 },
                    { new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), "double krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("1c108a9e-9b99-4fc0-9d12-2ad2ca395799"), new Guid("48945177-66b3-4da7-9226-2071ad78594b"), new Guid("178a0e8b-bc78-4daa-9976-8935353340b9"), new Guid("9c850bab-3dd6-4415-ab77-d2b880885303") },
                    { new Guid("9d97c034-61df-49ad-84fc-246f7e78890a"), new Guid("48945177-66b3-4da7-9226-2071ad78594b"), new Guid("40a5da61-4f56-4081-8bb7-41976b0a701d"), new Guid("9c850bab-3dd6-4415-ab77-d2b880885303") },
                    { new Guid("b961bbf0-403f-49f2-aaf3-98ea533289d9"), new Guid("48945177-66b3-4da7-9226-2071ad78594b"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("9c850bab-3dd6-4415-ab77-d2b880885303") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("008678d3-329a-41ed-8163-7c8437ee8939"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), -1f, "krabby patty combo" },
                    { new Guid("48945177-66b3-4da7-9226-2071ad78594b"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), -1.25f, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("116c2397-0358-440b-9c87-76090a8eecc1"), "dr. kelp", 1f },
                    { new Guid("44b9e5c2-8ff9-40fb-ac2f-9165f8795035"), "diet dr. kelp", 1f },
                    { new Guid("5c1dd2e5-156d-4196-9bc6-57e7c2d8e0b3"), "red tide", 1f },
                    { new Guid("cf7f64ad-79ea-4981-b46c-a29a71e8251f"), "kelp shake", 1.5f },
                    { new Guid("eb5317b2-636a-44dc-89d4-591e25d772af"), "water", 0.1f },
                    { new Guid("f04c3eb3-f135-4316-8d8f-2989c401d3c7"), "seafoam soda", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e6743ad-c9aa-413f-8416-24047564323c"), "pickup" },
                    { new Guid("99aea153-e778-4e43-9210-1125857287c9"), "here" },
                    { new Guid("fac82dfc-c5a1-4ae1-8b3c-b1e7d557dc5c"), "togo" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1e1642f0-346b-4f30-b886-a93a71fc7efd"), "coral bits", 1.25f },
                    { new Guid("49da624b-41c4-4f0c-8c4e-9b32f87c3d24"), "barnacle rings", 1.25f },
                    { new Guid("77aec8fc-d0ad-49aa-932f-2e04f8a5b4f5"), "kelp fries", 1.25f },
                    { new Guid("e0507091-6a54-440b-bd24-adf2e23f0e8a"), "seaweed salad", 2f },
                    { new Guid("e84bfef9-d6a7-4c33-b8ac-927eb3e5a44b"), "oyster skins", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("52e7feb2-ce4b-41ff-954b-bf1530547817"), "medium", "md" },
                    { new Guid("85359301-c9f5-4907-92d5-de759d7f91c7"), "small", "sm" },
                    { new Guid("919e5331-40e7-4db7-b9a6-7f7bfbda2188"), "large", "lg" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1507ca55-71b2-47d2-bf42-877b02c71718"), "secret sauce", 0f },
                    { new Guid("568cb4ec-53a4-4ac2-ae18-4d5b48c52289"), "sea cheese", 0.25f },
                    { new Guid("60725929-ae42-4838-8c7b-1976f79730f3"), "onion", 0.05f },
                    { new Guid("6feaa3bc-0cf8-4ac9-8238-7192ff1af5b3"), "lettuce", 0.05f },
                    { new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19"), "patty", 1f },
                    { new Guid("92ea16f4-7a90-4fd8-805a-a606c093063e"), "mustard", 0f },
                    { new Guid("a9b8334a-125b-4cb7-bac8-b325514a8223"), "pickle", 0.05f },
                    { new Guid("c28c19ab-eea1-45b7-b14d-a85adc37c6d2"), "ketchup", 0f },
                    { new Guid("cc4538a2-5b30-4421-a08d-a3e460fe6dd2"), "bun", 0.2f },
                    { new Guid("d8036fd0-1e30-4e49-8ec3-328b6a1b5c02"), "tomato", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dc3b483f-72fc-4bee-a519-387151ccda89", "02281be4-0d95-4711-99a8-0c64b640799b" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "099cbd77-4110-43f3-b771-3bd2dd976d5b" },
                    { "dc3b483f-72fc-4bee-a519-387151ccda89", "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("10376ad2-a002-4efd-8b85-81d996cc98df"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("a9b8334a-125b-4cb7-bac8-b325514a8223") },
                    { new Guid("1917d909-1520-4254-8038-22e802afd312"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("1507ca55-71b2-47d2-bf42-877b02c71718") },
                    { new Guid("2407de12-5255-4c9b-a341-e2401b0584f4"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("c28c19ab-eea1-45b7-b14d-a85adc37c6d2") },
                    { new Guid("25e21efc-8351-4583-a38c-b2b645615804"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19") },
                    { new Guid("4f123d89-a7e4-4276-9e97-9b856b98dc19"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("92ea16f4-7a90-4fd8-805a-a606c093063e") },
                    { new Guid("50efa2bc-1d28-430b-b65a-80f3505c1afa"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("92ea16f4-7a90-4fd8-805a-a606c093063e") },
                    { new Guid("53cd1d84-e8e9-421a-ab13-3339ad34834d"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19") },
                    { new Guid("53e0df93-bed2-4d26-8f84-ea43feba3f46"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("cc4538a2-5b30-4421-a08d-a3e460fe6dd2") },
                    { new Guid("62b246f4-bd0b-4a0a-bbe1-3e673d7683d1"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("6feaa3bc-0cf8-4ac9-8238-7192ff1af5b3") },
                    { new Guid("83542567-c618-4812-b9a9-c57904e97045"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("60725929-ae42-4838-8c7b-1976f79730f3") },
                    { new Guid("86540e5d-0415-413e-9568-f1058c452c0e"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("c28c19ab-eea1-45b7-b14d-a85adc37c6d2") },
                    { new Guid("907499c3-a68a-45a6-85b9-9fb16b3e4f75"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("60725929-ae42-4838-8c7b-1976f79730f3") },
                    { new Guid("918a5f5c-2f15-4236-84c6-9383153dad56"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("6feaa3bc-0cf8-4ac9-8238-7192ff1af5b3") },
                    { new Guid("abb70bbd-43c6-4776-8248-d453521f2b3d"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("d8036fd0-1e30-4e49-8ec3-328b6a1b5c02") },
                    { new Guid("aee88ad4-e559-44e5-82a0-23188b224dfa"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("1507ca55-71b2-47d2-bf42-877b02c71718") },
                    { new Guid("ccd6255b-fe49-4bd4-86f9-2b33b03c820a"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("d8036fd0-1e30-4e49-8ec3-328b6a1b5c02") },
                    { new Guid("d6c86d88-b232-429b-8206-6ee969156b20"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("a9b8334a-125b-4cb7-bac8-b325514a8223") },
                    { new Guid("f45b3877-b8b0-4cbe-a7ab-54515862407c"), new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"), new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19") },
                    { new Guid("f58d9e70-83b3-4f16-a1f6-1086492e37f7"), new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"), new Guid("cc4538a2-5b30-4421-a08d-a3e460fe6dd2") }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("007e837e-1dfb-4d59-b0c9-c325f0d8d32d"), "3541 Anchor Way", "Eugene", "099cbd77-4110-43f3-b771-3bd2dd976d5b", "Krabs" },
                    { new Guid("0e9ede9a-14aa-4801-80e5-62fef7a0f63c"), "124 Conch Street", "SpongeBob", "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c", "SquarePants" },
                    { new Guid("1695d860-3926-452f-9c5b-42518b143fa5"), "122 Conch Street", "Squidward", "02281be4-0d95-4711-99a8-0c64b640799b", "Tentacles" },
                    { new Guid("2335abc1-2914-4355-b32b-6f5dd81ccc8f"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" },
                    { new Guid("2a5c48d7-9ce7-4747-80c6-bcdfebc62d82"), "120 Conch Street", "Patrick", "c32c4039-3085-44f9-b190-eabc0db206b7", "Star" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("9c850bab-3dd6-4415-ab77-d2b880885303"), new Guid("2a5c48d7-9ce7-4747-80c6-bcdfebc62d82"), new Guid("1695d860-3926-452f-9c5b-42518b143fa5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("99aea153-e778-4e43-9210-1125857287c9") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), null, new Guid("9c850bab-3dd6-4415-ab77-d2b880885303"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("40a5da61-4f56-4081-8bb7-41976b0a701d"), new Guid("5c1dd2e5-156d-4196-9bc6-57e7c2d8e0b3"), new Guid("9c850bab-3dd6-4415-ab77-d2b880885303"), 1, new Guid("52e7feb2-ce4b-41ff-954b-bf1530547817") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("178a0e8b-bc78-4daa-9976-8935353340b9"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("9c850bab-3dd6-4415-ab77-d2b880885303"), 1, new Guid("1e1642f0-346b-4f30-b886-a93a71fc7efd"), new Guid("919e5331-40e7-4db7-b9a6-7f7bfbda2188") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("02e33225-72c0-4967-90ad-ec4f79ba3d63"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("cc4538a2-5b30-4421-a08d-a3e460fe6dd2") },
                    { new Guid("0f718f4b-d7b9-4423-83df-2984a5b56d12"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("a9b8334a-125b-4cb7-bac8-b325514a8223") },
                    { new Guid("15cc10b4-1980-4a61-953a-d859b022428f"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("1507ca55-71b2-47d2-bf42-877b02c71718") },
                    { new Guid("19b9950e-ec42-46df-b85d-f9b256aac0cd"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("92ea16f4-7a90-4fd8-805a-a606c093063e") },
                    { new Guid("26414236-cd46-4cfa-8a35-5775426abdba"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19") },
                    { new Guid("55fe7e6a-c202-4b84-b5fe-b3a0afb09423"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("c28c19ab-eea1-45b7-b14d-a85adc37c6d2") },
                    { new Guid("7c0c7ce4-e178-4803-86d3-487db8d08e2b"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("d8036fd0-1e30-4e49-8ec3-328b6a1b5c02") },
                    { new Guid("870c174e-f82a-4ca5-9d24-99e4f73c8c8d"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("60725929-ae42-4838-8c7b-1976f79730f3") },
                    { new Guid("a363fddc-4f80-4858-91cc-5d92a01fea7e"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("6feaa3bc-0cf8-4ac9-8238-7192ff1af5b3") },
                    { new Guid("e130519e-4022-432f-a4ec-d04763ac9d4c"), new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"), new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19") }
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
