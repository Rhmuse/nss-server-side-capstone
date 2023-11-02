using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class quantityOnOrderCombo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "11c3300a-8733-4a71-90ae-8136545d3722" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "26ee909a-154f-4cb1-b98c-d812e600c2e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "31e844bd-bfaa-4991-a837-c986207d12f8" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0040169f-66d8-4d62-b7b8-89930979731e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("01181cc7-ba9c-4a07-819a-cda33e5be0e5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("03ddcddd-2a9b-4e3a-9d8a-c683e2ac957d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0748ffe0-02d4-427e-b6b7-3605d2ae9a33"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0e0c9e75-758f-434e-9ed7-e365b1a1e1e9"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0ff9fcae-c951-41f9-8964-ee698f8042f3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("29c2736a-82aa-4724-9479-25c5b13daa57"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2e86b2d3-4a5d-48d1-92f0-1e1847badb8d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("35bd775e-75e1-4256-9ccf-aa89cf402e9e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4228a80a-4fa3-441f-b313-a3012f69be6e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("447924fb-d759-44e0-90b7-46c86949719e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("5007872b-e704-4168-ac4a-0490fca2b0d3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("57d80b1d-0536-4501-bd1e-a16bf5402ff2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6ca8d8d4-91cc-408c-a38f-363557bdc914"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6d7e6c9c-9b91-433f-9bf4-a0ba58900b74"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("71cd43bd-5d2a-4d89-850a-d7bbd8ee6861"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("73ae4af4-fad5-416f-ab37-0a0429af58c0"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("78e67cf0-62cb-4778-89c0-f886f247ded8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8a070f04-714e-499d-a8ed-097921108d4d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("901defbf-9170-4428-ad56-9eb2a1f72d4c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9882be71-6325-42e1-9a22-9eb673ba8d6b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9882ebc2-8ace-48cc-87fe-4aae7873637e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a0b05609-67e3-4034-adfe-3aa2605fffde"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("abf541c4-54f2-48cc-af48-72934ad56007"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b02e44e2-473e-4ee9-bdab-43aa490784f4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b27686ff-837f-4700-b50a-4b89197829a8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("bba9d335-cdec-4613-b62c-6f03f76b39f8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("be440dc1-be24-4b58-b600-8d9f6e1bd206"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c7439c02-c77f-430b-b859-19b4788e9c43"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ca0e1a92-14c8-42e3-8868-15f03a9abdcc"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ce917225-9d6e-4c34-99a7-afb520699411"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("dff53f96-fb7f-4fbf-962c-a8bd478b6fba"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ee2aa7e5-3075-44f8-8696-3ceb8ecec6bc"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f4bc30f8-e4a0-4b20-bb61-b5d26a9319c1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fe4bbe2c-bf98-4b19-8299-7160563c145f"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("1ceda4ef-f547-4fb4-8d3e-43dc4dfe3d50"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("28192288-b6cc-4099-8fc3-5baad590f20e"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("132a8365-21c4-4f89-9fe7-5a04dc8e0498"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("c5783a22-d9f2-4497-bca9-b3ec8a623913"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("e417849c-0d77-4a4f-9674-2a9b10a8b359"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("ee2391c7-c929-48fd-822e-6b5788ed186c"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("687e9001-9d46-4d77-9568-ee5bfbb6bc9a"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("e45d1bdd-6f04-4da9-a3be-adb588fa1017"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("0d5b9984-ec10-4f2f-9c69-58c30af11497"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("edc402c5-7da5-44e3-9a31-96c91a24c6c3"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("1e60a8f7-11de-4005-83ba-ad52659a3309"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("98bb1597-5519-487d-a043-65dfadfc3273"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("5bb61c67-aafe-4c1a-b471-80070df642d4"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("96ab5baa-a1af-44ec-9c93-5ce45c1733a9"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("bf8bbbd5-142c-4140-8c10-1e02d992ae95"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("60c0635f-4036-40cb-9228-d9dd978b31eb"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("725f9403-fe15-4844-b64a-2a59b166232b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("726704d8-3efb-4cf8-a966-fc4699b68f85"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("0123d485-450b-4b30-9f67-a054feeb1a22"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("35d9771d-f425-4032-9d3d-9fcb9a6c6a8c"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a960e6a6-b846-4504-9b99-63a497243d43"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7463fc2a-50d4-4fef-aef5-d17538ccb6d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11c3300a-8733-4a71-90ae-8136545d3722");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26ee909a-154f-4cb1-b98c-d812e600c2e6");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("62bc247d-f535-4802-9098-5250f4508c7a"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("8df72178-8610-458d-951b-22660fb59a78"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("bab8278d-8128-4e46-8286-ebcfe8697688"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("bacce980-51f5-49cb-b50d-aa3c0eb5749a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("3a5d4ff3-47f7-4ce4-9395-360304dc754c"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("c144232a-11a1-4276-9608-b4df709f2654"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("7fd40224-091e-4360-86ec-4312b565adf2"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("f8e7d283-cdae-4835-b3db-ce06bb89eab2"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("01aecf42-b275-439f-844e-3fe8f9a5c581"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0f0c3ac1-eb05-419f-8a2d-79075ae3cfa9"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0f535105-ec3f-4775-855d-777ea015d968"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("18d26333-b93a-4fec-b635-132766a4a954"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("51cd90c8-9d5e-40f1-89d4-cc73593801ca"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("568cde3e-7e01-4ace-9bb4-434fa6068fd5"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("c9d4a9f6-aade-4152-8bf9-ef0ecb715c78"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("d99d2f3d-5c9d-4421-995d-4220d9ef87f7"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("df08ec40-e45e-42ce-8a4f-f65855e6c481"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("ec08ce80-a177-4af7-9b8b-12efc89b710c"));

            migrationBuilder.DeleteData(
                table: "OrderCombos",
                keyColumn: "Id",
                keyValue: new Guid("da302348-b66f-49d3-9f70-df565cea5979"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("01c62878-6406-4bff-b412-892bf759c3cb"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("cb8b2468-20fb-4ec6-920f-831cc5617cb5"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a0a87211-957d-4c04-a9b9-e939b352ad38"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a7700b2a-0a86-422e-a8fd-13757804d63d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31e844bd-bfaa-4991-a837-c986207d12f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c1e902ba-dbce-4bea-b9b7-a6ffdba7ce36");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderCombos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "129487e7-87d4-463b-b789-843918ac3f2e", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "986d0672-bb49-497e-8e19-c01af8a18a9c", "AQAAAAIAAYagAAAAEBPgc43QdAWbcotFOopa7s8DJj36W2/DzUH1adAcqDaILkN7Qzc5bfKfRYbHBnf4DQ==", "94d58bb3-b9ef-4989-a24f-d49a669c1d39" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24ceef3f-0e65-40b8-b8f6-410b3f6b7265", 0, "58c4f36d-2266-40aa-9766-8ac21172cc60", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIewWAu6CYUdgLedqkX55DmmD2eTudVuF2WO3VmKgMpFjnPaRZtT2IRSt3cB61U9kg==", null, false, "2adaa6c7-7f7d-40ab-83df-ac6ce20b0794", false, "ssquarepants" },
                    { "9cd5c5bd-b28a-4992-ae75-e87083c3c74a", 0, "a7ba70de-8b69-47b7-bfa7-5c476041642b", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEE0HIhs96961Qp0+4OePDf+keYqs07dRemQX305R3L1E4cZTffwoKATNV+wV3SaQaw==", null, false, "6e26fad8-30fc-41da-9a73-389dc3ffc0c3", false, "ekrabs" },
                    { "a951093b-fa02-4609-a877-d1f9658445cc", 0, "5d15597c-884f-493c-a36e-8f64c4fd6623", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKtSbV/tBxksqQ0l7T0TevrQ9jTBTpvvGDX73aq38nT9TVWIdg5hB+Ac81TDKBi48A==", null, false, "12f34006-f08d-42c9-aa66-0272d0eccc7e", false, "stentacles" },
                    { "c7a73dd3-c874-4587-be77-80161a4cea88", 0, "9952ca6a-4baa-4d91-a559-f2417052bdbb", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMSKoIi5fH98Hy7LVnL0c3Lsmwq8IVoa5Mm2AFYMRhqfjs+UU+PXXqHWe6BsyyP2sQ==", null, false, "71fd9f96-5895-4984-b0ec-c94d4b10b3ae", false, "pstar" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, false, "double krabby patty", null, null, 1 },
                    { new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, false, "krabby patty", null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1492c598-9bd6-4dba-86fc-c5e71c8a7248"), false, "diet dr. kelp", 1f },
                    { new Guid("3fe4669f-fd11-416a-8ffe-41e9016e1c81"), false, "seafoam soda", 1f },
                    { new Guid("891ac059-a0a5-41b0-a824-29938804dbeb"), false, "kelp shake", 1.5f },
                    { new Guid("abff2c50-3cba-49b3-9309-36b1404a411c"), false, "red tide", 1f },
                    { new Guid("ba57c9fc-fb84-459f-90b1-8380cf56326a"), false, "dr. kelp", 1f },
                    { new Guid("f34313a1-7d24-48a9-bb58-4b3d7a69f11a"), false, "water", 0.1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10c74722-5f4b-43c8-8e45-10f7fa6e1337"), "pickup" },
                    { new Guid("2a2c5b0e-960e-4c19-857f-7e9665a2cc0d"), "here" },
                    { new Guid("9f1eb783-0672-496c-addf-20e1b3e0f4b5"), "togo" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("012f0feb-3296-44ea-a4b1-576d113b1340"), false, "kelp fries", 1.25f },
                    { new Guid("37a50b38-79d1-49ec-8f28-96f36b2ad42b"), false, "seaweed salad", 2f },
                    { new Guid("429029e2-e30f-4561-a6e3-7bd4a2041b37"), false, "oyster skins", 1.25f },
                    { new Guid("5ea5dca4-dc78-440f-bd4c-429385ef51bb"), false, "coral bits", 1.25f },
                    { new Guid("cfbc12c7-11aa-44a1-ae21-8009ea16b079"), false, "barnacle rings", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("8b3db8eb-5222-4e03-98c5-1e5f9dd1bce3"), false, "large", 0.45f, "lg" },
                    { new Guid("95b1d883-384b-4aba-a173-6752561119bf"), false, "medium", 0.2f, "md" },
                    { new Guid("d2279d7a-4f23-4859-be0e-595a7d4bbf6e"), false, "small", 0f, "sm" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0b24f943-112f-4581-9012-66c22ebc78e4"), false, "mustard", 0f },
                    { new Guid("5270cf4d-0a22-49be-b958-5e1459fa291b"), false, "onion", 0.05f },
                    { new Guid("6ed7f3f2-a11e-4564-bd0a-5577a83a49a8"), false, "secret sauce", 0f },
                    { new Guid("7072d592-d83e-4370-8231-968557a1a7fa"), false, "bun", 0.2f },
                    { new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082"), false, "ketchup", 0f },
                    { new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9"), false, "patty", 1f },
                    { new Guid("a605c9b7-baa8-4163-b25f-8de28dc5992c"), false, "lettuce", 0.05f },
                    { new Guid("c19344f4-80ff-485b-b006-efbce38de108"), false, "tomato", 0.05f },
                    { new Guid("eb1a74ee-a261-49ec-bd43-3a23ef5fc549"), false, "sea cheese", 0.25f },
                    { new Guid("fd0e3766-f26d-4465-a808-b4b262045b9a"), false, "pickle", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("6d74b409-598a-422a-b8a0-04dc96672e02"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "129487e7-87d4-463b-b789-843918ac3f2e", "24ceef3f-0e65-40b8-b8f6-410b3f6b7265" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "9cd5c5bd-b28a-4992-ae75-e87083c3c74a" },
                    { "129487e7-87d4-463b-b789-843918ac3f2e", "a951093b-fa02-4609-a877-d1f9658445cc" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("094c0bc3-0103-4645-9108-345cd3b13edd"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("7072d592-d83e-4370-8231-968557a1a7fa") },
                    { new Guid("10b4ea7d-933f-4efa-a4e5-2d263b1dda1e"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("a605c9b7-baa8-4163-b25f-8de28dc5992c") },
                    { new Guid("1bc24ec0-9159-4f62-b233-9afeba8815f4"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("fd0e3766-f26d-4465-a808-b4b262045b9a") },
                    { new Guid("249fdd4b-7842-4968-acb7-e4adcb42661a"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("305309f9-4e18-4150-95d2-d2d53fddd00e"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("6ed7f3f2-a11e-4564-bd0a-5577a83a49a8") },
                    { new Guid("399bd453-638a-4b2e-b42c-dccd9515318b"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("eb1a74ee-a261-49ec-bd43-3a23ef5fc549") },
                    { new Guid("3ae8c5f5-e3ac-4c60-addc-657f6b259bf9"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("eb1a74ee-a261-49ec-bd43-3a23ef5fc549") },
                    { new Guid("52add5aa-82a2-407d-b1f8-1cd5553b2287"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("0b24f943-112f-4581-9012-66c22ebc78e4") },
                    { new Guid("6ec9868d-e47b-43ad-b91c-57410a68a50b"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("7072d592-d83e-4370-8231-968557a1a7fa") },
                    { new Guid("83b612b2-2bb9-483a-8137-1712696e3dba"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("c19344f4-80ff-485b-b006-efbce38de108") },
                    { new Guid("8ce87eee-5b0c-4af8-b127-926d3eaf7fe8"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082") },
                    { new Guid("946411a6-58fb-4857-9742-b2edf4f24c61"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082") },
                    { new Guid("9b0b2b72-e770-4de8-9f99-5a201f0a9b4a"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("a2201fc7-b570-4e8e-8ee7-2af54bc6fc6b"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("5270cf4d-0a22-49be-b958-5e1459fa291b") },
                    { new Guid("a2a705a0-2a1d-4d39-afb7-05da6b54f9b5"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("fd0e3766-f26d-4465-a808-b4b262045b9a") },
                    { new Guid("bc7ff02c-3805-4902-b099-18f57aec734d"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("bcde5458-2eab-44c4-a0c8-b100a0cdbcce"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), false, new Guid("5270cf4d-0a22-49be-b958-5e1459fa291b") },
                    { new Guid("c1cfa02b-bee7-4d82-9fdf-b91a1287fcaf"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("c19344f4-80ff-485b-b006-efbce38de108") },
                    { new Guid("dbecd615-633b-4552-bb34-4df2f51e284c"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("a605c9b7-baa8-4163-b25f-8de28dc5992c") },
                    { new Guid("e9106812-a372-4695-813f-eb7764aed5c7"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("6ed7f3f2-a11e-4564-bd0a-5577a83a49a8") },
                    { new Guid("ece77484-6127-4800-bca9-22430cebfd7a"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), false, new Guid("0b24f943-112f-4581-9012-66c22ebc78e4") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("1c34d729-1fa5-48a5-b906-b3655574584c"), new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"), -1f, false, "krabby patty combo" },
                    { new Guid("274c5aa5-e7b6-4cca-a393-c3bf04940566"), new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"), -1.25f, false, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("104134bb-0f8b-4411-b05b-177cd9eb2763"), "124 Conch Street", "SpongeBob", "24ceef3f-0e65-40b8-b8f6-410b3f6b7265", "SquarePants" },
                    { new Guid("2f88f2d7-c6a2-409e-87af-cfd06325a611"), "3541 Anchor Way", "Eugene", "9cd5c5bd-b28a-4992-ae75-e87083c3c74a", "Krabs" },
                    { new Guid("456b5e22-26e6-4200-9ecf-9a036b938e43"), "120 Conch Street", "Patrick", "c7a73dd3-c874-4587-be77-80161a4cea88", "Star" },
                    { new Guid("998bcb41-c23d-4f6a-853b-69313960a3f0"), "122 Conch Street", "Squidward", "a951093b-fa02-4609-a877-d1f9658445cc", "Tentacles" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), new Guid("456b5e22-26e6-4200-9ecf-9a036b938e43"), new Guid("998bcb41-c23d-4f6a-853b-69313960a3f0"), new DateTime(2023, 11, 2, 10, 31, 49, 500, DateTimeKind.Local).AddTicks(1246), new Guid("2a2c5b0e-960e-4c19-857f-7e9665a2cc0d") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, false, null, null, new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 2 });

            migrationBuilder.InsertData(
                table: "OrderCombos",
                columns: new[] { "Id", "ComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("bffea8fd-0443-4688-84c6-72b047458059"), new Guid("1c34d729-1fa5-48a5-b906-b3655574584c"), new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("51316ef7-729b-41a8-82d1-db3bb7d41b56"), new Guid("abff2c50-3cba-49b3-9309-36b1404a411c"), false, null, new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1, new Guid("95b1d883-384b-4aba-a173-6752561119bf") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("4a91b352-0da2-4419-b829-785d00618b79"), false, null, new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1, new Guid("5ea5dca4-dc78-440f-bd4c-429385ef51bb"), new Guid("8b3db8eb-5222-4e03-98c5-1e5f9dd1bce3") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("1ee38d6b-569e-4fb6-81fc-121655bbc0bf"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("2560c2a8-964d-467d-8206-019cdf05aa03"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("5270cf4d-0a22-49be-b958-5e1459fa291b") },
                    { new Guid("30b828ce-4553-46e9-843e-f3a7a0650ff8"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082") },
                    { new Guid("3eeb6bb0-00ab-485d-8765-741d5d4bc457"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("0b24f943-112f-4581-9012-66c22ebc78e4") },
                    { new Guid("573e35bb-366a-47df-a9ed-997a9396885c"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("a605c9b7-baa8-4163-b25f-8de28dc5992c") },
                    { new Guid("5eafce69-c9c9-48f5-abe3-d1523a21d5ed"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("7072d592-d83e-4370-8231-968557a1a7fa") },
                    { new Guid("9f9b81ea-2ea2-4193-8b99-b8a40bc476ec"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("a93f7d40-279b-41c6-9825-541c8baf4e89"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("fd0e3766-f26d-4465-a808-b4b262045b9a") },
                    { new Guid("cda4de1a-ba9a-44f4-8603-233ce2fbd29c"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("c19344f4-80ff-485b-b006-efbce38de108") },
                    { new Guid("fc9dfb17-6aec-4e3d-8e68-a7d6d3df5278"), new Guid("a738121d-1589-479c-943b-a749dae68ca3"), false, new Guid("6ed7f3f2-a11e-4564-bd0a-5577a83a49a8") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "IsInCombo", "Name", "OrderComboId", "OrderId", "Quantity" },
                values: new object[] { new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"), false, true, null, new Guid("bffea8fd-0443-4688-84c6-72b047458059"), new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("4f279886-9183-44a2-a6e2-15be8d43f62b"), new Guid("ba57c9fc-fb84-459f-90b1-8380cf56326a"), true, new Guid("bffea8fd-0443-4688-84c6-72b047458059"), new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1, new Guid("95b1d883-384b-4aba-a173-6752561119bf") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "IsInCombo", "OrderComboId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("2e436795-c55b-4478-aafd-7f5ceb4275ab"), true, new Guid("bffea8fd-0443-4688-84c6-72b047458059"), new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"), 1, new Guid("012f0feb-3296-44ea-a4b1-576d113b1340"), new Guid("8b3db8eb-5222-4e03-98c5-1e5f9dd1bce3") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("1faf850c-cb6f-4cee-b8b1-0c807734d201"), new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"), false, new Guid("7072d592-d83e-4370-8231-968557a1a7fa") },
                    { new Guid("243cc9a2-c896-41f6-8511-7356b347d517"), new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"), false, new Guid("0b24f943-112f-4581-9012-66c22ebc78e4") },
                    { new Guid("2e8abd00-2fad-4f0f-b3ad-f968c0979a97"), new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"), false, new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9") },
                    { new Guid("e72b4cf0-58a8-4d19-bddb-c79f1d7e8ece"), new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"), false, new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "129487e7-87d4-463b-b789-843918ac3f2e", "24ceef3f-0e65-40b8-b8f6-410b3f6b7265" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "9cd5c5bd-b28a-4992-ae75-e87083c3c74a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "129487e7-87d4-463b-b789-843918ac3f2e", "a951093b-fa02-4609-a877-d1f9658445cc" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("094c0bc3-0103-4645-9108-345cd3b13edd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("10b4ea7d-933f-4efa-a4e5-2d263b1dda1e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1bc24ec0-9159-4f62-b233-9afeba8815f4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1ee38d6b-569e-4fb6-81fc-121655bbc0bf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1faf850c-cb6f-4cee-b8b1-0c807734d201"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("243cc9a2-c896-41f6-8511-7356b347d517"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("249fdd4b-7842-4968-acb7-e4adcb42661a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2560c2a8-964d-467d-8206-019cdf05aa03"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2e8abd00-2fad-4f0f-b3ad-f968c0979a97"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("305309f9-4e18-4150-95d2-d2d53fddd00e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("30b828ce-4553-46e9-843e-f3a7a0650ff8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("399bd453-638a-4b2e-b42c-dccd9515318b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3ae8c5f5-e3ac-4c60-addc-657f6b259bf9"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3eeb6bb0-00ab-485d-8765-741d5d4bc457"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("52add5aa-82a2-407d-b1f8-1cd5553b2287"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("573e35bb-366a-47df-a9ed-997a9396885c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("5eafce69-c9c9-48f5-abe3-d1523a21d5ed"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6ec9868d-e47b-43ad-b91c-57410a68a50b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("83b612b2-2bb9-483a-8137-1712696e3dba"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8ce87eee-5b0c-4af8-b127-926d3eaf7fe8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("946411a6-58fb-4857-9742-b2edf4f24c61"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9b0b2b72-e770-4de8-9f99-5a201f0a9b4a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9f9b81ea-2ea2-4193-8b99-b8a40bc476ec"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a2201fc7-b570-4e8e-8ee7-2af54bc6fc6b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a2a705a0-2a1d-4d39-afb7-05da6b54f9b5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a93f7d40-279b-41c6-9825-541c8baf4e89"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("bc7ff02c-3805-4902-b099-18f57aec734d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("bcde5458-2eab-44c4-a0c8-b100a0cdbcce"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c1cfa02b-bee7-4d82-9fdf-b91a1287fcaf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cda4de1a-ba9a-44f4-8603-233ce2fbd29c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("dbecd615-633b-4552-bb34-4df2f51e284c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e72b4cf0-58a8-4d19-bddb-c79f1d7e8ece"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e9106812-a372-4695-813f-eb7764aed5c7"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ece77484-6127-4800-bca9-22430cebfd7a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fc9dfb17-6aec-4e3d-8e68-a7d6d3df5278"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("1c34d729-1fa5-48a5-b906-b3655574584c"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("274c5aa5-e7b6-4cca-a393-c3bf04940566"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("1492c598-9bd6-4dba-86fc-c5e71c8a7248"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("3fe4669f-fd11-416a-8ffe-41e9016e1c81"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("891ac059-a0a5-41b0-a824-29938804dbeb"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("f34313a1-7d24-48a9-bb58-4b3d7a69f11a"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("4f279886-9183-44a2-a6e2-15be8d43f62b"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("51316ef7-729b-41a8-82d1-db3bb7d41b56"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("2e436795-c55b-4478-aafd-7f5ceb4275ab"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("4a91b352-0da2-4419-b829-785d00618b79"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("10c74722-5f4b-43c8-8e45-10f7fa6e1337"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("9f1eb783-0672-496c-addf-20e1b3e0f4b5"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("37a50b38-79d1-49ec-8f28-96f36b2ad42b"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("429029e2-e30f-4561-a6e3-7bd4a2041b37"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("cfbc12c7-11aa-44a1-ae21-8009ea16b079"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("8b3db8eb-5222-4e03-98c5-1e5f9dd1bce3"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("95b1d883-384b-4aba-a173-6752561119bf"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d2279d7a-4f23-4859-be0e-595a7d4bbf6e"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("104134bb-0f8b-4411-b05b-177cd9eb2763"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2f88f2d7-c6a2-409e-87af-cfd06325a611"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("6d74b409-598a-422a-b8a0-04dc96672e02"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "129487e7-87d4-463b-b789-843918ac3f2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24ceef3f-0e65-40b8-b8f6-410b3f6b7265");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cd5c5bd-b28a-4992-ae75-e87083c3c74a");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("6f02afab-b32d-486c-b2df-163258d95e9d"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("a738121d-1589-479c-943b-a749dae68ca3"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("e4f64e55-479a-4d63-953f-5683e607cfb9"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("f81240b9-aa7f-494b-b664-7346fc2ad80f"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("abff2c50-3cba-49b3-9309-36b1404a411c"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("ba57c9fc-fb84-459f-90b1-8380cf56326a"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("012f0feb-3296-44ea-a4b1-576d113b1340"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("5ea5dca4-dc78-440f-bd4c-429385ef51bb"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0b24f943-112f-4581-9012-66c22ebc78e4"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("5270cf4d-0a22-49be-b958-5e1459fa291b"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("6ed7f3f2-a11e-4564-bd0a-5577a83a49a8"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7072d592-d83e-4370-8231-968557a1a7fa"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7f4d5ddb-625b-41d8-96b6-2d7a4fde8082"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("91647c8a-1ec9-47f5-8e15-2f9d51b078e9"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("a605c9b7-baa8-4163-b25f-8de28dc5992c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("c19344f4-80ff-485b-b006-efbce38de108"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("eb1a74ee-a261-49ec-bd43-3a23ef5fc549"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("fd0e3766-f26d-4465-a808-b4b262045b9a"));

            migrationBuilder.DeleteData(
                table: "OrderCombos",
                keyColumn: "Id",
                keyValue: new Guid("bffea8fd-0443-4688-84c6-72b047458059"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3400979e-11d9-4c92-87be-5d834bd13f79"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a2c5b0e-960e-4c19-857f-7e9665a2cc0d"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("456b5e22-26e6-4200-9ecf-9a036b938e43"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("998bcb41-c23d-4f6a-853b-69313960a3f0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a951093b-fa02-4609-a877-d1f9658445cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7a73dd3-c874-4587-be77-80161a4cea88");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderCombos");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d30f273-7de6-4402-acb4-3303c770f30c", "AQAAAAIAAYagAAAAECNOYw5wWHWfdZ1jU0CqBTT2RUX7nVKFz1C7x7JxfgwD2sx7G7fEi3rHYn1yIQXUmA==", "31549cec-a262-4f03-b9e2-f96a78c95fad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11c3300a-8733-4a71-90ae-8136545d3722", 0, "23e3553a-44e7-4802-a07a-c537d354f883", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEC7pkbmW+Gea2JVvTUWFtNzsfYWL3D5/ar7GBOQW4cAci9HqaylrJ560SOye9recKw==", null, false, "257417cf-04a9-4f57-ad53-991d6b082baf", false, "ekrabs" },
                    { "26ee909a-154f-4cb1-b98c-d812e600c2e6", 0, "b987b376-ce24-4b52-aa6d-cf3e69d100af", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEPN5nc/HzloVxWjvAKt8GpkzmCTuqmI8DwERzygmYMzcpNF1IvU78FMooOpRjlJ/oQ==", null, false, "9194d874-35e2-4d62-8253-17ec2cf74cb9", false, "ssquarepants" },
                    { "31e844bd-bfaa-4991-a837-c986207d12f8", 0, "e48f66a9-d7fe-4ebb-a0cb-a45b618c6361", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHvggcyfwNk3EMMonvnwg0Eh3TN4nVHVC6H818h9jThRxdCUX/mw3weswF0tBF2bug==", null, false, "f54413ef-bab3-4535-b7d3-473e97e820ec", false, "stentacles" },
                    { "c1e902ba-dbce-4bea-b9b7-a6ffdba7ce36", 0, "e97ff079-35e0-438f-ac00-651eebe85d4a", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAED4KFd2m2t0hEuO5KxLIxK9441nEerPBS4bN3rPAcwUUpj9hqFlCB1JEIzJ+Jk8exg==", null, false, "536ec80f-a462-4523-884f-b639663c0819", false, "pstar" }
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
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("a960e6a6-b846-4504-9b99-63a497243d43"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "11c3300a-8733-4a71-90ae-8136545d3722" },
                    { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "26ee909a-154f-4cb1-b98c-d812e600c2e6" },
                    { "7463fc2a-50d4-4fef-aef5-d17538ccb6d3", "31e844bd-bfaa-4991-a837-c986207d12f8" }
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
                    { new Guid("a7700b2a-0a86-422e-a8fd-13757804d63d"), "120 Conch Street", "Patrick", "c1e902ba-dbce-4bea-b9b7-a6ffdba7ce36", "Star" }
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
        }
    }
}
