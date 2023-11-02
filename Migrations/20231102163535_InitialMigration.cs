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
                    { "305c1645-d050-45b9-b350-53f8d9eac0ff", null, "Employee", "employee" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", null, "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "154aa6e9-974c-48f1-84b5-e97f551b0c49", 0, "b282e4c1-65de-4907-9dff-1ad32c69c559", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEAJ9UgjU/dIKIzhgN/4L0X2OrsFfbmVzORE4SO/s/HgivSrX6uz51Hp7tMNPTSoU1w==", null, false, "0b0189ac-5c82-4505-ac19-17612ef03ac2", false, "stentacles" },
                    { "715a99dc-b008-49a3-9ae7-69771bf81903", 0, "3bf7af08-cdc1-4245-91a6-cdaa3eeed7f8", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBisv6aFx7AmnIzPXZE5hd7cIM5dRLg/y4fP/L7t1fd+o1CceeL8PAtvv0LGvApoAA==", null, false, "12e29fdf-d9a8-4733-9469-3e562a65bc58", false, "ssquarepants" },
                    { "81c6506d-3660-48e7-acf5-b8b1139b85d8", 0, "8fd84a0a-b542-4cab-8b29-7325fb9179e0", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEAXbWnq1P4XxPxPb0mbU3tzZEuz79fIyoX9Z/GfW9yZ3P4sG+JDz2QEC6G6MON5HNg==", null, false, "0fba595b-1ba3-4768-a65b-0494b92b7684", false, "ekrabs" },
                    { "bb5c3e28-80e3-4a16-bc62-688478488333", 0, "bd7273a7-c7a9-49ab-9252-55780e339abc", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBtJo1S26L21m9nwelB/J8CendhJrptGwj9KvqmQL/NrBkt26V3cSO+32zTMGTXCaw==", null, false, "dac99c3c-03a7-4607-9ec2-d2a37e49b046", false, "pstar" },
                    { "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", 0, "83dfdc4c-824d-412d-956f-1ab13683c5c0", "admina@strator.comx", false, false, null, null, null, "AQAAAAIAAYagAAAAEJZBrcs8Mg5S5CCsxviReId5M1f4w3TWZd9wrzHNzfyVaSFljRq9lL37mbBYPwtfkw==", null, false, "8952682b-db60-4bb9-9ff9-df683e6d0a3d", false, "Administrator" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, false, "krabby patty", null, null, 1 },
                    { new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, false, "double krabby patty", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("070bda98-ee93-4a01-953b-8c918bfa3fdf"), false, "red tide", 1f },
                    { new Guid("4d8fa0aa-5934-4826-91c8-99ffde6807fd"), false, "dr. kelp", 1f },
                    { new Guid("83e1c7b4-eeb6-44cd-b844-a907cf594c4c"), false, "water", 0.1f },
                    { new Guid("87304387-1d79-45d3-9842-187b4a13007c"), false, "diet dr. kelp", 1f },
                    { new Guid("b75132fa-4968-4034-8b6b-e3b0db5bca26"), false, "kelp shake", 1.5f },
                    { new Guid("f0414b6e-bac0-46f5-8951-e30b1ff63175"), false, "seafoam soda", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5cc9124e-1446-4c42-a028-8e9c183e468e"), "here" },
                    { new Guid("a946ff06-e506-48d9-b0d3-381fd4d2f7b5"), "togo" },
                    { new Guid("ee405ec9-bb64-4278-aafa-f410480710de"), "pickup" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("09ac8bb8-ff67-441c-814e-6a0730e19229"), false, "kelp fries", 1.25f },
                    { new Guid("89a2fdab-c960-4999-bb13-3667b88964cb"), false, "oyster skins", 1.25f },
                    { new Guid("a1e7c160-7276-497f-9835-59b7e692c3f6"), false, "seaweed salad", 2f },
                    { new Guid("a5bf2622-0af5-46e5-a0e5-c3a6f3ea9975"), false, "barnacle rings", 1.25f },
                    { new Guid("f1f98c88-4260-45e9-b758-7feb306bc849"), false, "coral bits", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("5e0c2ff4-d10a-4070-80d6-510a201f48e2"), false, "small", 0f, "sm" },
                    { new Guid("690499d6-ffcc-4f92-9c9e-2c78425fc535"), false, "large", 0.45f, "lg" },
                    { new Guid("a0893089-a608-4d1e-b807-b3980ab4f049"), false, "medium", 0.2f, "md" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("01c5611c-9213-409f-b603-9f93141cdd5d"), false, "pickle", 0.05f },
                    { new Guid("10138175-4d25-4900-a9fe-d2df2a24b1f3"), false, "bun", 0.2f },
                    { new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6"), false, "patty", 1f },
                    { new Guid("68595a1d-f146-4821-b0d2-13936391efcb"), false, "ketchup", 0f },
                    { new Guid("6d145a73-b647-4b51-a201-59cc1bc963e8"), false, "sea cheese", 0.25f },
                    { new Guid("98640696-a097-47f5-9ab7-741ea4c74279"), false, "mustard", 0f },
                    { new Guid("99000478-9859-4e05-b020-ca4ea2995f13"), false, "onion", 0.05f },
                    { new Guid("a5c0285a-1388-4efa-92d7-e8823d0b808b"), false, "secret sauce", 0f },
                    { new Guid("c336aa06-d49f-4339-9acb-c12640faccb4"), false, "lettuce", 0.05f },
                    { new Guid("e78b8b4e-6f8e-4a00-a603-856c8b95c841"), false, "tomato", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "305c1645-d050-45b9-b350-53f8d9eac0ff", "154aa6e9-974c-48f1-84b5-e97f551b0c49" },
                    { "305c1645-d050-45b9-b350-53f8d9eac0ff", "715a99dc-b008-49a3-9ae7-69771bf81903" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "81c6506d-3660-48e7-acf5-b8b1139b85d8" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("10bc56fb-4652-43d3-abb4-31899f02fe8c"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("a5c0285a-1388-4efa-92d7-e8823d0b808b") },
                    { new Guid("167c18c4-2ea6-4c69-a746-cab48bf025bb"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("6d145a73-b647-4b51-a201-59cc1bc963e8") },
                    { new Guid("1a8d25d7-a719-40ec-8415-637436197369"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("98640696-a097-47f5-9ab7-741ea4c74279") },
                    { new Guid("20e04dc8-ce1e-4cce-a21c-e0bd9b9a9421"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") },
                    { new Guid("21ce24cd-893d-4222-9f86-1dce67934c5a"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("68595a1d-f146-4821-b0d2-13936391efcb") },
                    { new Guid("269da126-a142-4363-a10a-33ba0d08d409"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("68595a1d-f146-4821-b0d2-13936391efcb") },
                    { new Guid("367259e8-7f00-413a-8bf7-6bfd3cf26699"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("6d145a73-b647-4b51-a201-59cc1bc963e8") },
                    { new Guid("577ce281-626c-4b4c-aa6c-52510cf91fe9"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("c336aa06-d49f-4339-9acb-c12640faccb4") },
                    { new Guid("6020b133-adbd-42fe-9c75-710bc14a7fb7"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("e78b8b4e-6f8e-4a00-a603-856c8b95c841") },
                    { new Guid("6ad3d12d-f7f2-4cae-aea4-767581f8435e"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("01c5611c-9213-409f-b603-9f93141cdd5d") },
                    { new Guid("6f3fb36e-dfe7-4bf0-8641-807d48a2e801"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") },
                    { new Guid("7e23918e-abc0-4904-bf70-aefe689e7b5b"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("10138175-4d25-4900-a9fe-d2df2a24b1f3") },
                    { new Guid("7e32357d-3ac8-48ec-8ee4-46846cf24778"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("99000478-9859-4e05-b020-ca4ea2995f13") },
                    { new Guid("858fed4d-a830-4475-a1f4-c9c5fc012774"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), false, new Guid("a5c0285a-1388-4efa-92d7-e8823d0b808b") },
                    { new Guid("91798c7e-a26d-424a-97cd-a306df7de696"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("e78b8b4e-6f8e-4a00-a603-856c8b95c841") },
                    { new Guid("918739b8-5073-4001-92a2-1b6dfdf0c209"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("10138175-4d25-4900-a9fe-d2df2a24b1f3") },
                    { new Guid("97543aa1-9750-418d-873a-2af70820ff36"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("01c5611c-9213-409f-b603-9f93141cdd5d") },
                    { new Guid("a99efd8b-67c7-4944-81ef-e9ba2aa57823"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("c336aa06-d49f-4339-9acb-c12640faccb4") },
                    { new Guid("b4926c52-3b3b-4b05-a27d-252cbe50e531"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("99000478-9859-4e05-b020-ca4ea2995f13") },
                    { new Guid("e2714079-9fb5-4a59-8c64-7359a9df377c"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("98640696-a097-47f5-9ab7-741ea4c74279") },
                    { new Guid("fb3b0fba-af13-46dc-868e-6fa42d98dc58"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("79234bc9-1c61-48d7-9f71-fd39b709f861"), new Guid("384e5161-01dc-442d-8c18-126437a6eab9"), -1f, false, "krabby patty combo" },
                    { new Guid("e1b6f175-66b2-4a94-bbcf-8b84a699f34e"), new Guid("a58ddd25-9d3c-4680-9987-2f40b8a8eb07"), -1.25f, false, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("0819b90b-97b5-4b52-b901-ac02d54e0938"), "3541 Anchor Way", "Eugene", "81c6506d-3660-48e7-acf5-b8b1139b85d8", "Krabs" },
                    { new Guid("426541e2-b346-47e4-8134-43f3f9f497b7"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" },
                    { new Guid("5d30765e-3935-426b-8e36-54b89c4c837b"), "120 Conch Street", "Patrick", "bb5c3e28-80e3-4a16-bc62-688478488333", "Star" },
                    { new Guid("874c4147-2c7e-4214-8e63-855d3dc01d42"), "122 Conch Street", "Squidward", "154aa6e9-974c-48f1-84b5-e97f551b0c49", "Tentacles" },
                    { new Guid("bc930ebd-6b58-48c3-bfa2-5bc53bbf7599"), "124 Conch Street", "SpongeBob", "715a99dc-b008-49a3-9ae7-69771bf81903", "SquarePants" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), new Guid("5d30765e-3935-426b-8e36-54b89c4c837b"), new Guid("874c4147-2c7e-4214-8e63-855d3dc01d42"), new DateTime(2023, 11, 2, 11, 35, 35, 231, DateTimeKind.Local).AddTicks(7561), new Guid("5cc9124e-1446-4c42-a028-8e9c183e468e") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, false, null, null, new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 2 });

            migrationBuilder.InsertData(
                table: "OrderCombos",
                columns: new[] { "Id", "ComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("fc814dcb-f8e5-459f-95af-62d692332d66"), new Guid("79234bc9-1c61-48d7-9f71-fd39b709f861"), new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("171c92c6-653a-4e26-89d0-e84b2fb3d15f"), new Guid("070bda98-ee93-4a01-953b-8c918bfa3fdf"), false, null, new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1, new Guid("a0893089-a608-4d1e-b807-b3980ab4f049") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("37478a8d-ef7a-485a-8973-cad7a767aa9a"), false, null, new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1, new Guid("f1f98c88-4260-45e9-b758-7feb306bc849"), new Guid("690499d6-ffcc-4f92-9c9e-2c78425fc535") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("1f5d7497-3943-461a-9c87-f7bdc575129a"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("01c5611c-9213-409f-b603-9f93141cdd5d") },
                    { new Guid("2657a653-c22a-42a9-8e1e-e8b14218e259"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("c336aa06-d49f-4339-9acb-c12640faccb4") },
                    { new Guid("2983e0f5-dc02-47d3-877b-927890f186c7"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("98640696-a097-47f5-9ab7-741ea4c74279") },
                    { new Guid("426ae32d-e25a-4ab9-a39e-3000b0596313"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("68595a1d-f146-4821-b0d2-13936391efcb") },
                    { new Guid("4d195075-a252-4a3e-9ecb-18f2d1352372"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("99000478-9859-4e05-b020-ca4ea2995f13") },
                    { new Guid("59376eb6-9834-4c8a-b116-8e1f4d0d2c89"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("10138175-4d25-4900-a9fe-d2df2a24b1f3") },
                    { new Guid("69f8c4f4-8f8e-48ed-8adf-ff1c279ed03e"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") },
                    { new Guid("91b36c36-11fb-446e-ad5b-509515ab17d2"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") },
                    { new Guid("9390223a-98f3-454d-b8b5-ed59d45045a8"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("a5c0285a-1388-4efa-92d7-e8823d0b808b") },
                    { new Guid("a223e6c4-7c74-4658-b250-d785ca9357cc"), new Guid("db37221a-a447-49f9-b71b-1e43bcada3ce"), false, new Guid("e78b8b4e-6f8e-4a00-a603-856c8b95c841") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("331c99d1-dfbf-4de0-b618-0f901732d45c"), false, true, null, new Guid("fc814dcb-f8e5-459f-95af-62d692332d66"), new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("e33b38bb-da1c-4a67-9750-213fddddc306"), new Guid("4d8fa0aa-5934-4826-91c8-99ffde6807fd"), true, new Guid("fc814dcb-f8e5-459f-95af-62d692332d66"), new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1, new Guid("a0893089-a608-4d1e-b807-b3980ab4f049") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("a6e1e377-739d-4ff5-85c2-ddb559d19f29"), true, new Guid("fc814dcb-f8e5-459f-95af-62d692332d66"), new Guid("eb027aa2-b77e-420b-8dae-0465f1928239"), 1, new Guid("09ac8bb8-ff67-441c-814e-6a0730e19229"), new Guid("690499d6-ffcc-4f92-9c9e-2c78425fc535") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("7cea09d6-7121-4a96-ae9e-464038255372"), new Guid("331c99d1-dfbf-4de0-b618-0f901732d45c"), false, new Guid("98640696-a097-47f5-9ab7-741ea4c74279") },
                    { new Guid("ac9a5923-2e03-4518-b444-ff21f39827f1"), new Guid("331c99d1-dfbf-4de0-b618-0f901732d45c"), false, new Guid("68595a1d-f146-4821-b0d2-13936391efcb") },
                    { new Guid("e4f8c85d-cca4-4793-9f71-8f680a9866fa"), new Guid("331c99d1-dfbf-4de0-b618-0f901732d45c"), false, new Guid("4a99cea4-95bb-49b1-83ac-a909b3334fb6") },
                    { new Guid("fef70a7d-7562-474c-b3cc-40de74007127"), new Guid("331c99d1-dfbf-4de0-b618-0f901732d45c"), false, new Guid("10138175-4d25-4900-a9fe-d2df2a24b1f3") }
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
