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
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", null, "Employee", "employee" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11c3300a-8733-4a71-90ae-8136545d3722", 0, "23e3553a-44e7-4802-a07a-c537d354f883", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEC7pkbmW+Gea2JVvTUWFtNzsfYWL3D5/ar7GBOQW4cAci9HqaylrJ560SOye9recKw==", null, false, "257417cf-04a9-4f57-ad53-991d6b082baf", false, "ekrabs" },
                    { "26ee909a-154f-4cb1-b98c-d812e600c2e6", 0, "b987b376-ce24-4b52-aa6d-cf3e69d100af", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEPN5nc/HzloVxWjvAKt8GpkzmCTuqmI8DwERzygmYMzcpNF1IvU78FMooOpRjlJ/oQ==", null, false, "9194d874-35e2-4d62-8253-17ec2cf74cb9", false, "ssquarepants" },
                    { "31e844bd-bfaa-4991-a837-c986207d12f8", 0, "e48f66a9-d7fe-4ebb-a0cb-a45b618c6361", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHvggcyfwNk3EMMonvnwg0Eh3TN4nVHVC6H818h9jThRxdCUX/mw3weswF0tBF2bug==", null, false, "f54413ef-bab3-4535-b7d3-473e97e820ec", false, "stentacles" },
                    { "c1e902ba-dbce-4bea-b9b7-a6ffdba7ce36", 0, "e97ff079-35e0-438f-ac00-651eebe85d4a", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAED4KFd2m2t0hEuO5KxLIxK9441nEerPBS4bN3rPAcwUUpj9hqFlCB1JEIzJ+Jk8exg==", null, false, "536ec80f-a462-4523-884f-b639663c0819", false, "pstar" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "0d30f273-7de6-4402-acb4-3303c770f30c", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAECNOYw5wWHWfdZ1jU0CqBTT2RUX7nVKFz1C7x7JxfgwD2sx7G7fEi3rHYn1yIQXUmA==", null, false, "31549cec-a262-4f03-b9e2-f96a78c95fad", false, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, false, "double krabby patty", null, null, 1 },
                    { new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, false, "krabby patty", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("132a8365-21c4-4f89-9fe7-5a04dc8e0498"), false, "seafoam soda", 1f },
                    { new Guid("3a5d4ff3-47f7-4ce4-9395-360304dc754c"), false, "dr. kelp", 1f },
                    { new Guid("c144232a-11a1-4276-9608-b4df709f2654"), false, "red tide", 1f },
                    { new Guid("c5783a22-d9f2-4497-bca9-b3ec8a623913"), false, "water", 0.1f },
                    { new Guid("e417849c-0d77-4a4f-9674-2a9b10a8b359"), false, "diet dr. kelp", 1f },
                    { new Guid("ee2391c7-c929-48fd-822e-6b5788ed186c"), false, "kelp shake", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1e60a8f7-11de-4005-83ba-ad52659a3309"), "pickup" },
                    { new Guid("98bb1597-5519-487d-a043-65dfadfc3273"), "togo" },
                    { new Guid("cb8b2468-20fb-4ec6-920f-831cc5617cb5"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("5bb61c67-aafe-4c1a-b471-80070df642d4"), false, "oyster skins", 1.25f },
                    { new Guid("7fd40224-091e-4360-86ec-4312b565adf2"), false, "kelp fries", 1.25f },
                    { new Guid("96ab5baa-a1af-44ec-9c93-5ce45c1733a9"), false, "seaweed salad", 2f },
                    { new Guid("bf8bbbd5-142c-4140-8c10-1e02d992ae95"), false, "barnacle rings", 1.25f },
                    { new Guid("f8e7d283-cdae-4835-b3db-ce06bb89eab2"), false, "coral bits", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("60c0635f-4036-40cb-9228-d9dd978b31eb"), false, "large", 0.45f, "lg" },
                    { new Guid("725f9403-fe15-4844-b64a-2a59b166232b"), false, "medium", 0.2f, "md" },
                    { new Guid("726704d8-3efb-4cf8-a966-fc4699b68f85"), false, "small", 0f, "sm" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("01aecf42-b275-439f-844e-3fe8f9a5c581"), false, "sea cheese", 0.25f },
                    { new Guid("0f0c3ac1-eb05-419f-8a2d-79075ae3cfa9"), false, "lettuce", 0.05f },
                    { new Guid("0f535105-ec3f-4775-855d-777ea015d968"), false, "mustard", 0f },
                    { new Guid("18d26333-b93a-4fec-b635-132766a4a954"), false, "ketchup", 0f },
                    { new Guid("51cd90c8-9d5e-40f1-89d4-cc73593801ca"), false, "tomato", 0.05f },
                    { new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5"), false, "bun", 0.2f },
                    { new Guid("c9d4a9f6-aade-4152-8bf9-ef0ecb715c78"), false, "pickle", 0.05f },
                    { new Guid("d99d2f3d-5c9d-4421-995d-4220d9ef87f7"), false, "onion", 0.05f },
                    { new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481"), false, "patty", 1f },
                    { new Guid("ec08ce80-a177-4af7-9b8b-12efc89b710c"), false, "secret sauce", 0f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "11c3300a-8733-4a71-90ae-8136545d3722" },
                    { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "26ee909a-154f-4cb1-b98c-d812e600c2e6" },
                    { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "31e844bd-bfaa-4991-a837-c986207d12f8" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0040169f-66d8-4d62-b7b8-89930979731e"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("ec08ce80-a177-4af7-9b8b-12efc89b710c") },
                    { new Guid("03ddcddd-2a9b-4e3a-9d8a-c683e2ac957d"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("51cd90c8-9d5e-40f1-89d4-cc73593801ca") },
                    { new Guid("0ff9fcae-c951-41f9-8964-ee698f8042f3"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("0f0c3ac1-eb05-419f-8a2d-79075ae3cfa9") },
                    { new Guid("2e86b2d3-4a5d-48d1-92f0-1e1847badb8d"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("0f0c3ac1-eb05-419f-8a2d-79075ae3cfa9") },
                    { new Guid("35bd775e-75e1-4256-9ccf-aa89cf402e9e"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("18d26333-b93a-4fec-b635-132766a4a954") },
                    { new Guid("447924fb-d759-44e0-90b7-46c86949719e"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("d99d2f3d-5c9d-4421-995d-4220d9ef87f7") },
                    { new Guid("5007872b-e704-4168-ac4a-0490fca2b0d3"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("c9d4a9f6-aade-4152-8bf9-ef0ecb715c78") },
                    { new Guid("57d80b1d-0536-4501-bd1e-a16bf5402ff2"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("c9d4a9f6-aade-4152-8bf9-ef0ecb715c78") },
                    { new Guid("6d7e6c9c-9b91-433f-9bf4-a0ba58900b74"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("01aecf42-b275-439f-844e-3fe8f9a5c581") },
                    { new Guid("73ae4af4-fad5-416f-ab37-0a0429af58c0"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5") },
                    { new Guid("78e67cf0-62cb-4778-89c0-f886f247ded8"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("ec08ce80-a177-4af7-9b8b-12efc89b710c") },
                    { new Guid("9882be71-6325-42e1-9a22-9eb673ba8d6b"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("abf541c4-54f2-48cc-af48-72934ad56007"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("b27686ff-837f-4700-b50a-4b89197829a8"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5") },
                    { new Guid("bba9d335-cdec-4613-b62c-6f03f76b39f8"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("51cd90c8-9d5e-40f1-89d4-cc73593801ca") },
                    { new Guid("be440dc1-be24-4b58-b600-8d9f6e1bd206"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("01aecf42-b275-439f-844e-3fe8f9a5c581") },
                    { new Guid("c7439c02-c77f-430b-b859-19b4788e9c43"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("18d26333-b93a-4fec-b635-132766a4a954") },
                    { new Guid("ca0e1a92-14c8-42e3-8868-15f03a9abdcc"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("0f535105-ec3f-4775-855d-777ea015d968") },
                    { new Guid("ee2aa7e5-3075-44f8-8696-3ceb8ecec6bc"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), false, new Guid("0f535105-ec3f-4775-855d-777ea015d968") },
                    { new Guid("f4bc30f8-e4a0-4b20-bb61-b5d26a9319c1"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("fe4bbe2c-bf98-4b19-8299-7160563c145f"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), false, new Guid("d99d2f3d-5c9d-4421-995d-4220d9ef87f7") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1ceda4ef-f547-4fb4-8d3e-43dc4dfe3d50"), new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"), -1f, false, "krabby patty combo" },
                    { new Guid("28192288-b6cc-4099-8fc3-5baad590f20e"), new Guid("62bc247d-f535-4802-9098-5250f4508c7a"), -1.25f, false, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("0123d485-450b-4b30-9f67-a054feeb1a22"), "3541 Anchor Way", "Eugene", "11c3300a-8733-4a71-90ae-8136545d3722", "Krabs" },
                    { new Guid("35d9771d-f425-4032-9d3d-9fcb9a6c6a8c"), "124 Conch Street", "SpongeBob", "26ee909a-154f-4cb1-b98c-d812e600c2e6", "SquarePants" },
                    { new Guid("a0a87211-957d-4c04-a9b9-e939b352ad38"), "122 Conch Street", "Squidward", "31e844bd-bfaa-4991-a837-c986207d12f8", "Tentacles" },
                    { new Guid("a7700b2a-0a86-422e-a8fd-13757804d63d"), "120 Conch Street", "Patrick", "c1e902ba-dbce-4bea-b9b7-a6ffdba7ce36", "Star" },
                    { new Guid("a960e6a6-b846-4504-9b99-63a497243d43"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), new Guid("a7700b2a-0a86-422e-a8fd-13757804d63d"), new Guid("a0a87211-957d-4c04-a9b9-e939b352ad38"), new DateTime(2023, 11, 2, 9, 57, 59, 474, DateTimeKind.Local).AddTicks(729), new Guid("cb8b2468-20fb-4ec6-920f-831cc5617cb5") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, false, null, null, new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 2 });

            migrationBuilder.InsertData(
                table: "OrderCombos",
                columns: new[] { "Id", "ComboId", "OrderId" },
                values: new object[] { new Guid("da302348-b66f-49d3-9f70-df565cea5979"), new Guid("1ceda4ef-f547-4fb4-8d3e-43dc4dfe3d50"), new Guid("01c62878-6406-4bff-b412-892bf759c3cb") });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("687e9001-9d46-4d77-9568-ee5bfbb6bc9a"), new Guid("c144232a-11a1-4276-9608-b4df709f2654"), false, null, new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 1, new Guid("725f9403-fe15-4844-b64a-2a59b166232b") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("edc402c5-7da5-44e3-9a31-96c91a24c6c3"), false, null, new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 1, new Guid("f8e7d283-cdae-4835-b3db-ce06bb89eab2"), new Guid("60c0635f-4036-40cb-9228-d9dd978b31eb") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0748ffe0-02d4-427e-b6b7-3605d2ae9a33"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("c9d4a9f6-aade-4152-8bf9-ef0ecb715c78") },
                    { new Guid("0e0c9e75-758f-434e-9ed7-e365b1a1e1e9"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("29c2736a-82aa-4724-9479-25c5b13daa57"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("0f0c3ac1-eb05-419f-8a2d-79075ae3cfa9") },
                    { new Guid("4228a80a-4fa3-441f-b313-a3012f69be6e"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("51cd90c8-9d5e-40f1-89d4-cc73593801ca") },
                    { new Guid("6ca8d8d4-91cc-408c-a38f-363557bdc914"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("ec08ce80-a177-4af7-9b8b-12efc89b710c") },
                    { new Guid("901defbf-9170-4428-ad56-9eb2a1f72d4c"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("18d26333-b93a-4fec-b635-132766a4a954") },
                    { new Guid("a0b05609-67e3-4034-adfe-3aa2605fffde"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("b02e44e2-473e-4ee9-bdab-43aa490784f4"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("d99d2f3d-5c9d-4421-995d-4220d9ef87f7") },
                    { new Guid("ce917225-9d6e-4c34-99a7-afb520699411"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("0f535105-ec3f-4775-855d-777ea015d968") },
                    { new Guid("dff53f96-fb7f-4fbf-962c-a8bd478b6fba"), new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"), false, new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("8df72178-8610-458d-951b-22660fb59a78"), false, true, null, new Guid("da302348-b66f-49d3-9f70-df565cea5979"), new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("e45d1bdd-6f04-4da9-a3be-adb588fa1017"), new Guid("3a5d4ff3-47f7-4ce4-9395-360304dc754c"), true, new Guid("da302348-b66f-49d3-9f70-df565cea5979"), new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 1, new Guid("725f9403-fe15-4844-b64a-2a59b166232b") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("0d5b9984-ec10-4f2f-9c69-58c30af11497"), true, new Guid("da302348-b66f-49d3-9f70-df565cea5979"), new Guid("01c62878-6406-4bff-b412-892bf759c3cb"), 1, new Guid("7fd40224-091e-4360-86ec-4312b565adf2"), new Guid("60c0635f-4036-40cb-9228-d9dd978b31eb") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("01181cc7-ba9c-4a07-819a-cda33e5be0e5"), new Guid("8df72178-8610-458d-951b-22660fb59a78"), false, new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481") },
                    { new Guid("71cd43bd-5d2a-4d89-850a-d7bbd8ee6861"), new Guid("8df72178-8610-458d-951b-22660fb59a78"), false, new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5") },
                    { new Guid("8a070f04-714e-499d-a8ed-097921108d4d"), new Guid("8df72178-8610-458d-951b-22660fb59a78"), false, new Guid("18d26333-b93a-4fec-b635-132766a4a954") },
                    { new Guid("9882ebc2-8ace-48cc-87fe-4aae7873637e"), new Guid("8df72178-8610-458d-951b-22660fb59a78"), false, new Guid("0f535105-ec3f-4775-855d-777ea015d968") }
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
                name: "Sizes");

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
