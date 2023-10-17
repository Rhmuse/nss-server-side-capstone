using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class initialAdd : Migration
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
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    Quantity = table.Column<int>(type: "integer", nullable: false)
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
                    ComboItemId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { "70498912-9de9-47fc-a5c3-7afd7b4431df", null, "Employee", "employee" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1730a8a1-5239-4905-86b5-32a6fa628603", 0, "1893ace2-8b04-4a26-a0f7-276a9b24b464", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJn7ouarooZQ+YNvGlA1fivKy2omGGv/mZA8SRaZXBGuOiu71NZZpLODfIvtaQDlLg==", null, false, "cf145d4c-e2cd-4649-be6e-2b2dc9aa1ad1", false, "ekrabs" },
                    { "67ce3d19-85fa-42e2-9379-5b91be295661", 0, "9d25b037-ee8e-422e-9283-b3952da6925c", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENmomMnps9yQ5wpQ6j0Wl0wmcVp6F0nPE8+ktQ9xI/2JC+RmI8ImfjTA/tEcMBbqVA==", null, false, "d6ff6415-0213-4be3-9029-545f10e68c40", false, "ssquarepants" },
                    { "aaecde13-1dee-4899-860a-07709cc7705c", 0, "27d4f2a0-fa26-4789-8016-d90c1b24ffe3", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIbI2pLOyXxVEf3X+XNLT8vwGUbUMo6wo/JSdYE8/djw7aZltWSrfr4gSZ+EQc+wEg==", null, false, "766c53d1-2310-4e6b-b775-e652e5cd71e0", false, "stentacles" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "68ad901e-fc07-46ec-9051-348bc5513e98", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAEDLFBA23+m7bh+82jG9aKQppT8SYHUn4buaSRXzV/Zgs8CjfC1IGynSOG4kUAt0q2g==", null, false, "e6056296-2abe-4491-b6f3-05cd2fbd0f87", false, "Administrator" },
                    { "fc73b74e-b3a6-4f1e-8a07-4faa1e9f580f", 0, "49c13167-5668-42f9-86d8-5398d7754296", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKVcwqNMgkce29HCr7AGI1qLcdG152igRPjfSywqPNtdB1H/sH+rX8IlLhfBLCa0gQ==", null, false, "596d32ce-cb27-455f-8e8c-30d6ae4f62cf", false, "pstar" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("009e534e-8450-4d11-95f1-76d1a3d757ef"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("782452eb-eede-4b4a-9053-4c79328adb0f") },
                    { new Guid("07b6aea9-8b76-4aed-b546-160f907bd997"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("99349758-1a84-42de-a927-e549195f7975") },
                    { new Guid("108146e4-abf6-45dd-9362-68ff97afd6e1"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("f741ce79-a158-40ac-bedc-d6473f441e46") },
                    { new Guid("1098a99b-327b-4b4e-833a-9e60a9aef46a"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("99349758-1a84-42de-a927-e549195f7975") },
                    { new Guid("12f0eff8-d966-49e0-8c51-7736c2990b59"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("0c04937e-8885-480a-beed-2cf946c70819") },
                    { new Guid("1a04876d-95be-47aa-9b28-80412a2c8f84"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("f741ce79-a158-40ac-bedc-d6473f441e46") },
                    { new Guid("21025b4f-d628-40d3-bac2-182245900815"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("9673aade-f07b-478b-894b-dc4d2282c847") },
                    { new Guid("448f2405-0f8c-405a-ba5e-9aa30824ca7c"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("fd1efc42-2c14-477b-908e-89363a258b3e") },
                    { new Guid("46b3770a-8d17-46b4-8d51-680ca2f521f3"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("89618a45-9bb3-45d0-b940-6ebcfd5cba3f") },
                    { new Guid("47114504-cc9f-4665-a2b9-5d86dfab7663"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c") },
                    { new Guid("4769774a-f91d-4720-a2c3-703481187342"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("9673aade-f07b-478b-894b-dc4d2282c847") },
                    { new Guid("4823d565-65b8-4688-950d-2b76418b1d1f"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("fd1efc42-2c14-477b-908e-89363a258b3e") },
                    { new Guid("4d916587-e1d7-4498-b5eb-a1fa0d904144"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("782452eb-eede-4b4a-9053-4c79328adb0f") },
                    { new Guid("60ec8ef2-a519-41ad-90ee-a2677c14fbd8"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("782452eb-eede-4b4a-9053-4c79328adb0f") },
                    { new Guid("6f5bbade-fbd5-40df-a552-cb0e242457f6"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("209475f0-a4fa-4925-b7e3-a7aa5e6e474c") },
                    { new Guid("74c914ab-66df-41d6-8a64-3c352fabe9ba"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("0c04937e-8885-480a-beed-2cf946c70819") },
                    { new Guid("97bc626d-1961-4b86-ab24-0c4097c20bfd"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c") },
                    { new Guid("9c286875-e6be-48e8-a89c-6e6908a07f72"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c") },
                    { new Guid("a00ee486-08a8-4620-b920-f4d27002a6ee"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("209475f0-a4fa-4925-b7e3-a7aa5e6e474c") },
                    { new Guid("a68a7b47-8d87-43a1-887e-afb4c40e5820"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c") },
                    { new Guid("aa1f930c-e033-49c3-92de-f9a98a6c0870"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("9673aade-f07b-478b-894b-dc4d2282c847") },
                    { new Guid("c9f48fb5-7d25-4de1-8e19-9af707f5268f"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("89618a45-9bb3-45d0-b940-6ebcfd5cba3f") },
                    { new Guid("caedbc6f-d90f-4719-888e-1ab441d22817"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("0c04937e-8885-480a-beed-2cf946c70819") },
                    { new Guid("d0813a5c-d171-46ef-bccd-bd99d9d65eff"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("fd1efc42-2c14-477b-908e-89363a258b3e") },
                    { new Guid("e3ffb38d-5293-44b6-ba99-4270c18dc124"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("99349758-1a84-42de-a927-e549195f7975") },
                    { new Guid("f8936f22-e6a5-41e5-bfa2-054465051c25"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c") },
                    { new Guid("fb25ba82-fd8e-49c9-b8f1-9fee32ecc557"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("89618a45-9bb3-45d0-b940-6ebcfd5cba3f") },
                    { new Guid("fbc70c8e-2e49-4073-b45f-5bf70cafe7c2"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("f741ce79-a158-40ac-bedc-d6473f441e46") },
                    { new Guid("fc29c64a-5183-44c3-9113-34ad0e8f3e6d"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), new Guid("209475f0-a4fa-4925-b7e3-a7aa5e6e474c") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), null, 1 },
                    { new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("36aec262-07ad-4cc3-a793-95e9697ed275"), new Guid("3a912e55-f477-4e70-86a0-62446c8f3538"), new Guid("e27a7325-0635-4fe3-945c-877ba120b7e4"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f") },
                    { new Guid("381438f3-cba7-4718-b9b1-f0f6b8bb7802"), new Guid("3a912e55-f477-4e70-86a0-62446c8f3538"), new Guid("c33b0b6b-ae7e-44c6-ae0e-8d13d4dd1fc5"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f") },
                    { new Guid("9061f82a-bfaa-45ed-b96e-4fd94a605c68"), new Guid("3a912e55-f477-4e70-86a0-62446c8f3538"), new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("243fb016-95f6-4d5c-8492-763eaf2342f4"), new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"), -1f, "krabby patty combo" },
                    { new Guid("3a912e55-f477-4e70-86a0-62446c8f3538"), new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"), -1.25f, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1645954e-43ec-4be6-9aba-1d262f8659df"), "red tide", 1f },
                    { new Guid("236e5035-cba4-4dff-acd6-2dca83229cf4"), "water", 0.1f },
                    { new Guid("2d0e08b6-443a-471d-990b-3f685cdf8862"), "diet dr. kelp", 1f },
                    { new Guid("b318597b-a1b8-458d-9989-496e6e7f8db0"), "seafoam soda", 1f },
                    { new Guid("b66a844e-b7f0-4561-b4d7-17c9fcbc2f09"), "dr. kelp", 1f },
                    { new Guid("d7df5d3f-cf52-4de1-8c0c-ecc7e93b2bd8"), "kelp shake", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("43d1a26c-e9b3-497e-8341-cbff145ae482"), "here" },
                    { new Guid("6da31e85-d0ae-4448-9a8c-266456d8d3d9"), "togo" },
                    { new Guid("a9aca786-605a-4e8c-8014-b08a427aa6f3"), "pickup" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1b91e550-4b23-459f-b3bf-263d106a7473"), "seaweed salad", 2f },
                    { new Guid("7589deb4-f186-45ec-aa68-c6562503ed03"), "barnacle rings", 1.25f },
                    { new Guid("8d1f0413-e42e-4fbc-87ab-e5f6805fc28c"), "kelp fries", 1.25f },
                    { new Guid("c851712f-c663-4251-adbd-6820ca937f6c"), "oyster skins", 1.25f },
                    { new Guid("ec9eafdd-84dc-4f50-8c43-d286477b3792"), "coral bits", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0c04937e-8885-480a-beed-2cf946c70819"), "mustard", 0f },
                    { new Guid("209475f0-a4fa-4925-b7e3-a7aa5e6e474c"), "lettuce", 0.05f },
                    { new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c"), "patty", 1f },
                    { new Guid("782452eb-eede-4b4a-9053-4c79328adb0f"), "pickle", 0.05f },
                    { new Guid("7fa0bb75-4ee9-417b-93ad-b1947a728652"), "sea cheese", 0.25f },
                    { new Guid("89618a45-9bb3-45d0-b940-6ebcfd5cba3f"), "onion", 0.05f },
                    { new Guid("9673aade-f07b-478b-894b-dc4d2282c847"), "bun", 0.2f },
                    { new Guid("99349758-1a84-42de-a927-e549195f7975"), "tomato", 0.05f },
                    { new Guid("f741ce79-a158-40ac-bedc-d6473f441e46"), "ketchup", 0f },
                    { new Guid("fd1efc42-2c14-477b-908e-89363a258b3e"), "secret sauce", 0f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "1730a8a1-5239-4905-86b5-32a6fa628603" },
                    { "70498912-9de9-47fc-a5c3-7afd7b4431df", "67ce3d19-85fa-42e2-9379-5b91be295661" },
                    { "70498912-9de9-47fc-a5c3-7afd7b4431df", "aaecde13-1dee-4899-860a-07709cc7705c" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("4c688e47-3132-43df-a2cd-473dc689e450"), "3541 Anchor Way", "Eugene", "1730a8a1-5239-4905-86b5-32a6fa628603", "Krabs" },
                    { new Guid("9ceb4bba-c879-42c2-bd30-5f690006c40f"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" },
                    { new Guid("a6526e02-0dfa-4c08-b5d7-a16cc7c1109d"), "120 Conch Street", "Patrick", "fc73b74e-b3a6-4f1e-8a07-4faa1e9f580f", "Star" },
                    { new Guid("ade47e52-8e07-4736-8ab4-0aae2dbaa124"), "122 Conch Street", "Squidward", "aaecde13-1dee-4899-860a-07709cc7705c", "Tentacles" },
                    { new Guid("f8d5eec0-4e2d-49e9-8bbb-37e11e078efd"), "124 Conch Street", "SpongeBob", "67ce3d19-85fa-42e2-9379-5b91be295661", "SquarePants" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f"), new Guid("a6526e02-0dfa-4c08-b5d7-a16cc7c1109d"), new Guid("ade47e52-8e07-4736-8ab4-0aae2dbaa124"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43d1a26c-e9b3-497e-8341-cbff145ae482") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[] { new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity" },
                values: new object[] { new Guid("e27a7325-0635-4fe3-945c-877ba120b7e4"), new Guid("1645954e-43ec-4be6-9aba-1d262f8659df"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f"), 1 });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId" },
                values: new object[] { new Guid("c33b0b6b-ae7e-44c6-ae0e-8d13d4dd1fc5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f"), 1, new Guid("ec9eafdd-84dc-4f50-8c43-d286477b3792") });

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
