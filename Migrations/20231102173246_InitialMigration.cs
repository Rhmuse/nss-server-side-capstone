using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
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
                    Price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
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
                name: "OrderCombos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ComboId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCombos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderCombos_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
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
                    IsInCombo = table.Column<bool>(type: "boolean", nullable: false),
                    OrderComboId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Burgers_OrderCombos_OrderComboId",
                        column: x => x.OrderComboId,
                        principalTable: "OrderCombos",
                        principalColumn: "Id");
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
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsInCombo = table.Column<bool>(type: "boolean", nullable: false),
                    OrderComboId = table.Column<Guid>(type: "uuid", nullable: true)
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
                        name: "FK_OrderDrinks_OrderCombos_OrderComboId",
                        column: x => x.OrderComboId,
                        principalTable: "OrderCombos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderDrinks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDrinks_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
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
                    SizeId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsInCombo = table.Column<bool>(type: "boolean", nullable: false),
                    OrderComboId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderSides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderSides_OrderCombos_OrderComboId",
                        column: x => x.OrderComboId,
                        principalTable: "OrderCombos",
                        principalColumn: "Id");
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
                    table.ForeignKey(
                        name: "FK_OrderSides_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
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
                    table.ForeignKey(
                        name: "FK_Combos_Burgers_BurgerId",
                        column: x => x.BurgerId,
                        principalTable: "Burgers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" },
                    { "e774cbd9-8dec-4672-bc59-2397574b7f34", null, "Employee", "employee" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "58e2c2d7-3f88-4315-817c-ebc672c8981d", 0, "f4d3827d-6c9e-4f69-86d0-d6ca7cb985b1", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDPrdLtwP62CHsy2pBgdjSnEmCB0SZeciY1ILdCJFjvJdqIF1CyOvUehtxwIs3WzmA==", null, false, "260e84aa-4097-4c78-92d1-53f436c6d3b3", false, "ekrabs" },
                    { "7038488f-6630-475f-bc11-d4217b6fe8c4", 0, "7335ede7-4ba8-4ba9-bb75-e444865b7d58", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAED4Lv0HI75Pf0f4slACqlaFDItlnDhfB70TYLVqU2eZzEaxKMrtPUaFSn3ZnIUoBew==", null, false, "a761cf02-e083-473b-8d88-0efafb4582ee", false, "pstar" },
                    { "b611e18b-602f-40a5-bcc3-c67ab86cb19c", 0, "023d5504-68b2-45d2-b1ef-269f11f79d79", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFfnE1LTW0SM4B070XUuzz6A+RlJtm2wQpy7g2B71CiXMmiFw6zsXDyI0H47758kKg==", null, false, "eb2de5db-8786-4bde-8b30-abbdb1d2e53b", false, "ssquarepants" },
                    { "d5cc5981-027c-435a-abd2-b31423ae24bc", 0, "64cf7451-2468-44a9-a871-423afeebc5ed", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDbRIcmffPanuAgPy9xx/AIA2fCnMDivHcHLIE4fBOkrpi9pmwcbG/r6HCNbErtcYQ==", null, false, "8949604f-9c63-4c4f-a3e2-96d724b12c7d", false, "stentacles" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "974b549e-ef8b-4008-87a5-779774a69e7b", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAELtA7X/5Ms87OrPBz1KmS3WvsW79j+6OJuDIGgQVe+tQPekEji26dgQnU/BRfFSsQg==", null, false, "850f7177-a363-4d0f-b0e2-c418432fda11", false, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, false, "double krabby patty", null, null, 1 },
                    { new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, false, "krabby patty", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1235e044-45ba-43d8-b3e7-a4ad83148c5f"), false, "kelp shake", 1.5f },
                    { new Guid("12eb1379-42fd-4fa5-b701-a3ac6b168754"), false, "diet dr. kelp", 1f },
                    { new Guid("1eedb094-f9c2-4b93-80cf-b7152edfdc08"), false, "water", 0.1f },
                    { new Guid("4b05aada-95a6-4f30-9251-e73d0bf37d18"), false, "dr. kelp", 1f },
                    { new Guid("671b8ce1-e876-494c-92fc-b5e085ff8667"), false, "red tide", 1f },
                    { new Guid("f720ca5f-b33b-4204-aa59-6365c300a3c2"), false, "seafoam soda", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ecfa89c-a143-4e86-aeab-7af9d6333c9d"), "togo" },
                    { new Guid("3cd12cda-035d-4ad8-b574-53293c44a4d5"), "pickup" },
                    { new Guid("c9688797-03ea-48b8-b958-004b1260821c"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("221df44a-ff9c-486c-9733-2b549d3733e4"), false, "coral bits", 1.25f },
                    { new Guid("9a43d59a-40be-4006-83a4-4c31ecc71808"), false, "seaweed salad", 2f },
                    { new Guid("a18931b1-a4f0-424d-b465-5dccb31f56cf"), false, "oyster skins", 1.25f },
                    { new Guid("a48e7262-0e2b-466f-9666-0ee07888d06b"), false, "kelp fries", 1.25f },
                    { new Guid("ebcff6d6-7334-490e-b61f-e59ceba61637"), false, "barnacle rings", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("74759769-9f69-4f3b-8421-47d2899d0598"), false, "large", 0.45f, "lg" },
                    { new Guid("d3320c70-37cb-44a0-bef5-fdb4b6e73b9c"), false, "small", 0f, "sm" },
                    { new Guid("da225b39-508e-466d-8276-0fcbbdd04aaf"), false, "medium", 0.2f, "md" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("13a06784-a65f-439d-92d5-c872c6e07816"), false, "lettuce", 0.05f },
                    { new Guid("2b3e74e0-fac2-4f14-b1ba-a23f534cf9c4"), false, "pickle", 0.05f },
                    { new Guid("2e990b5f-d669-4de3-95d1-5984ee68d640"), false, "bun", 0.2f },
                    { new Guid("58164af6-bf37-4877-87e5-916fdf921b06"), false, "tomato", 0.05f },
                    { new Guid("746c09e1-4e26-4380-8fb8-a0aa99e37d64"), false, "ketchup", 0f },
                    { new Guid("7ee0b60b-6297-497e-9cb2-60457906e049"), false, "sea cheese", 0.25f },
                    { new Guid("8af0a817-f4f7-4b58-bb37-35f5cf507569"), false, "onion", 0.05f },
                    { new Guid("9e821c8e-06b5-4b1e-9fb0-bac3dee20e16"), false, "mustard", 0f },
                    { new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319"), false, "patty", 1f },
                    { new Guid("fdec8d52-9348-4f19-8798-0039fc604bcc"), false, "secret sauce", 0f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "58e2c2d7-3f88-4315-817c-ebc672c8981d" },
                    { "e774cbd9-8dec-4672-bc59-2397574b7f34", "b611e18b-602f-40a5-bcc3-c67ab86cb19c" },
                    { "e774cbd9-8dec-4672-bc59-2397574b7f34", "d5cc5981-027c-435a-abd2-b31423ae24bc" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("1c4fa926-f0ec-4fe0-9d6a-dddb92e5aec2"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("fdec8d52-9348-4f19-8798-0039fc604bcc") },
                    { new Guid("1d20b778-bea6-4a86-9f02-5f4e2f364864"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("9e821c8e-06b5-4b1e-9fb0-bac3dee20e16") },
                    { new Guid("21bbcb4f-b0ce-4dce-86a8-9b6dca8269d7"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("8af0a817-f4f7-4b58-bb37-35f5cf507569") },
                    { new Guid("27212abb-620d-40af-86d0-939cfb9cbe72"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("58164af6-bf37-4877-87e5-916fdf921b06") },
                    { new Guid("2f1cee90-61d9-4937-9b1e-00c017a4e59b"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("8af0a817-f4f7-4b58-bb37-35f5cf507569") },
                    { new Guid("4c4c2b09-0cc9-420e-bda5-3eb11416fa99"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("2b3e74e0-fac2-4f14-b1ba-a23f534cf9c4") },
                    { new Guid("571330f4-7298-4e6d-a8ca-65fd050b49ef"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("677469e1-4aae-41b5-a25d-ead72d75b0c4"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("13a06784-a65f-439d-92d5-c872c6e07816") },
                    { new Guid("6c9beb34-4712-449c-af74-b343f17e4d78"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("2e990b5f-d669-4de3-95d1-5984ee68d640") },
                    { new Guid("8ad04996-eb8f-4ef7-bbea-e21a85922e64"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("934db118-2ea8-4278-9051-03b670be3237"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("746c09e1-4e26-4380-8fb8-a0aa99e37d64") },
                    { new Guid("9881a77f-d0c8-4c43-aa99-e07c3cc143d1"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("9e821c8e-06b5-4b1e-9fb0-bac3dee20e16") },
                    { new Guid("adba2703-0439-49e4-bc0c-bb2254b34428"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("b0fef76e-dbb6-43c8-915e-ebc29c013cf2"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("fdec8d52-9348-4f19-8798-0039fc604bcc") },
                    { new Guid("c19c46f8-2a90-48d5-8ed9-6377d04af4f1"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("7ee0b60b-6297-497e-9cb2-60457906e049") },
                    { new Guid("cac63f52-4a07-4c76-a0d7-6d9b6a2a0e54"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("7ee0b60b-6297-497e-9cb2-60457906e049") },
                    { new Guid("ce1abafe-685f-4cf2-94c8-fcdbeb1898ea"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("2b3e74e0-fac2-4f14-b1ba-a23f534cf9c4") },
                    { new Guid("d41b7348-2f37-416a-a281-63d5208bceff"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("746c09e1-4e26-4380-8fb8-a0aa99e37d64") },
                    { new Guid("e07dc760-72eb-4567-a36f-107e21461442"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("13a06784-a65f-439d-92d5-c872c6e07816") },
                    { new Guid("ea9c3d28-ac11-4a5f-9526-5bfd4e9c8064"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), false, new Guid("58164af6-bf37-4877-87e5-916fdf921b06") },
                    { new Guid("ee33d4c8-d1ef-4714-a34a-cd51c02c1cbe"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), false, new Guid("2e990b5f-d669-4de3-95d1-5984ee68d640") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("5305006c-549d-4365-be05-15e12b1827bd"), new Guid("149d0c69-43fc-471c-8877-941cf5920410"), -1.25f, false, "double krabby patty combo" },
                    { new Guid("b4c5dd30-39c1-415e-8476-1ecd507edd48"), new Guid("a1f38fec-b768-4aed-a728-ee13beb503a1"), -1f, false, "krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("23e62dd6-e434-429b-b163-52db44dd31ad"), "124 Conch Street", "SpongeBob", "b611e18b-602f-40a5-bcc3-c67ab86cb19c", "SquarePants" },
                    { new Guid("6c7d9f7d-9e7e-499c-a51e-c5dd5770f680"), "120 Conch Street", "Patrick", "7038488f-6630-475f-bc11-d4217b6fe8c4", "Star" },
                    { new Guid("92f50309-ce8b-4351-af59-dcf7e3d2a1b6"), "3541 Anchor Way", "Eugene", "58e2c2d7-3f88-4315-817c-ebc672c8981d", "Krabs" },
                    { new Guid("df80484a-5b4c-4472-9645-2affc39df911"), "122 Conch Street", "Squidward", "d5cc5981-027c-435a-abd2-b31423ae24bc", "Tentacles" },
                    { new Guid("f732039d-8a4b-495f-a372-41aa9ee917df"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), new Guid("6c7d9f7d-9e7e-499c-a51e-c5dd5770f680"), new Guid("df80484a-5b4c-4472-9645-2affc39df911"), new DateTime(2023, 11, 2, 12, 32, 46, 315, DateTimeKind.Local).AddTicks(8147), new Guid("c9688797-03ea-48b8-b958-004b1260821c") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, false, null, null, new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 2 });

            migrationBuilder.InsertData(
                table: "OrderCombos",
                columns: new[] { "Id", "ComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("bea939be-6758-4a00-8a36-258b6e7d2b7f"), new Guid("b4c5dd30-39c1-415e-8476-1ecd507edd48"), new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("588352dd-fbf1-43cf-aef7-f93ad6974946"), new Guid("671b8ce1-e876-494c-92fc-b5e085ff8667"), false, null, new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1, new Guid("da225b39-508e-466d-8276-0fcbbdd04aaf") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("e503d86b-3af0-4ec6-b8a0-e671b207c638"), false, null, new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1, new Guid("221df44a-ff9c-486c-9733-2b549d3733e4"), new Guid("74759769-9f69-4f3b-8421-47d2899d0598") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0ed67491-cd37-4124-b070-4cf4d1042790"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("20bc9275-3613-4bc1-8a1b-9411997e909c"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("13a06784-a65f-439d-92d5-c872c6e07816") },
                    { new Guid("27787015-0fe6-4447-9a22-c7d9444c51f7"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("2b3e74e0-fac2-4f14-b1ba-a23f534cf9c4") },
                    { new Guid("48921eda-b0da-4f7e-b2c3-567f023b263c"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("4a4ec9eb-da7f-4758-9384-96101152ddc4"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("2e990b5f-d669-4de3-95d1-5984ee68d640") },
                    { new Guid("53ba471c-daa2-40f8-bdae-653c0724ef22"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("fdec8d52-9348-4f19-8798-0039fc604bcc") },
                    { new Guid("6e49811e-d143-4883-bf11-6b433ea8dd7b"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("58164af6-bf37-4877-87e5-916fdf921b06") },
                    { new Guid("87cbbaad-484b-4e89-8dda-90ccbe2b12d2"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("8af0a817-f4f7-4b58-bb37-35f5cf507569") },
                    { new Guid("98d7efff-5b5d-435f-a0dc-3f48461eff80"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("9e821c8e-06b5-4b1e-9fb0-bac3dee20e16") },
                    { new Guid("c2f32e60-2eef-41be-b9a8-48ae9f55ca73"), new Guid("eb4cec0c-e729-44db-81d6-32fb5915a1fe"), false, new Guid("746c09e1-4e26-4380-8fb8-a0aa99e37d64") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("ae27d355-d915-4f9c-a1d9-6565327430ec"), false, true, null, new Guid("bea939be-6758-4a00-8a36-258b6e7d2b7f"), new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("b8647e77-2100-4daf-a910-63619544c046"), new Guid("4b05aada-95a6-4f30-9251-e73d0bf37d18"), true, new Guid("bea939be-6758-4a00-8a36-258b6e7d2b7f"), new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1, new Guid("da225b39-508e-466d-8276-0fcbbdd04aaf") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("f2756abf-eb62-4e2e-9f09-65d14fa5acf1"), true, new Guid("bea939be-6758-4a00-8a36-258b6e7d2b7f"), new Guid("c1b3b05e-e7e6-49dc-80c0-a93cf46a130a"), 1, new Guid("a48e7262-0e2b-466f-9666-0ee07888d06b"), new Guid("74759769-9f69-4f3b-8421-47d2899d0598") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("5f83dd17-7c87-49f6-95ad-621b40e1aea4"), new Guid("ae27d355-d915-4f9c-a1d9-6565327430ec"), false, new Guid("a4b98006-dbb8-4aa1-b592-4082cddce319") },
                    { new Guid("68ecdc2c-58ce-438a-9097-13342810cf6b"), new Guid("ae27d355-d915-4f9c-a1d9-6565327430ec"), false, new Guid("746c09e1-4e26-4380-8fb8-a0aa99e37d64") },
                    { new Guid("7682cdf4-c267-45b0-92a5-492863caecff"), new Guid("ae27d355-d915-4f9c-a1d9-6565327430ec"), false, new Guid("9e821c8e-06b5-4b1e-9fb0-bac3dee20e16") },
                    { new Guid("e6b102b9-48b3-4e76-8940-42d7b6aeb217"), new Guid("ae27d355-d915-4f9c-a1d9-6565327430ec"), false, new Guid("2e990b5f-d669-4de3-95d1-5984ee68d640") }
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
                name: "IX_Burgers_OrderComboId",
                table: "Burgers",
                column: "OrderComboId",
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
                name: "IX_Combos_BurgerId",
                table: "Combos",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderCombos_OrderId",
                table: "OrderCombos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_DrinkId",
                table: "OrderDrinks",
                column: "DrinkId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_OrderComboId",
                table: "OrderDrinks",
                column: "OrderComboId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_OrderId",
                table: "OrderDrinks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDrinks_SizeId",
                table: "OrderDrinks",
                column: "SizeId");

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
                name: "IX_OrderSides_OrderComboId",
                table: "OrderSides",
                column: "OrderComboId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderSides_OrderId",
                table: "OrderSides",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSides_SideId",
                table: "OrderSides",
                column: "SideId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderSides_SizeId",
                table: "OrderSides",
                column: "SizeId");

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
                name: "Combos");

            migrationBuilder.DropTable(
                name: "OrderDrinks");

            migrationBuilder.DropTable(
                name: "OrderSides");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "OrderCombos");

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
