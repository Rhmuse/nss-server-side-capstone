using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class extraPropOnBurgerToppings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "Extra",
                table: "BurgerToppings",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a9683d9-e090-416a-b6ed-62221c71214f", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b4aa31f-45d1-46f1-ae71-9269d33339ba", "AQAAAAIAAYagAAAAEGsohjXwAKTheqfLxjWBmBeg0KAl9XRIiocvuchYcHT+DW7yVK7wufUP1rSz23cOdg==", "11d7b080-b408-4dae-b452-26ad632fb07f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2f44720f-855c-4319-8ef7-d871b99aed3e", 0, "f2e1db49-5c68-4c3f-9e3c-db5620ac0d79", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIHY6Sp0WvFdw4FLkc2rSybgFagcSORszj/+Ycnm6cA46rPjKpIuNnypRopEiGgwIw==", null, false, "4849d49e-0ece-4a7e-9d02-edc0a266e8ac", false, "pstar" },
                    { "3e17f931-a840-4cd8-b088-591069bcdc04", 0, "433ce99a-5357-4d06-8a16-9e9d02dd535d", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDdBPZkpu+q9poXuyuJH5nn4/5w+uWLCSZ4fSo26UEgMlo9QfJicWyHKO5xJKqhNSw==", null, false, "f5ed5d9c-8e46-4d55-9272-6c75bcc4b608", false, "ekrabs" },
                    { "53e45d77-e821-4533-8290-440c385cc6d5", 0, "e167c72d-e086-4a64-bb23-b8fa272234c2", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIw9Bfw2ixwAFLcUyDdrhQUorcoCUPdNayt1+JJiQBezc81e2MfbRq4Br2VkM/0NSA==", null, false, "44fd06fe-2e82-4140-9e03-23b1033c6706", false, "stentacles" },
                    { "fcc4b018-9081-43a7-91e6-e82ff8a61fd7", 0, "b9fbbd00-9e9b-4af5-b483-039cbb3c75c7", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEEpuGiuGuGNAmb+rxdwpePGnR8HYojTWuZdvKGQTmjtVSLWOjQy/fEcXgP9qaEXOBw==", null, false, "fface5d8-69d7-4999-84ff-8ea93e2d609a", false, "ssquarepants" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, "krabby patty", null, 1 },
                    { new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, "double krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("2b291270-64f7-43f3-a152-0ed737f79379"), new Guid("787d6425-0a64-4696-9c1a-8d7b54ce8d82"), new Guid("1ce0f36b-35f6-41b4-9bf6-ae1c826dc61b"), new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9") },
                    { new Guid("6021f50d-15a6-47ff-8eba-e51ffbb54df9"), new Guid("787d6425-0a64-4696-9c1a-8d7b54ce8d82"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9") },
                    { new Guid("c5702e08-9d19-4189-a07d-094a2521e0fc"), new Guid("787d6425-0a64-4696-9c1a-8d7b54ce8d82"), new Guid("f2cebf79-feff-4f67-9d0f-c8c02b4ada94"), new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("329e1c49-53c3-4392-a70d-ff89ef38cbc5"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), -1f, false, "krabby patty combo" },
                    { new Guid("787d6425-0a64-4696-9c1a-8d7b54ce8d82"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), -1.25f, false, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("48662a7b-15c9-4486-b59c-14a36190ef30"), false, "dr. kelp", 1f },
                    { new Guid("678e387a-2551-4452-a80e-1a09f7de7076"), false, "diet dr. kelp", 1f },
                    { new Guid("7b02a299-a291-4a3b-b359-2edc22899e77"), false, "red tide", 1f },
                    { new Guid("d73d8ad9-9fee-4ba3-9fc2-bcbd528f9890"), false, "water", 0.1f },
                    { new Guid("e1782c27-1fc1-4988-8b88-94025f7dc7b2"), false, "kelp shake", 1.5f },
                    { new Guid("f146e8cf-7198-400b-ae45-70e6287bdea6"), false, "seafoam soda", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ca8a278-5910-40e7-ad31-af49f5ace38f"), "here" },
                    { new Guid("b98a6937-829e-4834-afb5-032f51d0e5cb"), "pickup" },
                    { new Guid("fbe65cf5-676b-45dc-8772-05a15eb525ad"), "togo" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6fc52287-6d31-43bd-b092-40e72be42b09"), false, "barnacle rings", 1.25f },
                    { new Guid("80b5f45e-22b1-42b8-8dd4-53f3625cf53a"), false, "kelp fries", 1.25f },
                    { new Guid("8b596700-cef7-40c7-90fe-6a0fad4fb0dd"), false, "seaweed salad", 2f },
                    { new Guid("b5cc19c4-755d-4198-8185-8d4786c49153"), false, "coral bits", 1.25f },
                    { new Guid("bd799ba8-475b-47a4-9e88-f64af8be5843"), false, "oyster skins", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("098e8c9d-87d5-42e5-bfeb-787253180835"), "medium", "md" },
                    { new Guid("151c5f80-eaea-4233-a7fa-d951fdb3381f"), "small", "sm" },
                    { new Guid("28179729-4f26-4667-8e49-0702b1789349"), "large", "lg" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("29ff0a1f-97aa-4772-8904-d49220db3694"), false, "pickle", 0.05f },
                    { new Guid("2dcf6d43-60e4-40e3-a4c9-5863f5643cef"), false, "onion", 0.05f },
                    { new Guid("2dd66e1e-66ca-4b68-8fc7-5858e477488a"), false, "lettuce", 0.05f },
                    { new Guid("8e0ef6b8-8979-46e8-9425-88d05b7083b3"), false, "bun", 0.2f },
                    { new Guid("9210eeb1-8dc6-49d8-a423-132617edcd10"), false, "tomato", 0.05f },
                    { new Guid("a3a2a614-9f7e-49bd-ab04-f5a65823b5b1"), false, "mustard", 0f },
                    { new Guid("be5324a9-2702-4016-bc9e-3f2727ae981e"), false, "sea cheese", 0.25f },
                    { new Guid("eb335c98-4143-4844-80fc-eb45f545b3b5"), false, "ketchup", 0f },
                    { new Guid("efd1e2df-888f-4ccb-a237-6f5ea21cefe0"), false, "secret sauce", 0f },
                    { new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08"), false, "patty", 1f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("792b2b03-311c-422f-b2ff-39bb405a5697"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "3e17f931-a840-4cd8-b088-591069bcdc04" },
                    { "9a9683d9-e090-416a-b6ed-62221c71214f", "53e45d77-e821-4533-8290-440c385cc6d5" },
                    { "9a9683d9-e090-416a-b6ed-62221c71214f", "fcc4b018-9081-43a7-91e6-e82ff8a61fd7" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0af13366-e466-420f-ab9a-d0fd0972a6cb"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("2dd66e1e-66ca-4b68-8fc7-5858e477488a") },
                    { new Guid("110757cd-d608-4d8f-8e47-b8a035db3b5b"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("efd1e2df-888f-4ccb-a237-6f5ea21cefe0") },
                    { new Guid("1885c014-29ca-4dd0-a0c8-4e94d138e553"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08") },
                    { new Guid("2561731d-e253-43e5-a2ec-eae96334b5d2"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("efd1e2df-888f-4ccb-a237-6f5ea21cefe0") },
                    { new Guid("38d5b069-3417-4610-8ed4-a7f26598b9ac"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("eb335c98-4143-4844-80fc-eb45f545b3b5") },
                    { new Guid("47363598-8aa6-4c4f-96a9-ff72e5179e77"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("2dd66e1e-66ca-4b68-8fc7-5858e477488a") },
                    { new Guid("4d1e91c0-b173-4c9b-a3ec-507d9d745fa4"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("9210eeb1-8dc6-49d8-a423-132617edcd10") },
                    { new Guid("5495c1a8-f357-4d78-aec1-d5a8eb70d996"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("a3a2a614-9f7e-49bd-ab04-f5a65823b5b1") },
                    { new Guid("74cfe159-1cac-4e35-a0a9-e6e798b80e20"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("29ff0a1f-97aa-4772-8904-d49220db3694") },
                    { new Guid("7771be65-f28f-476b-9015-bd61a571cef3"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("9210eeb1-8dc6-49d8-a423-132617edcd10") },
                    { new Guid("814c2240-ef20-4433-a8f3-e10779fced07"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("2dcf6d43-60e4-40e3-a4c9-5863f5643cef") },
                    { new Guid("912366b6-7717-4046-9f53-c19140acb5f1"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08") },
                    { new Guid("9f096de8-0aaf-40b5-90a8-4244b0aa2cea"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("2dcf6d43-60e4-40e3-a4c9-5863f5643cef") },
                    { new Guid("a1885878-24c0-4c22-ab2b-23ce9dfd88f0"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08") },
                    { new Guid("d289eae4-770d-4721-9311-58d9307c8711"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("8e0ef6b8-8979-46e8-9425-88d05b7083b3") },
                    { new Guid("d563c5ac-b611-4875-b684-1069a26d09d8"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("a3a2a614-9f7e-49bd-ab04-f5a65823b5b1") },
                    { new Guid("e092f8e9-3429-49a5-ac26-32d778aadb51"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("8e0ef6b8-8979-46e8-9425-88d05b7083b3") },
                    { new Guid("e6f5c472-bfc8-4f47-88ad-0c62900d3c02"), new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"), false, new Guid("29ff0a1f-97aa-4772-8904-d49220db3694") },
                    { new Guid("eb5f4b9b-b433-4d65-8b4a-86aa0c28f6d7"), new Guid("634febcc-7523-4269-9d01-e42f101eae0a"), false, new Guid("eb335c98-4143-4844-80fc-eb45f545b3b5") }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("6142a667-7f16-410a-b87c-a2d2aa5804ca"), "3541 Anchor Way", "Eugene", "3e17f931-a840-4cd8-b088-591069bcdc04", "Krabs" },
                    { new Guid("a6d64d08-518d-47fa-b883-9033940a4695"), "124 Conch Street", "SpongeBob", "fcc4b018-9081-43a7-91e6-e82ff8a61fd7", "SquarePants" },
                    { new Guid("a8b1424d-8270-49dd-b72c-e1896db13e75"), "122 Conch Street", "Squidward", "53e45d77-e821-4533-8290-440c385cc6d5", "Tentacles" },
                    { new Guid("ba93f744-6a18-42ca-84dc-e48d67855cb0"), "120 Conch Street", "Patrick", "2f44720f-855c-4319-8ef7-d871b99aed3e", "Star" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9"), new Guid("ba93f744-6a18-42ca-84dc-e48d67855cb0"), new Guid("a8b1424d-8270-49dd-b72c-e1896db13e75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ca8a278-5910-40e7-ad31-af49f5ace38f") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, null, new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("f2cebf79-feff-4f67-9d0f-c8c02b4ada94"), new Guid("7b02a299-a291-4a3b-b359-2edc22899e77"), new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9"), 1, new Guid("098e8c9d-87d5-42e5-bfeb-787253180835") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("1ce0f36b-35f6-41b4-9bf6-ae1c826dc61b"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9"), 1, new Guid("b5cc19c4-755d-4198-8185-8d4786c49153"), new Guid("28179729-4f26-4667-8e49-0702b1789349") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("0d73de71-a276-41c4-9601-b07d7764d34f"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("eb335c98-4143-4844-80fc-eb45f545b3b5") },
                    { new Guid("14cd6020-a3ff-4064-8d53-4eebcb575a8d"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08") },
                    { new Guid("2651776b-f785-4906-a7dd-e605d219adaa"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("efd1e2df-888f-4ccb-a237-6f5ea21cefe0") },
                    { new Guid("3a65ed95-69c9-421a-86b1-45bc83e8355b"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08") },
                    { new Guid("48df298f-bf43-462f-afef-6d737ecc259d"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("a3a2a614-9f7e-49bd-ab04-f5a65823b5b1") },
                    { new Guid("620a436b-00bf-4e85-bb1d-2e24c9bec4a4"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("8e0ef6b8-8979-46e8-9425-88d05b7083b3") },
                    { new Guid("62779b0e-56d2-4770-9e0e-9c5bdc751f1a"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("29ff0a1f-97aa-4772-8904-d49220db3694") },
                    { new Guid("6a8720a9-5821-4df1-b9a1-ded5835000ba"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("9210eeb1-8dc6-49d8-a423-132617edcd10") },
                    { new Guid("b79b09e6-ff57-4ead-824a-01f90063fc51"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("2dcf6d43-60e4-40e3-a4c9-5863f5643cef") },
                    { new Guid("bcc66c80-7159-4100-bef1-ec5f3cfccfac"), new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"), false, new Guid("2dd66e1e-66ca-4b68-8fc7-5858e477488a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "3e17f931-a840-4cd8-b088-591069bcdc04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a9683d9-e090-416a-b6ed-62221c71214f", "53e45d77-e821-4533-8290-440c385cc6d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a9683d9-e090-416a-b6ed-62221c71214f", "fcc4b018-9081-43a7-91e6-e82ff8a61fd7" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0af13366-e466-420f-ab9a-d0fd0972a6cb"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0d73de71-a276-41c4-9601-b07d7764d34f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("110757cd-d608-4d8f-8e47-b8a035db3b5b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("14cd6020-a3ff-4064-8d53-4eebcb575a8d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1885c014-29ca-4dd0-a0c8-4e94d138e553"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2561731d-e253-43e5-a2ec-eae96334b5d2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("2651776b-f785-4906-a7dd-e605d219adaa"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("38d5b069-3417-4610-8ed4-a7f26598b9ac"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3a65ed95-69c9-421a-86b1-45bc83e8355b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("47363598-8aa6-4c4f-96a9-ff72e5179e77"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("48df298f-bf43-462f-afef-6d737ecc259d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4d1e91c0-b173-4c9b-a3ec-507d9d745fa4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("5495c1a8-f357-4d78-aec1-d5a8eb70d996"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("620a436b-00bf-4e85-bb1d-2e24c9bec4a4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("62779b0e-56d2-4770-9e0e-9c5bdc751f1a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6a8720a9-5821-4df1-b9a1-ded5835000ba"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("74cfe159-1cac-4e35-a0a9-e6e798b80e20"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("7771be65-f28f-476b-9015-bd61a571cef3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("814c2240-ef20-4433-a8f3-e10779fced07"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("912366b6-7717-4046-9f53-c19140acb5f1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9f096de8-0aaf-40b5-90a8-4244b0aa2cea"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a1885878-24c0-4c22-ab2b-23ce9dfd88f0"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b79b09e6-ff57-4ead-824a-01f90063fc51"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("bcc66c80-7159-4100-bef1-ec5f3cfccfac"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d289eae4-770d-4721-9311-58d9307c8711"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d563c5ac-b611-4875-b684-1069a26d09d8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e092f8e9-3429-49a5-ac26-32d778aadb51"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e6f5c472-bfc8-4f47-88ad-0c62900d3c02"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("eb5f4b9b-b433-4d65-8b4a-86aa0c28f6d7"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("2b291270-64f7-43f3-a152-0ed737f79379"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("6021f50d-15a6-47ff-8eba-e51ffbb54df9"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("c5702e08-9d19-4189-a07d-094a2521e0fc"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("329e1c49-53c3-4392-a70d-ff89ef38cbc5"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("787d6425-0a64-4696-9c1a-8d7b54ce8d82"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("48662a7b-15c9-4486-b59c-14a36190ef30"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("678e387a-2551-4452-a80e-1a09f7de7076"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("d73d8ad9-9fee-4ba3-9fc2-bcbd528f9890"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("e1782c27-1fc1-4988-8b88-94025f7dc7b2"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("f146e8cf-7198-400b-ae45-70e6287bdea6"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("f2cebf79-feff-4f67-9d0f-c8c02b4ada94"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("1ce0f36b-35f6-41b4-9bf6-ae1c826dc61b"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("b98a6937-829e-4834-afb5-032f51d0e5cb"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("fbe65cf5-676b-45dc-8772-05a15eb525ad"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("6fc52287-6d31-43bd-b092-40e72be42b09"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("80b5f45e-22b1-42b8-8dd4-53f3625cf53a"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("8b596700-cef7-40c7-90fe-6a0fad4fb0dd"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("bd799ba8-475b-47a4-9e88-f64af8be5843"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("098e8c9d-87d5-42e5-bfeb-787253180835"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("151c5f80-eaea-4233-a7fa-d951fdb3381f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("28179729-4f26-4667-8e49-0702b1789349"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("be5324a9-2702-4016-bc9e-3f2727ae981e"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("6142a667-7f16-410a-b87c-a2d2aa5804ca"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("792b2b03-311c-422f-b2ff-39bb405a5697"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a6d64d08-518d-47fa-b883-9033940a4695"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a9683d9-e090-416a-b6ed-62221c71214f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e17f931-a840-4cd8-b088-591069bcdc04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fcc4b018-9081-43a7-91e6-e82ff8a61fd7");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("38dc94be-3dcf-4314-a4e2-323d6485e76b"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("634febcc-7523-4269-9d01-e42f101eae0a"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("e44f9af6-655d-4628-8c98-875b03f5473a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("7b02a299-a291-4a3b-b359-2edc22899e77"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("b5cc19c4-755d-4198-8185-8d4786c49153"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("29ff0a1f-97aa-4772-8904-d49220db3694"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("2dcf6d43-60e4-40e3-a4c9-5863f5643cef"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("2dd66e1e-66ca-4b68-8fc7-5858e477488a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("8e0ef6b8-8979-46e8-9425-88d05b7083b3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("9210eeb1-8dc6-49d8-a423-132617edcd10"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("a3a2a614-9f7e-49bd-ab04-f5a65823b5b1"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("eb335c98-4143-4844-80fc-eb45f545b3b5"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("efd1e2df-888f-4ccb-a237-6f5ea21cefe0"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("f3fbf0eb-ef16-40c1-9bdc-0a7123176f08"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b8f91b50-04ff-4c47-8c64-90d4649580c9"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ca8a278-5910-40e7-ad31-af49f5ace38f"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a8b1424d-8270-49dd-b72c-e1896db13e75"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("ba93f744-6a18-42ca-84dc-e48d67855cb0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f44720f-855c-4319-8ef7-d871b99aed3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53e45d77-e821-4533-8290-440c385cc6d5");

            migrationBuilder.DropColumn(
                name: "Extra",
                table: "BurgerToppings");

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
    }
}
