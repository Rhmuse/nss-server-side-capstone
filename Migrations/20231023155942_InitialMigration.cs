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
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b802dd37-149a-423f-a457-5d8c05594c5c", null, "Employee", "employee" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "598b9523-28c4-46e3-b13a-26188c6d5b64", 0, "8b0b9fc6-043c-4276-aa5c-94aa35f1a139", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEA+IvnSUdpsmFrLXn+3szAvc6Wpf0B0/R1yu8CXZ3J5LYSI+jx7MgE0VCODD/Dcg/Q==", null, false, "00e8ab9e-187c-4566-9329-a0d6d2d2b2cf", false, "stentacles" },
                    { "5f087a32-fea6-4e60-b826-0821fc4e9989", 0, "f1b200c3-6bdc-4f47-a1ba-48347779bad9", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEFc8ZMCO9x1Cr516+Vt42zY4GPyRA2Wo8a+8p/XaKfWVP2rfat611deh57Xu/lwaiQ==", null, false, "651a0451-fd7f-418a-be11-64de7617a869", false, "ekrabs" },
                    { "604d1824-75a3-4369-81b8-64aaf1b9c434", 0, "90a8498d-d5d8-4459-acd2-0c55bd1eabe1", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIGOIp3F+lBJlX1oje+RxoSRCNFjx7XmMpFqBM6L63Hkx5SOR0luXBmur3hWPcaqdQ==", null, false, "4393e0a4-41ad-4ee2-a06b-303b000869ad", false, "ssquarepants" },
                    { "d0b4ff4d-f61c-4b24-9af1-63775cdb86a6", 0, "1e421fa3-89c2-4d38-b15c-c0264281728e", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEADcdFlRDkLinJcpX9SEd/F/gUUf0FV0lK4AkEg4at9G5KWH5NOhwlO/3ZuVNQ1+8w==", null, false, "6a80f91a-11d2-4550-b66f-4698a8b22394", false, "pstar" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "b32f66da-6372-4f1e-b51f-9083a7dca2b9", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAELbvf+DffXPv0NrbjuqeEem5OWT2rgqcpLgaqj4ExiBCXMYjXdTgoBSZadsA9efGbw==", null, false, "74f64593-19a3-4609-b15a-1f504b82f419", false, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0e90bf65-e600-4115-a7c7-0d2602b0b791"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("bf948597-f998-436b-bacd-ac718365d263") },
                    { new Guid("184c3ef1-4462-4b88-8ca9-de73cc031d8f"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("f03ad51b-51ed-4429-8ff5-96d21d22206e") },
                    { new Guid("18ec4b01-0f82-478d-8271-17a191da2de6"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755") },
                    { new Guid("1961854e-f31a-4802-9f25-256d617c8cdf"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("8e109b34-2711-4fa3-a3ce-cd55f62e2db6") },
                    { new Guid("393d18cc-6273-4686-a6ae-84cc52c3a55f"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("1b917219-c9ad-4698-819f-f530bfd3cfd7") },
                    { new Guid("3a5cf372-8a22-4762-91b0-771d1875550e"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("8e109b34-2711-4fa3-a3ce-cd55f62e2db6") },
                    { new Guid("41a55886-9495-4bde-bfb4-9bbea84a5252"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("80798c5b-c0f9-478a-9638-468744a34b1d") },
                    { new Guid("5a59164d-488a-4752-a6ac-8b55c7cef494"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("8e109b34-2711-4fa3-a3ce-cd55f62e2db6") },
                    { new Guid("63e26862-9a74-4b1c-813e-1bab640eef2c"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755") },
                    { new Guid("8abb91b0-58c8-4b9c-ba8d-fad63266d3c8"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("4138fbb6-eabe-4e97-8fb5-a592d108d939") },
                    { new Guid("8bba1336-86d3-4ea3-a285-b11c2dfd9cf5"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("988d8678-2a45-4322-b758-da6aa02013d5") },
                    { new Guid("96328079-d968-4459-8aae-7ed7cc8a5f48"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("1b917219-c9ad-4698-819f-f530bfd3cfd7") },
                    { new Guid("aa4dea0e-bcd5-4c43-8274-a6c407eda2ef"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755") },
                    { new Guid("b6abe447-eb4f-4402-8c70-87e22a26bf9f"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("560a328b-a9e0-47d9-aa36-6e497dc9ea9f") },
                    { new Guid("b91a8cae-e72a-4cb6-a0c8-9442df63ae18"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("bf948597-f998-436b-bacd-ac718365d263") },
                    { new Guid("bb21a63f-97c6-48b3-b810-c4b539a9f85c"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755") },
                    { new Guid("bfec3e88-3266-4f2b-8300-c9fd4042a544"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("bf948597-f998-436b-bacd-ac718365d263") },
                    { new Guid("c8156e00-916a-485a-aff7-5195657f17c0"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("4138fbb6-eabe-4e97-8fb5-a592d108d939") },
                    { new Guid("ca088b58-3b33-4c7f-9587-80536ffd193d"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("1b917219-c9ad-4698-819f-f530bfd3cfd7") },
                    { new Guid("cf0fe751-4e38-4e8e-b6e4-73c8ad8970d2"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("80798c5b-c0f9-478a-9638-468744a34b1d") },
                    { new Guid("d00984fa-196e-4e18-ada6-8c09b5d309e3"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755") },
                    { new Guid("d1288a7f-4f20-40db-97bd-784e1c9703d5"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("80798c5b-c0f9-478a-9638-468744a34b1d") },
                    { new Guid("deb3b86c-7ceb-43a9-b3f8-242765ae0cd1"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("560a328b-a9e0-47d9-aa36-6e497dc9ea9f") },
                    { new Guid("e6ef39b2-ff3b-403a-a626-dd6ce2748ce7"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("560a328b-a9e0-47d9-aa36-6e497dc9ea9f") },
                    { new Guid("eb0ad7ba-79ec-484c-af31-ed55845e3648"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("988d8678-2a45-4322-b758-da6aa02013d5") },
                    { new Guid("f91c22e8-8ae9-4246-ae82-920e6764a409"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), new Guid("4138fbb6-eabe-4e97-8fb5-a592d108d939") },
                    { new Guid("fe4fbfda-28e1-4a4a-9bc1-5d199921c944"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("988d8678-2a45-4322-b758-da6aa02013d5") },
                    { new Guid("fecde59e-71ad-4319-88bb-5b3d52cba5d5"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), new Guid("f03ad51b-51ed-4429-8ff5-96d21d22206e") },
                    { new Guid("ff055365-b367-4f57-867d-28bea648549c"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("f03ad51b-51ed-4429-8ff5-96d21d22206e") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), null, 1 },
                    { new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("107a03cc-a71c-4654-a80a-48be15e62fe7"), new Guid("933b55b5-0717-46b4-b490-cee5bb35ad6c"), new Guid("cfaed14e-1807-482e-80de-6460aea6fad2"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01") },
                    { new Guid("2dce9a45-7b82-442a-b498-e6b1b9f94c51"), new Guid("933b55b5-0717-46b4-b490-cee5bb35ad6c"), new Guid("5e7cdae8-ed6b-4d68-bc60-119c4f0fc03b"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01") },
                    { new Guid("77c4d776-5aa2-4d94-93b7-58493173ac8f"), new Guid("933b55b5-0717-46b4-b490-cee5bb35ad6c"), new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("6d3d7218-65b1-4932-a6e7-7f5e8875f1f1"), new Guid("080e587a-9cb4-4d1c-9d5a-b0035f317ac9"), -1f, "krabby patty combo" },
                    { new Guid("933b55b5-0717-46b4-b490-cee5bb35ad6c"), new Guid("0ba6206a-8e20-41a0-a0bb-51fac3914a4a"), -1.25f, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("219d61b0-e8fa-4c9a-8cca-06f998d3d081"), "red tide", 1f },
                    { new Guid("46dec6aa-64ed-4535-afc7-3d4eec9618ae"), "water", 0.1f },
                    { new Guid("5e5630a1-55ac-4b1f-8ed0-5fe811bf36ef"), "dr. kelp", 1f },
                    { new Guid("6c101303-bfc3-43c5-b388-7c97f07e5afd"), "diet dr. kelp", 1f },
                    { new Guid("840135aa-c477-4e2e-9fc4-c4ac4a999947"), "seafoam soda", 1f },
                    { new Guid("a6b99322-b9ee-4d27-9fec-3a0822954d7c"), "kelp shake", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("332f96b0-58e1-4eff-8fd9-0dffc866147c"), "pickup" },
                    { new Guid("5d2e49b6-447c-40fe-94fb-af6d98bc007d"), "togo" },
                    { new Guid("7d3ceb41-193f-48ba-9cae-58f56ee500ab"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("14cd4f41-a580-48c0-b450-c86e4b81b29e"), "barnacle rings", 1.25f },
                    { new Guid("32053552-2e04-45b1-9f68-3f144dd522cc"), "seaweed salad", 2f },
                    { new Guid("3cda9fe2-5cef-4a6e-8f2c-c5a9cd7d3873"), "coral bits", 1.25f },
                    { new Guid("df7830c7-a51a-4d17-be0b-ab66fa28050e"), "kelp fries", 1.25f },
                    { new Guid("dfe6ec1b-9cc6-4ec4-a619-4d00776377be"), "oyster skins", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("090aa5b7-d8f0-4f1b-9404-384e403ed277"), "small", "sm" },
                    { new Guid("40cc063c-7222-49b5-ab71-0297fdf1f86c"), "medium", "md" },
                    { new Guid("da663954-1bf0-47bd-ad19-6e3c3d5a3eb2"), "large", "lg" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02a1d1bb-b44b-4400-b1ff-ea897b0cad8b"), "sea cheese", 0.25f },
                    { new Guid("1b917219-c9ad-4698-819f-f530bfd3cfd7"), "pickle", 0.05f },
                    { new Guid("4138fbb6-eabe-4e97-8fb5-a592d108d939"), "ketchup", 0f },
                    { new Guid("560a328b-a9e0-47d9-aa36-6e497dc9ea9f"), "secret sauce", 0f },
                    { new Guid("80798c5b-c0f9-478a-9638-468744a34b1d"), "tomato", 0.05f },
                    { new Guid("8e109b34-2711-4fa3-a3ce-cd55f62e2db6"), "onion", 0.05f },
                    { new Guid("988d8678-2a45-4322-b758-da6aa02013d5"), "bun", 0.2f },
                    { new Guid("bf948597-f998-436b-bacd-ac718365d263"), "lettuce", 0.05f },
                    { new Guid("e0c661cf-f3b4-4046-bdc8-98dd94941755"), "patty", 1f },
                    { new Guid("f03ad51b-51ed-4429-8ff5-96d21d22206e"), "mustard", 0f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b802dd37-149a-423f-a457-5d8c05594c5c", "598b9523-28c4-46e3-b13a-26188c6d5b64" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "5f087a32-fea6-4e60-b826-0821fc4e9989" },
                    { "b802dd37-149a-423f-a457-5d8c05594c5c", "604d1824-75a3-4369-81b8-64aaf1b9c434" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("30da8b0b-1ad5-4cea-9799-53840137a92c"), "120 Conch Street", "Patrick", "d0b4ff4d-f61c-4b24-9af1-63775cdb86a6", "Star" },
                    { new Guid("5e1edc70-be57-4107-812c-6b5d8232adb3"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" },
                    { new Guid("afbebdb0-0167-45c6-9c02-6641c96de136"), "122 Conch Street", "Squidward", "598b9523-28c4-46e3-b13a-26188c6d5b64", "Tentacles" },
                    { new Guid("b0667a6a-1da4-4503-b0e4-51ff73f3c876"), "124 Conch Street", "SpongeBob", "604d1824-75a3-4369-81b8-64aaf1b9c434", "SquarePants" },
                    { new Guid("d9037379-7f34-40e1-99a8-6bee4152a651"), "3541 Anchor Way", "Eugene", "5f087a32-fea6-4e60-b826-0821fc4e9989", "Krabs" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01"), new Guid("30da8b0b-1ad5-4cea-9799-53840137a92c"), new Guid("afbebdb0-0167-45c6-9c02-6641c96de136"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d3ceb41-193f-48ba-9cae-58f56ee500ab") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[] { new Guid("7c3e7931-a0a1-41e1-8376-98043e7f08ac"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("cfaed14e-1807-482e-80de-6460aea6fad2"), new Guid("219d61b0-e8fa-4c9a-8cca-06f998d3d081"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01"), 1, new Guid("40cc063c-7222-49b5-ab71-0297fdf1f86c") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("5e7cdae8-ed6b-4d68-bc60-119c4f0fc03b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("7cde64fe-31ff-4e71-ba31-14db7887ad01"), 1, new Guid("3cda9fe2-5cef-4a6e-8f2c-c5a9cd7d3873"), new Guid("da663954-1bf0-47bd-ad19-6e3c3d5a3eb2") });

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
                name: "Burgers");

            migrationBuilder.DropTable(
                name: "BurgerToppings");

            migrationBuilder.DropTable(
                name: "ComboItems");

            migrationBuilder.DropTable(
                name: "Combos");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "OrderDrinks");

            migrationBuilder.DropTable(
                name: "OrderSides");

            migrationBuilder.DropTable(
                name: "Sides");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

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
