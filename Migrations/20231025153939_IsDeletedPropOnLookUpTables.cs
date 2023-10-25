using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class IsDeletedPropOnLookUpTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc3b483f-72fc-4bee-a519-387151ccda89", "02281be4-0d95-4711-99a8-0c64b640799b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "099cbd77-4110-43f3-b771-3bd2dd976d5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc3b483f-72fc-4bee-a519-387151ccda89", "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("02e33225-72c0-4967-90ad-ec4f79ba3d63"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0f718f4b-d7b9-4423-83df-2984a5b56d12"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("10376ad2-a002-4efd-8b85-81d996cc98df"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("15cc10b4-1980-4a61-953a-d859b022428f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1917d909-1520-4254-8038-22e802afd312"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("19b9950e-ec42-46df-b85d-f9b256aac0cd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2407de12-5255-4c9b-a341-e2401b0584f4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("25e21efc-8351-4583-a38c-b2b645615804"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("26414236-cd46-4cfa-8a35-5775426abdba"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4f123d89-a7e4-4276-9e97-9b856b98dc19"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("50efa2bc-1d28-430b-b65a-80f3505c1afa"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("53cd1d84-e8e9-421a-ab13-3339ad34834d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("53e0df93-bed2-4d26-8f84-ea43feba3f46"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("55fe7e6a-c202-4b84-b5fe-b3a0afb09423"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("62b246f4-bd0b-4a0a-bbe1-3e673d7683d1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("7c0c7ce4-e178-4803-86d3-487db8d08e2b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("83542567-c618-4812-b9a9-c57904e97045"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("86540e5d-0415-413e-9568-f1058c452c0e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("870c174e-f82a-4ca5-9d24-99e4f73c8c8d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("907499c3-a68a-45a6-85b9-9fb16b3e4f75"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("918a5f5c-2f15-4236-84c6-9383153dad56"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a363fddc-4f80-4858-91cc-5d92a01fea7e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("abb70bbd-43c6-4776-8248-d453521f2b3d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("aee88ad4-e559-44e5-82a0-23188b224dfa"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ccd6255b-fe49-4bd4-86f9-2b33b03c820a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d6c86d88-b232-429b-8206-6ee969156b20"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e130519e-4022-432f-a4ec-d04763ac9d4c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f45b3877-b8b0-4cbe-a7ab-54515862407c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f58d9e70-83b3-4f16-a1f6-1086492e37f7"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("1c108a9e-9b99-4fc0-9d12-2ad2ca395799"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("9d97c034-61df-49ad-84fc-246f7e78890a"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("b961bbf0-403f-49f2-aaf3-98ea533289d9"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("008678d3-329a-41ed-8163-7c8437ee8939"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("48945177-66b3-4da7-9226-2071ad78594b"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("116c2397-0358-440b-9c87-76090a8eecc1"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("44b9e5c2-8ff9-40fb-ac2f-9165f8795035"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("cf7f64ad-79ea-4981-b46c-a29a71e8251f"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("eb5317b2-636a-44dc-89d4-591e25d772af"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("f04c3eb3-f135-4316-8d8f-2989c401d3c7"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("40a5da61-4f56-4081-8bb7-41976b0a701d"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("178a0e8b-bc78-4daa-9976-8935353340b9"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e6743ad-c9aa-413f-8416-24047564323c"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("fac82dfc-c5a1-4ae1-8b3c-b1e7d557dc5c"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("49da624b-41c4-4f0c-8c4e-9b32f87c3d24"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("77aec8fc-d0ad-49aa-932f-2e04f8a5b4f5"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("e0507091-6a54-440b-bd24-adf2e23f0e8a"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("e84bfef9-d6a7-4c33-b8ac-927eb3e5a44b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("52e7feb2-ce4b-41ff-954b-bf1530547817"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("85359301-c9f5-4907-92d5-de759d7f91c7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("919e5331-40e7-4db7-b9a6-7f7bfbda2188"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("568cb4ec-53a4-4ac2-ae18-4d5b48c52289"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("007e837e-1dfb-4d59-b0c9-c325f0d8d32d"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("0e9ede9a-14aa-4801-80e5-62fef7a0f63c"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2335abc1-2914-4355-b32b-6f5dd81ccc8f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc3b483f-72fc-4bee-a519-387151ccda89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "099cbd77-4110-43f3-b771-3bd2dd976d5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("76b45ca0-2d30-4d73-9ff9-86b16c6c0f6b"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("b08890cb-025d-48d6-9aec-1fad1e5c472f"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("d058ac14-b29a-4a72-8ce4-116dc22c400a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("5c1dd2e5-156d-4196-9bc6-57e7c2d8e0b3"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("1e1642f0-346b-4f30-b886-a93a71fc7efd"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("1507ca55-71b2-47d2-bf42-877b02c71718"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("60725929-ae42-4838-8c7b-1976f79730f3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("6feaa3bc-0cf8-4ac9-8238-7192ff1af5b3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("919dfc51-1f00-4916-bd96-7c95defd8f19"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("92ea16f4-7a90-4fd8-805a-a606c093063e"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("a9b8334a-125b-4cb7-bac8-b325514a8223"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("c28c19ab-eea1-45b7-b14d-a85adc37c6d2"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("cc4538a2-5b30-4421-a08d-a3e460fe6dd2"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("d8036fd0-1e30-4e49-8ec3-328b6a1b5c02"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9c850bab-3dd6-4415-ab77-d2b880885303"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("99aea153-e778-4e43-9210-1125857287c9"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1695d860-3926-452f-9c5b-42518b143fa5"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2a5c48d7-9ce7-4747-80c6-bcdfebc62d82"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02281be4-0d95-4711-99a8-0c64b640799b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c32c4039-3085-44f9-b190-eabc0db206b7");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Toppings",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sides",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Drinks",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Combos",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Burgers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4731b957-71fe-413a-abaa-c1b0f4b8c778", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d4d6dd0-178c-4d4a-99fe-45a3c4118cca", "AQAAAAIAAYagAAAAEEKycxU3fUJTHfHCsZY+OyH0BtDxm/dlquirZnGco/9v77yjM2NLyP9muziXiRmY6g==", "6df8c882-2046-45ce-bf32-fbe49d36f073" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0369d568-16f9-4001-b70c-8b959d506f2c", 0, "c393bcf8-71da-422d-b650-1354ba562efd", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIhoycBlvof7s7DxwcrxIPnYby/I4yKoTbT/SpBaMRYxef1bn9v8I9boOy18jMdbPg==", null, false, "759b1d85-8ca2-454b-b34c-5e5d29f562d9", false, "ekrabs" },
                    { "8f27a07a-38fa-463e-9d2f-90dcf02cbed0", 0, "a7adac26-c434-4ac2-be06-6e587285185b", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHIZcqu2s0PH1M8TqW0H/NwZLziFO/HdgDEjqt1tQLZpHGnCcsKZryO6bmTmu7nYvQ==", null, false, "fc418501-b896-44cd-820c-2301ab6771fb", false, "stentacles" },
                    { "a76b2fb2-b1d5-46f1-a3fa-d179598dd273", 0, "d540a100-7fca-492a-80e8-de6f28a8ddb6", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENAZbHIsBNKRjiuekmWTsE9HQn7PFUXQOr3NTyDx4Yh5U2SDprm6yS0pSH0aKPc6MQ==", null, false, "dee9eb66-e6b8-4181-aea2-e6d06c9ae26f", false, "ssquarepants" },
                    { "ecb4346b-f284-4ab3-9b5e-3cdb0c4d9557", 0, "cfece248-9a1f-44c5-a763-60d558e7103b", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEGrlpufv49MGgW0xntEAo7XWETkAywgy3wOUrkHvs94nBknXyrwoZZqvFcVbdh6D4w==", null, false, "6a0f1bd4-a9ac-45c2-9837-24761dfb88a3", false, "pstar" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), false, "krabby patty", null, 1 },
                    { new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), false, "double krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("252b4696-3e6c-4978-a6ab-598aeac4f502"), new Guid("45fe3ce5-1bd4-4e6f-b582-8a752f0478ad"), new Guid("43ad2091-5747-4ded-8f27-21c41b682c01"), new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68") },
                    { new Guid("481897c0-5585-4052-aeb4-674dc62a9cef"), new Guid("45fe3ce5-1bd4-4e6f-b582-8a752f0478ad"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68") },
                    { new Guid("cbe51507-60a4-41a5-bada-9884665c46cf"), new Guid("45fe3ce5-1bd4-4e6f-b582-8a752f0478ad"), new Guid("91050da3-8aa5-4c1b-9b2b-fbc4ac9fb0b1"), new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("45fe3ce5-1bd4-4e6f-b582-8a752f0478ad"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), -1.25f, false, "double krabby patty combo" },
                    { new Guid("ed7f749b-2df9-43d9-9234-da7cde3875a3"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), -1f, false, "krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0df4044c-87a5-45ce-919b-e43cab4107c3"), false, "diet dr. kelp", 1f },
                    { new Guid("17fd50de-2f0b-424d-a7ad-e47cc916f114"), false, "water", 0.1f },
                    { new Guid("34d79d8f-ce48-4096-be61-a782b6ed470a"), false, "seafoam soda", 1f },
                    { new Guid("4d75d32c-682c-4dd8-863f-2aa23885bfad"), false, "dr. kelp", 1f },
                    { new Guid("6d459456-d44a-48dd-b469-ab7ae74fc51b"), false, "red tide", 1f },
                    { new Guid("dc3042cf-cae4-4316-9022-301207ff1031"), false, "kelp shake", 1.5f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("44052afc-e1c7-4b9d-9add-6175216f60f8"), "pickup" },
                    { new Guid("732c1060-2342-4366-b3a3-0baa344bd927"), "togo" },
                    { new Guid("d2f304e3-5746-4574-b0fc-9a9177d4c831"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("16a982a7-87ef-442e-94e0-1297f93a0e27"), false, "seaweed salad", 2f },
                    { new Guid("2c5a4933-6a22-47f8-8e85-bd80cece4041"), false, "coral bits", 1.25f },
                    { new Guid("612ffa60-ba57-40c3-9c08-a12b547baad5"), false, "kelp fries", 1.25f },
                    { new Guid("c22c0801-63e2-4627-b8e5-480ed11ac8ae"), false, "barnacle rings", 1.25f },
                    { new Guid("e9456783-5c00-4148-bb6f-4e8dba26f0e7"), false, "oyster skins", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("31fcb550-f998-41da-8cd1-487d4b2631e0"), "medium", "md" },
                    { new Guid("a7e7d50f-43f9-4b31-9006-4371a7b1c53d"), "small", "sm" },
                    { new Guid("f2285cfc-304e-44ec-9ef0-600d0e9a6e3a"), "large", "lg" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("06d8f575-86f7-4b7d-a093-f108b06bfe25"), false, "pickle", 0.05f },
                    { new Guid("1cce94fb-4d8a-4897-9b50-0504e0420601"), false, "tomato", 0.05f },
                    { new Guid("24628238-7095-4574-ab5f-a7cca8bcd38d"), false, "secret sauce", 0f },
                    { new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d"), false, "patty", 1f },
                    { new Guid("7608e8c2-a295-4c2d-ae9d-5b9ccbd293cd"), false, "sea cheese", 0.25f },
                    { new Guid("987b3c75-bd26-43dc-9fd2-e4287fa1e5b5"), false, "lettuce", 0.05f },
                    { new Guid("9bf78170-4b49-47be-af2a-cb594588813b"), false, "bun", 0.2f },
                    { new Guid("b10665c5-be5d-45c2-9848-29ba93d9640c"), false, "mustard", 0f },
                    { new Guid("bbd167a3-aa8a-48cf-af40-b72c5e9d21d5"), false, "onion", 0.05f },
                    { new Guid("dee1f361-c209-4e5f-95ba-8776e809a761"), false, "ketchup", 0f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("080b0aae-9cb6-4a45-b6cd-7bcb2c85c02f"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "0369d568-16f9-4001-b70c-8b959d506f2c" },
                    { "4731b957-71fe-413a-abaa-c1b0f4b8c778", "8f27a07a-38fa-463e-9d2f-90dcf02cbed0" },
                    { "4731b957-71fe-413a-abaa-c1b0f4b8c778", "a76b2fb2-b1d5-46f1-a3fa-d179598dd273" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0c41b7a6-b768-4657-8ea4-b40fbf96ce96"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("9bf78170-4b49-47be-af2a-cb594588813b") },
                    { new Guid("1706f150-a394-4c2d-89ac-916264d5b7b5"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d") },
                    { new Guid("3a49ed3b-b0ec-4a6c-8dd5-1a8883880701"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("987b3c75-bd26-43dc-9fd2-e4287fa1e5b5") },
                    { new Guid("471a1eb5-4d11-4618-acaa-596b3f8767c3"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("06d8f575-86f7-4b7d-a093-f108b06bfe25") },
                    { new Guid("4fe8c8f5-ac35-406b-a134-ac202422164b"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("bbd167a3-aa8a-48cf-af40-b72c5e9d21d5") },
                    { new Guid("5957597c-fa9f-4bc4-93eb-16435cbc89cd"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("b10665c5-be5d-45c2-9848-29ba93d9640c") },
                    { new Guid("78138d95-db65-479e-a0ac-d5ef32965538"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("06d8f575-86f7-4b7d-a093-f108b06bfe25") },
                    { new Guid("7bf74864-f39e-4b82-bc72-41815bbf9601"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("bbd167a3-aa8a-48cf-af40-b72c5e9d21d5") },
                    { new Guid("7f911631-5111-40df-9df2-79e3a27897e2"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("24628238-7095-4574-ab5f-a7cca8bcd38d") },
                    { new Guid("80052281-af8f-472c-b5fc-3df77310fcb2"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("dee1f361-c209-4e5f-95ba-8776e809a761") },
                    { new Guid("80a10115-8b3c-4f0b-80bb-61ebdabf71fc"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("dee1f361-c209-4e5f-95ba-8776e809a761") },
                    { new Guid("83951240-935d-48fb-ad0a-39c7dd3487d2"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d") },
                    { new Guid("b601af36-7ba6-41a6-a3aa-62ca19d70954"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("987b3c75-bd26-43dc-9fd2-e4287fa1e5b5") },
                    { new Guid("bc0e9a6d-e1d9-421f-9eeb-5f62746d79e3"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("9bf78170-4b49-47be-af2a-cb594588813b") },
                    { new Guid("d66966f6-3110-42cf-a5c0-097b4fb7188f"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("b10665c5-be5d-45c2-9848-29ba93d9640c") },
                    { new Guid("d7056eec-1562-4a6d-97b7-d7ccbc9088c8"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("1cce94fb-4d8a-4897-9b50-0504e0420601") },
                    { new Guid("dea6fea9-e588-4aab-8257-97ea60c527b6"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d") },
                    { new Guid("efff9917-abc5-4c0d-baf1-66cb323e4815"), new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"), new Guid("1cce94fb-4d8a-4897-9b50-0504e0420601") },
                    { new Guid("f3999313-5eee-4a09-a937-b7d897acf2dc"), new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"), new Guid("24628238-7095-4574-ab5f-a7cca8bcd38d") }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("00a7dd35-2558-48ca-9ebc-300e1f602ee3"), "124 Conch Street", "SpongeBob", "a76b2fb2-b1d5-46f1-a3fa-d179598dd273", "SquarePants" },
                    { new Guid("1940f1e7-2d49-4bb6-9ee8-13b57c57d4a6"), "120 Conch Street", "Patrick", "ecb4346b-f284-4ab3-9b5e-3cdb0c4d9557", "Star" },
                    { new Guid("5040a619-9551-4cba-97cd-49f3b3a344f3"), "3541 Anchor Way", "Eugene", "0369d568-16f9-4001-b70c-8b959d506f2c", "Krabs" },
                    { new Guid("d3bea2cd-0152-44b1-8b0b-a30d5c8f8804"), "122 Conch Street", "Squidward", "8f27a07a-38fa-463e-9d2f-90dcf02cbed0", "Tentacles" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68"), new Guid("1940f1e7-2d49-4bb6-9ee8-13b57c57d4a6"), new Guid("d3bea2cd-0152-44b1-8b0b-a30d5c8f8804"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d2f304e3-5746-4574-b0fc-9a9177d4c831") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), false, null, new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("43ad2091-5747-4ded-8f27-21c41b682c01"), new Guid("6d459456-d44a-48dd-b469-ab7ae74fc51b"), new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68"), 1, new Guid("31fcb550-f998-41da-8cd1-487d4b2631e0") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("91050da3-8aa5-4c1b-9b2b-fbc4ac9fb0b1"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68"), 1, new Guid("2c5a4933-6a22-47f8-8e85-bd80cece4041"), new Guid("f2285cfc-304e-44ec-9ef0-600d0e9a6e3a") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0b617b32-8c6a-44dd-b5f4-c597b8682c88"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("24628238-7095-4574-ab5f-a7cca8bcd38d") },
                    { new Guid("24421084-98f9-45ea-b836-be348bbe7052"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("dee1f361-c209-4e5f-95ba-8776e809a761") },
                    { new Guid("3bed77b2-1bc3-4bbe-9523-e3053babb97c"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("987b3c75-bd26-43dc-9fd2-e4287fa1e5b5") },
                    { new Guid("703c7404-cd78-423d-bfc3-07ce47903c7a"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("1cce94fb-4d8a-4897-9b50-0504e0420601") },
                    { new Guid("8259aeb5-91a3-483d-b343-a8c0d1eafdf6"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("9bf78170-4b49-47be-af2a-cb594588813b") },
                    { new Guid("990f1733-deed-42f3-8007-932cb0b4488a"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("06d8f575-86f7-4b7d-a093-f108b06bfe25") },
                    { new Guid("a4234173-6954-44c4-b600-ac382c57604a"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("b10665c5-be5d-45c2-9848-29ba93d9640c") },
                    { new Guid("d73a61e6-2f29-4035-a8d6-55c08ea252b3"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d") },
                    { new Guid("de4129a4-5c35-4eeb-b3cf-b51172f69372"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d") },
                    { new Guid("fa52552b-6ad3-4c53-ab21-483561a32239"), new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"), new Guid("bbd167a3-aa8a-48cf-af40-b72c5e9d21d5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "0369d568-16f9-4001-b70c-8b959d506f2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4731b957-71fe-413a-abaa-c1b0f4b8c778", "8f27a07a-38fa-463e-9d2f-90dcf02cbed0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4731b957-71fe-413a-abaa-c1b0f4b8c778", "a76b2fb2-b1d5-46f1-a3fa-d179598dd273" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0b617b32-8c6a-44dd-b5f4-c597b8682c88"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0c41b7a6-b768-4657-8ea4-b40fbf96ce96"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1706f150-a394-4c2d-89ac-916264d5b7b5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("24421084-98f9-45ea-b836-be348bbe7052"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3a49ed3b-b0ec-4a6c-8dd5-1a8883880701"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3bed77b2-1bc3-4bbe-9523-e3053babb97c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("471a1eb5-4d11-4618-acaa-596b3f8767c3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4fe8c8f5-ac35-406b-a134-ac202422164b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("5957597c-fa9f-4bc4-93eb-16435cbc89cd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("703c7404-cd78-423d-bfc3-07ce47903c7a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("78138d95-db65-479e-a0ac-d5ef32965538"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("7bf74864-f39e-4b82-bc72-41815bbf9601"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("7f911631-5111-40df-9df2-79e3a27897e2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("80052281-af8f-472c-b5fc-3df77310fcb2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("80a10115-8b3c-4f0b-80bb-61ebdabf71fc"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8259aeb5-91a3-483d-b343-a8c0d1eafdf6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("83951240-935d-48fb-ad0a-39c7dd3487d2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("990f1733-deed-42f3-8007-932cb0b4488a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a4234173-6954-44c4-b600-ac382c57604a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b601af36-7ba6-41a6-a3aa-62ca19d70954"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("bc0e9a6d-e1d9-421f-9eeb-5f62746d79e3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d66966f6-3110-42cf-a5c0-097b4fb7188f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d7056eec-1562-4a6d-97b7-d7ccbc9088c8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d73a61e6-2f29-4035-a8d6-55c08ea252b3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("de4129a4-5c35-4eeb-b3cf-b51172f69372"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("dea6fea9-e588-4aab-8257-97ea60c527b6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("efff9917-abc5-4c0d-baf1-66cb323e4815"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f3999313-5eee-4a09-a937-b7d897acf2dc"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fa52552b-6ad3-4c53-ab21-483561a32239"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("252b4696-3e6c-4978-a6ab-598aeac4f502"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("481897c0-5585-4052-aeb4-674dc62a9cef"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("cbe51507-60a4-41a5-bada-9884665c46cf"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("45fe3ce5-1bd4-4e6f-b582-8a752f0478ad"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("ed7f749b-2df9-43d9-9234-da7cde3875a3"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("0df4044c-87a5-45ce-919b-e43cab4107c3"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("17fd50de-2f0b-424d-a7ad-e47cc916f114"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("34d79d8f-ce48-4096-be61-a782b6ed470a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("4d75d32c-682c-4dd8-863f-2aa23885bfad"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("dc3042cf-cae4-4316-9022-301207ff1031"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("43ad2091-5747-4ded-8f27-21c41b682c01"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("91050da3-8aa5-4c1b-9b2b-fbc4ac9fb0b1"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("44052afc-e1c7-4b9d-9add-6175216f60f8"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("732c1060-2342-4366-b3a3-0baa344bd927"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("16a982a7-87ef-442e-94e0-1297f93a0e27"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("612ffa60-ba57-40c3-9c08-a12b547baad5"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("c22c0801-63e2-4627-b8e5-480ed11ac8ae"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("e9456783-5c00-4148-bb6f-4e8dba26f0e7"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("31fcb550-f998-41da-8cd1-487d4b2631e0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("a7e7d50f-43f9-4b31-9006-4371a7b1c53d"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("f2285cfc-304e-44ec-9ef0-600d0e9a6e3a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7608e8c2-a295-4c2d-ae9d-5b9ccbd293cd"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("00a7dd35-2558-48ca-9ebc-300e1f602ee3"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("080b0aae-9cb6-4a45-b6cd-7bcb2c85c02f"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("5040a619-9551-4cba-97cd-49f3b3a344f3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4731b957-71fe-413a-abaa-c1b0f4b8c778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0369d568-16f9-4001-b70c-8b959d506f2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a76b2fb2-b1d5-46f1-a3fa-d179598dd273");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("1550ee77-ee70-421e-a798-fc7f7e17f044"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("474ad82b-f1fc-4333-ad69-fead5e6d5c26"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("d97475c5-027c-4ffa-bf5d-f46a46c08a1b"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("6d459456-d44a-48dd-b469-ab7ae74fc51b"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("2c5a4933-6a22-47f8-8e85-bd80cece4041"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("06d8f575-86f7-4b7d-a093-f108b06bfe25"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("1cce94fb-4d8a-4897-9b50-0504e0420601"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("24628238-7095-4574-ab5f-a7cca8bcd38d"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("719f2698-34e0-406e-b927-edc8a36d2c0d"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("987b3c75-bd26-43dc-9fd2-e4287fa1e5b5"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("9bf78170-4b49-47be-af2a-cb594588813b"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("b10665c5-be5d-45c2-9848-29ba93d9640c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("bbd167a3-aa8a-48cf-af40-b72c5e9d21d5"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("dee1f361-c209-4e5f-95ba-8776e809a761"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ce778112-793e-49bf-8aeb-dfbd7be0ba68"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("d2f304e3-5746-4574-b0fc-9a9177d4c831"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1940f1e7-2d49-4bb6-9ee8-13b57c57d4a6"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d3bea2cd-0152-44b1-8b0b-a30d5c8f8804"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f27a07a-38fa-463e-9d2f-90dcf02cbed0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecb4346b-f284-4ab3-9b5e-3cdb0c4d9557");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sides");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Burgers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dc3b483f-72fc-4bee-a519-387151ccda89", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3bd03d8-0929-40ef-8122-d405c4563835", "AQAAAAIAAYagAAAAEJIM1Hgi5upDYkaXc4/z+AD07VZY26jCGLZMa0T3xtNaQAlSkhBMKN7H/HR5dhQB+g==", "401307f8-5813-4a7c-a0eb-dcfd786abff6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02281be4-0d95-4711-99a8-0c64b640799b", 0, "452c8282-9173-4574-9dc6-5e2bae126137", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEI7rkYAq2A/pI522xDCj7p0/OejBMYPE6c6m9AmdmBeq9Zp0KlBpkExcdcUBIHbKjA==", null, false, "0443c1c0-2dfd-4022-aae8-9e08fcbbab37", false, "stentacles" },
                    { "099cbd77-4110-43f3-b771-3bd2dd976d5b", 0, "b6822f2c-aa86-4945-9430-945c6d1f2561", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAECvuTYSkBST7u3yx6c/r8o/zPQPjklrzwGK1dKigr8GRc77Fg7GKwdQvbc76riR6mQ==", null, false, "4b48d669-5419-4d8d-a876-9f3f0ab9fc0f", false, "ekrabs" },
                    { "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c", 0, "e550af3d-2a05-42c8-b4e6-91b3cf7caa14", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJJMVfH0B+FTz53kA7L1nxthZhw8C7/XR5KF1UDnDlzg/dpqZh4O5XGH7XL0EvcVBw==", null, false, "146c831e-34f4-402a-aad5-618f1537892f", false, "ssquarepants" },
                    { "c32c4039-3085-44f9-b190-eabc0db206b7", 0, "696bd78c-bfcc-48e0-88a9-0b7a77338401", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEM/loJoQPhZh4HBiyJX/DzOwGtgeyVBlpa0cpYvHjnvfme1bSzzLepGKXsPa0VZ9pg==", null, false, "2be63c57-cd7b-4b67-925a-31fe39a79a41", false, "pstar" }
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
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("2335abc1-2914-4355-b32b-6f5dd81ccc8f"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "dc3b483f-72fc-4bee-a519-387151ccda89", "02281be4-0d95-4711-99a8-0c64b640799b" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "099cbd77-4110-43f3-b771-3bd2dd976d5b" },
                    { "dc3b483f-72fc-4bee-a519-387151ccda89", "9a4eb093-6ebb-4f1d-bdfe-3f7b179a786c" }
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
        }
    }
}
