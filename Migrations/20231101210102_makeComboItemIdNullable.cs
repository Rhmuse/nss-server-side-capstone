using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class makeComboItemIdNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<Guid>(
                name: "ComboItemId",
                table: "OrderSides",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5279e80-452e-4245-a0e1-86f14dcf874c", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738221cc-a232-4149-a219-14b40b4d5da1", "AQAAAAIAAYagAAAAEN3jAdSXKO9WPI1J2hDWq3W7m3OiryOOc6iRdHQjzoDwGBEOc5ElbW4Vksu+ZrOH7Q==", "c6e16963-6019-4161-a2c9-ce0a486a060d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "180b6cd0-67cf-41e3-a455-05242aca0388", 0, "dd43873a-74cc-4735-9aeb-66ab9c190ef1", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHZN89nzVHNviOGepB2cn5eWKGjzVVX+yK/UCYhgvLIZ50b/28YnVNjVOq2vgGEKgw==", null, false, "d130467b-c46b-4c76-9437-edce44b5fe6c", false, "ekrabs" },
                    { "3bd3e038-0ad6-49fb-9006-e2b1e6d39502", 0, "19bc61e7-724d-4681-9229-e72e3776a815", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEMzaGDyhcGzDY87/nhKXLwEZ4jO1z0Rwa6XNZOlwIsbC2IwSWODCCKSy95ZcDLOtGA==", null, false, "2d456b79-fd4d-4850-998a-5b1d36050075", false, "ssquarepants" },
                    { "d126a2fa-7fa7-4c5a-9614-6ee754a6eff2", 0, "b6626f91-0cf7-4458-a3b0-22b376bf7eab", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEB9zhSsmGF+D3Dc5FUJRNy78MBUiJx6Ub2klY3FHB+MBawVk/aOmwGCLK2JUTWv1oA==", null, false, "4fd908f9-15f7-447f-b0d5-652ff41851c1", false, "pstar" },
                    { "d66951c7-644c-47cc-b630-bfdba94d2347", 0, "0c9cd966-7684-4998-a5de-3350f891d731", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEKJBN9xBMOSKFYzKJsRX3X1wApT8oJIdtZuIb1w+1Tn9XdUMPEzaJnt463s4ukuvog==", null, false, "bb701c42-209e-4d4f-83b4-6b7f77c8ebb5", false, "stentacles" }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, "double krabby patty", null, 1 },
                    { new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, "krabby patty", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("13da9af7-199c-4f71-bafd-443698195434"), false, "diet dr. kelp", 1f },
                    { new Guid("6f6b8768-2a83-4b1d-9d4b-a064a9b4d6db"), false, "seafoam soda", 1f },
                    { new Guid("72e7e72e-e7ab-46af-b32f-4346fe2794c6"), false, "water", 0.1f },
                    { new Guid("94b7bace-7b17-4cf2-897b-405e77219f9f"), false, "red tide", 1f },
                    { new Guid("be8135ef-d965-4195-a6de-96e70a4c275a"), false, "kelp shake", 1.5f },
                    { new Guid("cf165a7c-d75b-4e87-999d-0166db365738"), false, "dr. kelp", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3459abf7-be25-4859-a51f-e5bd02184923"), "here" },
                    { new Guid("869e3450-09f6-4193-bee8-0be90a395084"), "pickup" },
                    { new Guid("d8efa777-c551-4819-9245-1cc29acb1e4d"), "togo" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0ae9f5c6-e355-4df0-8b68-eb2fb0b450f0"), false, "seaweed salad", 2f },
                    { new Guid("3a055cc0-b10e-42e5-93d8-3c418ea9916d"), false, "coral bits", 1.25f },
                    { new Guid("6d3b3710-be54-4f4e-884f-b5527d57d59a"), false, "kelp fries", 1.25f },
                    { new Guid("9e6b8113-b679-4daf-9194-58ccc3b82cb7"), false, "oyster skins", 1.25f },
                    { new Guid("f645a7df-01e7-4af9-9107-d7ffe33d213b"), false, "barnacle rings", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "IsDeleted", "Name", "Price", "ShortHand" },
                values: new object[,]
                {
                    { new Guid("876cdea2-fd13-41db-9acf-17bd1db1d3b0"), false, "large", 0.45f, "lg" },
                    { new Guid("98fabc59-1598-4a62-85c2-2307114d7db0"), false, "small", 0f, "sm" },
                    { new Guid("d0e84746-6b63-4141-927b-0dd98fc4f663"), false, "medium", 0.2f, "md" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0b0d5372-d624-4759-b5e6-10f411a55c0f"), false, "pickle", 0.05f },
                    { new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c"), false, "patty", 1f },
                    { new Guid("3f7bdacb-7570-4be7-a410-418ead2d3d57"), false, "onion", 0.05f },
                    { new Guid("4037f0c5-78c8-4e3f-81c2-31fdc546f002"), false, "tomato", 0.05f },
                    { new Guid("696482ed-5cde-48c7-b432-8adb4fc2cd90"), false, "lettuce", 0.05f },
                    { new Guid("7644184a-83e7-4178-8016-5eeb4d94546d"), false, "mustard", 0f },
                    { new Guid("bce53e03-17db-4f8f-a6e9-d1f95dc142cf"), false, "bun", 0.2f },
                    { new Guid("d15255a6-ab32-4c0b-a20e-0794ba82566f"), false, "ketchup", 0f },
                    { new Guid("e85f7aec-6215-44d1-9546-8f624df7270a"), false, "secret sauce", 0f },
                    { new Guid("ff6b04ce-7fd9-455b-9ae9-6790af08eb67"), false, "sea cheese", 0.25f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("17b74955-70d1-4f13-8705-879f18b7808a"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "180b6cd0-67cf-41e3-a455-05242aca0388" },
                    { "d5279e80-452e-4245-a0e1-86f14dcf874c", "3bd3e038-0ad6-49fb-9006-e2b1e6d39502" },
                    { "d5279e80-452e-4245-a0e1-86f14dcf874c", "d66951c7-644c-47cc-b630-bfdba94d2347" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("05fc8b17-1400-4bd7-ac34-297f023bbc74"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("4037f0c5-78c8-4e3f-81c2-31fdc546f002") },
                    { new Guid("0fdcddf3-63d6-4521-9c4e-44e0a3307395"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("d15255a6-ab32-4c0b-a20e-0794ba82566f") },
                    { new Guid("39f2fe10-e4a1-4bfd-b000-f41a9b8c172b"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("3f7bdacb-7570-4be7-a410-418ead2d3d57") },
                    { new Guid("3ab1b063-9cbc-47ec-babc-83a1bf9a9cac"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("bce53e03-17db-4f8f-a6e9-d1f95dc142cf") },
                    { new Guid("42b6fd44-8d5c-4eb1-94eb-ca7fc8348afe"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("4037f0c5-78c8-4e3f-81c2-31fdc546f002") },
                    { new Guid("4aef18c5-3fe7-4b14-a0dd-89dc903963c7"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("7644184a-83e7-4178-8016-5eeb4d94546d") },
                    { new Guid("5246a7d3-3805-4dc0-a7f6-fe70b5c3d823"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("0b0d5372-d624-4759-b5e6-10f411a55c0f") },
                    { new Guid("67d61c0b-297a-481d-909d-56e6a6ab9f03"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("696482ed-5cde-48c7-b432-8adb4fc2cd90") },
                    { new Guid("8afe7108-7abb-4b67-90fb-9e21859402cf"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c") },
                    { new Guid("910be51a-d7fa-4933-904f-720e1c061048"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("3f7bdacb-7570-4be7-a410-418ead2d3d57") },
                    { new Guid("a3dc5217-1bbd-43cc-9e9b-72201c9f1bfa"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("bce53e03-17db-4f8f-a6e9-d1f95dc142cf") },
                    { new Guid("b11085b8-0702-4a0c-ad61-60d03daca937"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("e85f7aec-6215-44d1-9546-8f624df7270a") },
                    { new Guid("b59d2e83-a7e8-4264-bd0e-581ea16764b3"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("e85f7aec-6215-44d1-9546-8f624df7270a") },
                    { new Guid("b7177dd4-4c0a-4173-97a9-e0ed243969f2"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("7644184a-83e7-4178-8016-5eeb4d94546d") },
                    { new Guid("c1ba07d1-5fa5-4afd-a0cc-5db746286586"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c") },
                    { new Guid("ce746e63-4832-476b-a00c-4a118df261d8"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("696482ed-5cde-48c7-b432-8adb4fc2cd90") },
                    { new Guid("cedc8f4a-b280-4fae-ab2d-4288c266d72c"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), false, new Guid("0b0d5372-d624-4759-b5e6-10f411a55c0f") },
                    { new Guid("d051e0b5-a0fa-4dcf-93f4-4c2d0483f0ab"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("d15255a6-ab32-4c0b-a20e-0794ba82566f") },
                    { new Guid("f686f905-aed9-4e18-860c-a471d1b32b8a"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), false, new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("591d2a60-1e1f-4e45-8d8e-60d967bb0baa"), new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"), -1.25f, false, "double krabby patty combo" },
                    { new Guid("a4b488ec-422e-4430-a688-79f65bfc72a3"), new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"), -1f, false, "krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("0291710e-42ee-4980-b4fd-4425764cf7f2"), "124 Conch Street", "SpongeBob", "3bd3e038-0ad6-49fb-9006-e2b1e6d39502", "SquarePants" },
                    { new Guid("1c72002e-1442-4b19-a3c1-ab63e84c658a"), "120 Conch Street", "Patrick", "d126a2fa-7fa7-4c5a-9614-6ee754a6eff2", "Star" },
                    { new Guid("d550e971-01c2-426b-aa99-b8a96c224bc1"), "122 Conch Street", "Squidward", "d66951c7-644c-47cc-b630-bfdba94d2347", "Tentacles" },
                    { new Guid("e5cd5c90-1239-4360-8c62-eed8b66ae066"), "3541 Anchor Way", "Eugene", "180b6cd0-67cf-41e3-a455-05242aca0388", "Krabs" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77"), new Guid("1c72002e-1442-4b19-a3c1-ab63e84c658a"), new Guid("d550e971-01c2-426b-aa99-b8a96c224bc1"), new DateTime(2023, 11, 1, 16, 1, 2, 469, DateTimeKind.Local).AddTicks(9966), new Guid("3459abf7-be25-4859-a51f-e5bd02184923") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "IsDeleted", "Name", "OrderId", "Quantity" },
                values: new object[] { new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, null, new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77"), 1 });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("33da7646-ddca-410f-b6b7-949c7c51afd9"), new Guid("591d2a60-1e1f-4e45-8d8e-60d967bb0baa"), new Guid("8010148d-fb39-4e40-9e77-2a16d915a63a"), new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77") },
                    { new Guid("3e8f95ea-b484-4d03-8e81-b797178c2433"), new Guid("591d2a60-1e1f-4e45-8d8e-60d967bb0baa"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77") },
                    { new Guid("ec801b14-31e4-4d5c-a7b0-a90258e1ccf9"), new Guid("591d2a60-1e1f-4e45-8d8e-60d967bb0baa"), new Guid("fec16524-94e2-40ab-ae74-b1934929a94a"), new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77") }
                });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("8010148d-fb39-4e40-9e77-2a16d915a63a"), new Guid("94b7bace-7b17-4cf2-897b-405e77219f9f"), new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77"), 1, new Guid("d0e84746-6b63-4141-927b-0dd98fc4f663") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("fec16524-94e2-40ab-ae74-b1934929a94a"), null, new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77"), 1, new Guid("3a055cc0-b10e-42e5-93d8-3c418ea9916d"), new Guid("876cdea2-fd13-41db-9acf-17bd1db1d3b0") });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "Extra", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("001b0143-663b-4081-b157-fd0b67e5019d"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("e85f7aec-6215-44d1-9546-8f624df7270a") },
                    { new Guid("136fe276-f7f5-4db1-81b5-f3be24882536"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("4037f0c5-78c8-4e3f-81c2-31fdc546f002") },
                    { new Guid("4c21413d-50df-4260-a50b-b90db7ee864c"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("3f7bdacb-7570-4be7-a410-418ead2d3d57") },
                    { new Guid("69f95c8e-afed-462b-aa04-bdb5aba32a04"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("7644184a-83e7-4178-8016-5eeb4d94546d") },
                    { new Guid("6ee46010-b0a6-4fd7-9708-eb1b08dafaf0"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("0b0d5372-d624-4759-b5e6-10f411a55c0f") },
                    { new Guid("8ac76d24-88b7-40d4-a519-338bd5b106bf"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c") },
                    { new Guid("9a2e0b62-5742-4b6b-842a-61bda6c2411a"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("bce53e03-17db-4f8f-a6e9-d1f95dc142cf") },
                    { new Guid("cb2efe73-cef4-44f1-b8e2-6a9dd02ada2c"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("d15255a6-ab32-4c0b-a20e-0794ba82566f") },
                    { new Guid("d1973675-0b01-4620-a07b-e6564b00ad80"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c") },
                    { new Guid("ed9b726b-f423-4a28-9d9a-f75ebf9a5554"), new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"), false, new Guid("696482ed-5cde-48c7-b432-8adb4fc2cd90") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Combos_BurgerId",
                table: "Combos",
                column: "BurgerId");

            migrationBuilder.CreateIndex(
                name: "IX_ComboItems_OrderId",
                table: "ComboItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComboItems_Orders_OrderId",
                table: "ComboItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Burgers_BurgerId",
                table: "Combos",
                column: "BurgerId",
                principalTable: "Burgers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComboItems_Orders_OrderId",
                table: "ComboItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Burgers_BurgerId",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_BurgerId",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_ComboItems_OrderId",
                table: "ComboItems");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "180b6cd0-67cf-41e3-a455-05242aca0388" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5279e80-452e-4245-a0e1-86f14dcf874c", "3bd3e038-0ad6-49fb-9006-e2b1e6d39502" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5279e80-452e-4245-a0e1-86f14dcf874c", "d66951c7-644c-47cc-b630-bfdba94d2347" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("001b0143-663b-4081-b157-fd0b67e5019d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("05fc8b17-1400-4bd7-ac34-297f023bbc74"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("0fdcddf3-63d6-4521-9c4e-44e0a3307395"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("136fe276-f7f5-4db1-81b5-f3be24882536"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("39f2fe10-e4a1-4bfd-b000-f41a9b8c172b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("3ab1b063-9cbc-47ec-babc-83a1bf9a9cac"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("42b6fd44-8d5c-4eb1-94eb-ca7fc8348afe"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4aef18c5-3fe7-4b14-a0dd-89dc903963c7"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4c21413d-50df-4260-a50b-b90db7ee864c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("5246a7d3-3805-4dc0-a7f6-fe70b5c3d823"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("67d61c0b-297a-481d-909d-56e6a6ab9f03"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("69f95c8e-afed-462b-aa04-bdb5aba32a04"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6ee46010-b0a6-4fd7-9708-eb1b08dafaf0"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8ac76d24-88b7-40d4-a519-338bd5b106bf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("8afe7108-7abb-4b67-90fb-9e21859402cf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("910be51a-d7fa-4933-904f-720e1c061048"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9a2e0b62-5742-4b6b-842a-61bda6c2411a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a3dc5217-1bbd-43cc-9e9b-72201c9f1bfa"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b11085b8-0702-4a0c-ad61-60d03daca937"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b59d2e83-a7e8-4264-bd0e-581ea16764b3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b7177dd4-4c0a-4173-97a9-e0ed243969f2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c1ba07d1-5fa5-4afd-a0cc-5db746286586"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cb2efe73-cef4-44f1-b8e2-6a9dd02ada2c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ce746e63-4832-476b-a00c-4a118df261d8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cedc8f4a-b280-4fae-ab2d-4288c266d72c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d051e0b5-a0fa-4dcf-93f4-4c2d0483f0ab"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d1973675-0b01-4620-a07b-e6564b00ad80"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ed9b726b-f423-4a28-9d9a-f75ebf9a5554"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f686f905-aed9-4e18-860c-a471d1b32b8a"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("33da7646-ddca-410f-b6b7-949c7c51afd9"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("3e8f95ea-b484-4d03-8e81-b797178c2433"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("ec801b14-31e4-4d5c-a7b0-a90258e1ccf9"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("591d2a60-1e1f-4e45-8d8e-60d967bb0baa"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("a4b488ec-422e-4430-a688-79f65bfc72a3"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("13da9af7-199c-4f71-bafd-443698195434"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("6f6b8768-2a83-4b1d-9d4b-a064a9b4d6db"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("72e7e72e-e7ab-46af-b32f-4346fe2794c6"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("be8135ef-d965-4195-a6de-96e70a4c275a"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("cf165a7c-d75b-4e87-999d-0166db365738"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("8010148d-fb39-4e40-9e77-2a16d915a63a"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("fec16524-94e2-40ab-ae74-b1934929a94a"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("869e3450-09f6-4193-bee8-0be90a395084"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("d8efa777-c551-4819-9245-1cc29acb1e4d"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("0ae9f5c6-e355-4df0-8b68-eb2fb0b450f0"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("6d3b3710-be54-4f4e-884f-b5527d57d59a"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("9e6b8113-b679-4daf-9194-58ccc3b82cb7"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("f645a7df-01e7-4af9-9107-d7ffe33d213b"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("876cdea2-fd13-41db-9acf-17bd1db1d3b0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("98fabc59-1598-4a62-85c2-2307114d7db0"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: new Guid("d0e84746-6b63-4141-927b-0dd98fc4f663"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("ff6b04ce-7fd9-455b-9ae9-6790af08eb67"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("0291710e-42ee-4980-b4fd-4425764cf7f2"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("17b74955-70d1-4f13-8705-879f18b7808a"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("e5cd5c90-1239-4360-8c62-eed8b66ae066"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5279e80-452e-4245-a0e1-86f14dcf874c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "180b6cd0-67cf-41e3-a455-05242aca0388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3bd3e038-0ad6-49fb-9006-e2b1e6d39502");

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("13459a5d-e20f-4a27-984c-f29de7c88231"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("803fd7d6-20bc-4ef8-a3e5-c0bb6eab0c5b"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("bef39fd0-e03e-44a1-b436-a111aa1a64f6"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("94b7bace-7b17-4cf2-897b-405e77219f9f"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("3a055cc0-b10e-42e5-93d8-3c418ea9916d"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0b0d5372-d624-4759-b5e6-10f411a55c0f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("3e4d6ab3-7beb-4aec-bd8b-1a1876a8030c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("3f7bdacb-7570-4be7-a410-418ead2d3d57"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("4037f0c5-78c8-4e3f-81c2-31fdc546f002"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("696482ed-5cde-48c7-b432-8adb4fc2cd90"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7644184a-83e7-4178-8016-5eeb4d94546d"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("bce53e03-17db-4f8f-a6e9-d1f95dc142cf"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("d15255a6-ab32-4c0b-a20e-0794ba82566f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("e85f7aec-6215-44d1-9546-8f624df7270a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f58affd2-79dc-42a2-ae88-1220a97a4f77"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("3459abf7-be25-4859-a51f-e5bd02184923"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("1c72002e-1442-4b19-a3c1-ab63e84c658a"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d550e971-01c2-426b-aa99-b8a96c224bc1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d126a2fa-7fa7-4c5a-9614-6ee754a6eff2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d66951c7-644c-47cc-b630-bfdba94d2347");

            migrationBuilder.AlterColumn<Guid>(
                name: "ComboItemId",
                table: "OrderSides",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

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
    }
}
