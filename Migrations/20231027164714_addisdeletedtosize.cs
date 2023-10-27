using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class addisdeletedtosize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "adfbdde0-4137-4da0-a236-940faca4bbf0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76f3405d-c548-4d39-8df5-5fd105406eaf", "f45c916f-1254-4845-8c6f-aa2a8c73fab9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76f3405d-c548-4d39-8df5-5fd105406eaf", "fda0ed28-b9ca-40e6-9037-eba5832459b9" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("08a85525-16ad-4c58-841a-f758dff3f1d6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0bcbedd2-99f8-4b08-86f0-90edce6dbd52"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0e57fc9b-19e5-4ab3-acab-ee0c58ad4628"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1894f331-49e3-48d7-b4a3-5ef8897ab56b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1f57633c-9243-4d66-a37f-6828cb823bf4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("29058c1a-53bb-4c64-9b85-ebffe72c3cbd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("33047f9a-e740-4fc0-81cf-84d2d0afd4c5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("45e23aa5-d296-442a-8344-375b5802ae45"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("59f79e4d-441c-4e5f-a7d0-65b22957fc03"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("63b68222-9bb5-4769-adc0-e30c1ae2c77c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("67422b0c-11b2-4283-8181-6293e42f578b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6dae9d4d-ec46-458b-a67f-7fb1f285c54b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6fc7712a-210a-4635-b1e5-0b2c5e249dfe"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8c28630d-5b27-4c93-b12f-ae30562c45c8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("920c3d25-0710-4cbe-be30-0cff1e7b49d7"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9294fc26-9698-47c9-82dd-0ece19c7c37e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("92aff036-6066-48e7-bc44-b5f06462a60a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a02ca4f5-f98a-4c5e-8b2c-f053c74983cf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a739380c-0887-4a5a-835f-f390457408b5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b6ce29c1-6ac6-4ffe-8841-0fc4216987e5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c1031eba-a255-47bd-9a4c-b76f7b65dc10"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c42bc2c5-6155-47ac-8f55-48100b1cd383"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cbf27de8-9c74-481d-81f3-6f71796e3fd1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cd8008d6-4d57-47b4-9391-c5b366e487f9"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d0374f34-2ff3-43bd-8821-7fb3faabc2ff"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d19085b0-175a-4179-b327-503f0e18af0f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ecf72ae4-79f0-450c-b3ce-cfe2c201455b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ed645e77-bc25-45e9-b429-a93c7f9d29e6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f8ebaeb0-bf22-4efb-8479-fa857a7eb4e9"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("6f433746-1e6f-4b8a-89ef-12a5b42bed3c"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("7bf1755e-0b70-4533-9bec-c61647a5f54c"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("ad2c73b8-06e4-4bda-b506-3a01dc5d818b"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("002ea8cf-c0cb-4df9-a01a-4f8643355a32"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("e44b6e20-493b-4f8f-86bb-dccc29a4f3fe"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("00856106-03e6-4b79-928b-adc13311f92c"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("4dfe9945-5b5c-4ac3-a693-3391d888dfed"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("9ccf65fe-6216-4570-9889-e6661e3334a4"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("a728417d-4b6f-4b11-b0e6-cf3e4c7f9b0c"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("e03f0e6b-699c-4452-a3bf-a23f528cec7c"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("034c2400-e07a-4642-8147-e1a4f5f27333"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("2fa7d04c-3cb8-4e80-844f-f7c3e870be9a"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("2a9b9b55-22c0-44b8-83cd-cf06a16982c0"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("8b9196b0-3cf7-45ae-95ec-cc369c34464b"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("18614fbd-91ce-4329-80dc-754fabe4bf4f"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("2727c75e-92b9-4e97-a576-e0957fbd2c5f"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("b59f5921-fb41-4c89-beae-340473a25990"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("e9e89f13-e3d3-4bfd-ab1d-a6b7dd6bdc0e"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("24428db6-9d06-45f3-a02f-3eb06cf63669"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("373462c5-f90b-4125-9a59-efc3692b1d7a"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("cc92aca0-fe16-4b18-88a0-6c798a508469"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("62a34a87-60ce-443c-90f5-108dbe4e2dd7"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("b78f00c3-e837-48dc-a1ed-db755bcf5263"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("fe06653f-cbde-456e-a447-aa6f1480d219"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("ff1c6961-8579-49a0-ba4f-14944976a561"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76f3405d-c548-4d39-8df5-5fd105406eaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adfbdde0-4137-4da0-a236-940faca4bbf0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f45c916f-1254-4845-8c6f-aa2a8c73fab9");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("48181d82-9754-4f60-98e9-d845efdedf0c"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("52821fc6-3b27-41c5-9bdf-d65b3493eb55"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("fc93e2c1-3eda-48b2-9c72-a90895fa9942"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("d28b90a8-fe7c-463d-9ddb-7af68864ff45"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("4ccd58b2-57de-47af-98ef-da75a315ab78"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("19d53262-c2ba-4c5b-80f6-2cb0c70f468c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("1dc23006-68fb-4fa3-b4cc-0d3897011299"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("292c221d-94f4-4bb5-843c-dbf66a2d10f3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("3835b77e-d016-48e3-8f68-d0e9ab5f8739"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("3cdcab2b-8e87-473a-8d79-cbaf65010e77"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("47605247-b3c4-445a-a62c-cc08f938c1a4"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("51bae8ec-0e4c-4e62-aa73-8ea1248139c4"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("a7527fc4-86d7-4730-a97a-18b8b554a77e"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("ce3dcf04-d1d7-4152-876a-e96782569b08"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("532a218c-744b-4f9d-9af1-ec7d96c489cb"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("c43dac35-214d-45ab-9777-237818dfbbcf"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("12c557a5-c321-4131-b0bd-b1520b68655b"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("23170bda-5e4e-4183-a1c3-1cf6ac1d9059"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b06e00ba-4ca2-467e-9dab-0cc033063a8e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fda0ed28-b9ca-40e6-9037-eba5832459b9");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Sizes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6009515-aff8-4ba2-9ea8-550b697a3a98", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283b2e5a-b3bf-490f-bf89-825fd8f2e535", "AQAAAAIAAYagAAAAEIPkRsgv/txeOsEjcOQRVU3psjyh8jeZeLnJcArYA4iFJO06H0bQAeTYWbX9TZykBQ==", "7eb25115-e975-4a1b-b8c4-56803d3537d6" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ca9645c-e3bd-41f7-af8e-e09b5d0a2aa3", 0, "68522992-003a-4c15-9e5f-f2d943d956cb", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKV/Da381wUTl8GmsmzxlE4l3d+eDLlb8C5Ar/3UKo0n+AxGEibpxyw/TB/e28AGew==", null, false, "dc76a384-9216-46a0-b4ab-6264b838f2e5", false, "stentacles" },
                    { "8d500f4d-149e-4434-9240-2a03d3c88ab7", 0, "bd6d671a-8cf2-46bc-8524-034779572dfd", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMkH3r6/Gb+X307OLhiN9arzf9udocDN6fWt0q1snwlgyDcQpgX/7s5BbFqNCwLd/A==", null, false, "7432b3e6-65d8-4632-9989-31ca2a6eccbc", false, "ssquarepants" },
                    { "8d6ffe92-e1eb-466a-a207-ba96e3765c8f", 0, "56d14d2f-bf17-4528-bd3e-94b60018941c", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBq6iCzBHA8mKdP0wD1vJCoxe1qy9WygGHWE1slcpWAaMr6K0wfD+y+V70Epl1XkTA==", null, false, "07515c2c-ac11-4722-8b3b-0e8053cac0dd", false, "ekrabs" },
                    { "efc130ee-1790-478a-b5c8-af10185ccaac", 0, "43c2bf34-9fdb-4e1e-b5cd-40ddf813a346", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEH0qUvZX8VGIEmz8etGfs77zkGq+dA+LzjZRQKkYUW+/OivPfHVrF0+tJMzCciMuBA==", null, false, "3f70fc38-e8e4-48f4-aff2-987196b6045b", false, "pstar" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, "double krabby patty", null, 1 },
                    { new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, "krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("704925ba-7ca8-451b-b136-f0e6a8416f29"), new Guid("aec7855f-bc7a-461b-ae62-7235792fd5df"), new Guid("57b776c1-2632-43f2-b7a8-7a5b648e8280"), new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68") },
                    { new Guid("c83f89b5-8a27-4b64-aa31-2cff91c34c6d"), new Guid("aec7855f-bc7a-461b-ae62-7235792fd5df"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68") },
                    { new Guid("f226ada8-ccea-4a33-914f-56846001dfce"), new Guid("aec7855f-bc7a-461b-ae62-7235792fd5df"), new Guid("072523af-da58-481b-a88a-3f5afedac225"), new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("917f007b-3fc8-498c-ac8a-f013b1bc93a1"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), -1f, false, "krabby patty combo" },
                    { new Guid("aec7855f-bc7a-461b-ae62-7235792fd5df"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), -1.25f, false, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("20cb9dae-2997-40f3-895c-b667f6999ecc"), false, "kelp shake", 1.5f },
                    { new Guid("249790a4-86fa-47a7-837c-ceedda462b5e"), false, "red tide", 1f },
                    { new Guid("48338b1a-2cfc-43c8-8556-9047ec8f0518"), false, "seafoam soda", 1f },
                    { new Guid("649871b1-02ba-4f14-9ad9-4a053f81231b"), false, "dr. kelp", 1f },
                    { new Guid("9fb2e1b1-0589-4c23-bb4f-c20c83327e00"), false, "water", 0.1f },
                    { new Guid("c09f722e-b8de-4365-aceb-8674d4213335"), false, "diet dr. kelp", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("51e19d95-e4b8-4c12-91f8-fad9257575c0"), "pickup" },
                    { new Guid("7fe01976-7118-4cb2-97d7-66f9313d9193"), "togo" },
                    { new Guid("f859731c-a421-493e-bc41-e7f16fbcc530"), "here" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("030b3007-1c19-4d0c-bb3e-0e08e33431e1"), false, "coral bits", 1.25f },
                    { new Guid("497f13a2-0fd2-45ef-8b6a-621da20e0069"), false, "kelp fries", 1.25f },
                    { new Guid("6fd6d9e0-39b6-48ac-aae4-887e3c82eeb8"), false, "barnacle rings", 1.25f },
                    { new Guid("9d17cc02-bf0e-4f9e-be35-2cffdade4b9a"), false, "oyster skins", 1.25f },
                    { new Guid("a0ae8c50-4df5-4eb4-9816-898250f89044"), false, "seaweed salad", 2f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("0b1ee2f6-3356-4a98-aec5-158c9f9ab957"), false, "large", 0.45f, "lg" },
                    { new Guid("3baba7e3-f4ca-42bf-9092-929e013bd15f"), false, "medium", 0.2f, "md" },
                    { new Guid("3d56abcd-29ad-4112-a0a6-b396ddb66c44"), false, "small", 0f, "sm" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("010072b6-2c6b-4e83-b8b8-1b4379c34551"), false, "onion", 0.05f },
                    { new Guid("0469ced1-b1a3-40c7-92a1-f9bc81795aa3"), false, "bun", 0.2f },
                    { new Guid("15000563-d4e1-4183-a5ad-8a14018683b1"), false, "patty", 1f },
                    { new Guid("22c4ce22-ea43-435e-81d5-71bf033a4e9c"), false, "mustard", 0f },
                    { new Guid("7e6f7488-d850-481d-8524-c3fdf3ef2855"), false, "pickle", 0.05f },
                    { new Guid("7f1e9e24-4565-4a30-96ae-7fba80bf8f53"), false, "secret sauce", 0f },
                    { new Guid("890bfcff-8428-4253-a307-9d433f6b202f"), false, "ketchup", 0f },
                    { new Guid("ab7df5ce-1e85-46eb-8073-1ab798da0711"), false, "sea cheese", 0.25f },
                    { new Guid("ac3917df-f853-4ae8-bcf8-d7df93a09e1c"), false, "tomato", 0.05f },
                    { new Guid("cd45b699-5373-4c42-ae64-e6c1b83cc4d1"), false, "lettuce", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("2dad7804-a5a6-4c8b-b339-733eb5e2247d"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "a6009515-aff8-4ba2-9ea8-550b697a3a98", "5ca9645c-e3bd-41f7-af8e-e09b5d0a2aa3" },
                    { "a6009515-aff8-4ba2-9ea8-550b697a3a98", "8d500f4d-149e-4434-9240-2a03d3c88ab7" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "8d6ffe92-e1eb-466a-a207-ba96e3765c8f" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("13cda622-7e27-4b3f-8792-fd0ae9763ca4"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("15000563-d4e1-4183-a5ad-8a14018683b1") },
                    { new Guid("13e0aa44-f3d4-441c-be78-d1d9cfc8ad03"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("0469ced1-b1a3-40c7-92a1-f9bc81795aa3") },
                    { new Guid("1b19f120-23b9-4240-8f31-9c8be9320294"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("7f1e9e24-4565-4a30-96ae-7fba80bf8f53") },
                    { new Guid("63580421-c6cf-41a6-a80f-e73d2de72c08"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("7e6f7488-d850-481d-8524-c3fdf3ef2855") },
                    { new Guid("6de0ea87-86c5-47a5-a0eb-4e0992ccc148"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("22c4ce22-ea43-435e-81d5-71bf033a4e9c") },
                    { new Guid("78902908-ce66-4bc3-b6f8-ea594252048b"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("15000563-d4e1-4183-a5ad-8a14018683b1") },
                    { new Guid("89401aab-0dd2-49e9-adee-6b674651d2d9"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("7e6f7488-d850-481d-8524-c3fdf3ef2855") },
                    { new Guid("8d9bb707-fa79-4791-ae28-fda6cca6c3a3"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("890bfcff-8428-4253-a307-9d433f6b202f") },
                    { new Guid("901b8537-73fa-4294-bbc6-cb352c8aec61"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("22c4ce22-ea43-435e-81d5-71bf033a4e9c") },
                    { new Guid("9399f89f-9123-49e0-a075-6cddaf5386c3"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("010072b6-2c6b-4e83-b8b8-1b4379c34551") },
                    { new Guid("aff6b61b-6029-49a2-83f0-e7dee2e3ca9e"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("890bfcff-8428-4253-a307-9d433f6b202f") },
                    { new Guid("b1de3920-9ce7-42a2-8ff0-4fac23626bf6"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("0469ced1-b1a3-40c7-92a1-f9bc81795aa3") },
                    { new Guid("b3994ed3-4df2-4575-8228-9ddea87b011d"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("cd45b699-5373-4c42-ae64-e6c1b83cc4d1") },
                    { new Guid("b4079e65-e686-4e90-945b-c65feac63cfd"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("15000563-d4e1-4183-a5ad-8a14018683b1") },
                    { new Guid("b760d8bb-4b18-43d2-8c28-cd3961024089"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("ac3917df-f853-4ae8-bcf8-d7df93a09e1c") },
                    { new Guid("c9b59149-230d-4d82-a8d9-8fd037b5b1a1"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("7f1e9e24-4565-4a30-96ae-7fba80bf8f53") },
                    { new Guid("d7b99187-f031-4092-b969-ceefb34a0a75"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("ac3917df-f853-4ae8-bcf8-d7df93a09e1c") },
                    { new Guid("defd21d4-c853-44f1-a84f-a46cfa1c1c4f"), new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"), false, new Guid("010072b6-2c6b-4e83-b8b8-1b4379c34551") },
                    { new Guid("e3c7ea6a-fdfd-4bc4-800f-3a5fa66eed4f"), new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"), false, new Guid("cd45b699-5373-4c42-ae64-e6c1b83cc4d1") }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("330a8858-e7e8-4046-97d6-480e7e342368"), "124 Conch Street", "SpongeBob", "8d500f4d-149e-4434-9240-2a03d3c88ab7", "SquarePants" },
                    { new Guid("57d232a8-baa2-4f92-b26f-40b1409243d1"), "120 Conch Street", "Patrick", "efc130ee-1790-478a-b5c8-af10185ccaac", "Star" },
                    { new Guid("82ff7723-205a-4ea1-8ab4-c63bb2320c20"), "3541 Anchor Way", "Eugene", "8d6ffe92-e1eb-466a-a207-ba96e3765c8f", "Krabs" },
                    { new Guid("97cde3a3-379a-498a-b7d8-a7fa645d2d80"), "122 Conch Street", "Squidward", "5ca9645c-e3bd-41f7-af8e-e09b5d0a2aa3", "Tentacles" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68"), new Guid("57d232a8-baa2-4f92-b26f-40b1409243d1"), new Guid("97cde3a3-379a-498a-b7d8-a7fa645d2d80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f859731c-a421-493e-bc41-e7f16fbcc530") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, null, new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("072523af-da58-481b-a88a-3f5afedac225"), new Guid("249790a4-86fa-47a7-837c-ceedda462b5e"), new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68"), 1, new Guid("3baba7e3-f4ca-42bf-9092-929e013bd15f") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("57b776c1-2632-43f2-b7a8-7a5b648e8280"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68"), 1, new Guid("030b3007-1c19-4d0c-bb3e-0e08e33431e1"), new Guid("0b1ee2f6-3356-4a98-aec5-158c9f9ab957") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("32e4a955-b4f8-497d-a6f9-71e4ead9c70c"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("15000563-d4e1-4183-a5ad-8a14018683b1") },
                    { new Guid("4765b052-e03b-4f6b-b9a1-31d926c02070"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("010072b6-2c6b-4e83-b8b8-1b4379c34551") },
                    { new Guid("47b59770-ea72-4c34-a8f4-8fc549db3bb4"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("890bfcff-8428-4253-a307-9d433f6b202f") },
                    { new Guid("8aaa89ca-e59d-46d3-917d-f3b4e19928ad"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("ac3917df-f853-4ae8-bcf8-d7df93a09e1c") },
                    { new Guid("c180bae4-c384-4bde-8819-3ece9418c4ac"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("22c4ce22-ea43-435e-81d5-71bf033a4e9c") },
                    { new Guid("d13c27a8-41a0-48c3-ab7e-6e8bed4f9579"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("7f1e9e24-4565-4a30-96ae-7fba80bf8f53") },
                    { new Guid("ef9afe83-7f74-4e73-8d71-f49f7b722574"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("15000563-d4e1-4183-a5ad-8a14018683b1") },
                    { new Guid("f44b808e-8028-414b-a163-9f9ef21dd81c"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("7e6f7488-d850-481d-8524-c3fdf3ef2855") },
                    { new Guid("f981157e-04f7-4f30-9e50-41227f127cb3"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("cd45b699-5373-4c42-ae64-e6c1b83cc4d1") },
                    { new Guid("fd0b726d-d2fd-42b0-bf49-428bc3cc72a8"), new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"), false, new Guid("0469ced1-b1a3-40c7-92a1-f9bc81795aa3") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6009515-aff8-4ba2-9ea8-550b697a3a98", "5ca9645c-e3bd-41f7-af8e-e09b5d0a2aa3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a6009515-aff8-4ba2-9ea8-550b697a3a98", "8d500f4d-149e-4434-9240-2a03d3c88ab7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "8d6ffe92-e1eb-466a-a207-ba96e3765c8f" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("13cda622-7e27-4b3f-8792-fd0ae9763ca4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("13e0aa44-f3d4-441c-be78-d1d9cfc8ad03"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1b19f120-23b9-4240-8f31-9c8be9320294"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("32e4a955-b4f8-497d-a6f9-71e4ead9c70c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4765b052-e03b-4f6b-b9a1-31d926c02070"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("47b59770-ea72-4c34-a8f4-8fc549db3bb4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("63580421-c6cf-41a6-a80f-e73d2de72c08"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6de0ea87-86c5-47a5-a0eb-4e0992ccc148"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("78902908-ce66-4bc3-b6f8-ea594252048b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("89401aab-0dd2-49e9-adee-6b674651d2d9"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8aaa89ca-e59d-46d3-917d-f3b4e19928ad"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8d9bb707-fa79-4791-ae28-fda6cca6c3a3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("901b8537-73fa-4294-bbc6-cb352c8aec61"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9399f89f-9123-49e0-a075-6cddaf5386c3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("aff6b61b-6029-49a2-83f0-e7dee2e3ca9e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b1de3920-9ce7-42a2-8ff0-4fac23626bf6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b3994ed3-4df2-4575-8228-9ddea87b011d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b4079e65-e686-4e90-945b-c65feac63cfd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b760d8bb-4b18-43d2-8c28-cd3961024089"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c180bae4-c384-4bde-8819-3ece9418c4ac"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c9b59149-230d-4d82-a8d9-8fd037b5b1a1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d13c27a8-41a0-48c3-ab7e-6e8bed4f9579"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d7b99187-f031-4092-b969-ceefb34a0a75"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("defd21d4-c853-44f1-a84f-a46cfa1c1c4f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e3c7ea6a-fdfd-4bc4-800f-3a5fa66eed4f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ef9afe83-7f74-4e73-8d71-f49f7b722574"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f44b808e-8028-414b-a163-9f9ef21dd81c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f981157e-04f7-4f30-9e50-41227f127cb3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fd0b726d-d2fd-42b0-bf49-428bc3cc72a8"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("704925ba-7ca8-451b-b136-f0e6a8416f29"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("c83f89b5-8a27-4b64-aa31-2cff91c34c6d"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("f226ada8-ccea-4a33-914f-56846001dfce"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("917f007b-3fc8-498c-ac8a-f013b1bc93a1"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("aec7855f-bc7a-461b-ae62-7235792fd5df"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("20cb9dae-2997-40f3-895c-b667f6999ecc"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("48338b1a-2cfc-43c8-8556-9047ec8f0518"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("649871b1-02ba-4f14-9ad9-4a053f81231b"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("9fb2e1b1-0589-4c23-bb4f-c20c83327e00"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("c09f722e-b8de-4365-aceb-8674d4213335"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("072523af-da58-481b-a88a-3f5afedac225"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("57b776c1-2632-43f2-b7a8-7a5b648e8280"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("51e19d95-e4b8-4c12-91f8-fad9257575c0"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("7fe01976-7118-4cb2-97d7-66f9313d9193"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("497f13a2-0fd2-45ef-8b6a-621da20e0069"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("6fd6d9e0-39b6-48ac-aae4-887e3c82eeb8"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("9d17cc02-bf0e-4f9e-be35-2cffdade4b9a"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("a0ae8c50-4df5-4eb4-9816-898250f89044"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("0b1ee2f6-3356-4a98-aec5-158c9f9ab957"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("3baba7e3-f4ca-42bf-9092-929e013bd15f"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("3d56abcd-29ad-4112-a0a6-b396ddb66c44"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("ab7df5ce-1e85-46eb-8073-1ab798da0711"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("2dad7804-a5a6-4c8b-b339-733eb5e2247d"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("330a8858-e7e8-4046-97d6-480e7e342368"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("82ff7723-205a-4ea1-8ab4-c63bb2320c20"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6009515-aff8-4ba2-9ea8-550b697a3a98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d500f4d-149e-4434-9240-2a03d3c88ab7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d6ffe92-e1eb-466a-a207-ba96e3765c8f");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("8f3e037e-0189-4e8e-b99b-f6bafc926695"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("9f2cd299-1ade-4721-b9e9-473c96f60cf6"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("db4d0d38-a648-47c9-bdd9-e66b3ecb3283"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("249790a4-86fa-47a7-837c-ceedda462b5e"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("030b3007-1c19-4d0c-bb3e-0e08e33431e1"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("010072b6-2c6b-4e83-b8b8-1b4379c34551"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0469ced1-b1a3-40c7-92a1-f9bc81795aa3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("15000563-d4e1-4183-a5ad-8a14018683b1"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("22c4ce22-ea43-435e-81d5-71bf033a4e9c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7e6f7488-d850-481d-8524-c3fdf3ef2855"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7f1e9e24-4565-4a30-96ae-7fba80bf8f53"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("890bfcff-8428-4253-a307-9d433f6b202f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("ac3917df-f853-4ae8-bcf8-d7df93a09e1c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("cd45b699-5373-4c42-ae64-e6c1b83cc4d1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("993bed38-91bf-470e-99b0-f0f8969e9d68"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("f859731c-a421-493e-bc41-e7f16fbcc530"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("57d232a8-baa2-4f92-b26f-40b1409243d1"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("97cde3a3-379a-498a-b7d8-a7fa645d2d80"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ca9645c-e3bd-41f7-af8e-e09b5d0a2aa3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efc130ee-1790-478a-b5c8-af10185ccaac");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Sizes");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "76f3405d-c548-4d39-8df5-5fd105406eaf", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65ab3a02-2cc4-4791-8c13-0f0162c9764c", "AQAAAAIAAYagAAAAEAkRP4XHi4knBHgNS10YpjPQeWgeHqQwtfEUX8MHLeMvkHm6WZsumu4M/gAsKCEHxA==", "904bbfb2-9b00-434a-9c3f-b37eee6a81c1" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "adfbdde0-4137-4da0-a236-940faca4bbf0", 0, "9f939765-72ee-472c-a530-dc6d89dd3a60", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDeBs0VYHb6pXMB95/K4xEffRFgQAXnvIrCi050U3rZpIfnONHG+MLTrNhc8wAf1+g==", null, false, "0b42ed69-8dc9-4cd7-b9d1-ba7a1e26cb6b", false, "ekrabs" },
                    { "b06e00ba-4ca2-467e-9dab-0cc033063a8e", 0, "3ef0eec0-fcf0-47f9-ae8a-5acb389a1d5a", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEGUGk35h8rYEHkuxHbkN+lQeCnAMaNOJ3ZIJ6Litznv2DJlLaBSpPXGLyjNKxSjNdA==", null, false, "c88b737e-46b0-402d-9a4b-a979b50cf764", false, "pstar" },
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
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("b78f00c3-e837-48dc-a1ed-db755bcf5263"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "adfbdde0-4137-4da0-a236-940faca4bbf0" },
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
        }
    }
}
