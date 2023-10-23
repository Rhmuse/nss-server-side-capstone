using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KrustyKrab.Migrations
{
    /// <inheritdoc />
    public partial class addSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserProfiles_CustomerId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "1730a8a1-5239-4905-86b5-32a6fa628603" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70498912-9de9-47fc-a5c3-7afd7b4431df", "67ce3d19-85fa-42e2-9379-5b91be295661" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "70498912-9de9-47fc-a5c3-7afd7b4431df", "aaecde13-1dee-4899-860a-07709cc7705c" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("009e534e-8450-4d11-95f1-76d1a3d757ef"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("07b6aea9-8b76-4aed-b546-160f907bd997"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("108146e4-abf6-45dd-9362-68ff97afd6e1"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1098a99b-327b-4b4e-833a-9e60a9aef46a"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("12f0eff8-d966-49e0-8c51-7736c2990b59"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1a04876d-95be-47aa-9b28-80412a2c8f84"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("21025b4f-d628-40d3-bac2-182245900815"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("448f2405-0f8c-405a-ba5e-9aa30824ca7c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("46b3770a-8d17-46b4-8d51-680ca2f521f3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("47114504-cc9f-4665-a2b9-5d86dfab7663"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4769774a-f91d-4720-a2c3-703481187342"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4823d565-65b8-4688-950d-2b76418b1d1f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("4d916587-e1d7-4498-b5eb-a1fa0d904144"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("60ec8ef2-a519-41ad-90ee-a2677c14fbd8"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("6f5bbade-fbd5-40df-a552-cb0e242457f6"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("74c914ab-66df-41d6-8a64-3c352fabe9ba"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("97bc626d-1961-4b86-ab24-0c4097c20bfd"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("9c286875-e6be-48e8-a89c-6e6908a07f72"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a00ee486-08a8-4620-b920-f4d27002a6ee"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("a68a7b47-8d87-43a1-887e-afb4c40e5820"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("aa1f930c-e033-49c3-92de-f9a98a6c0870"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c9f48fb5-7d25-4de1-8e19-9af707f5268f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("caedbc6f-d90f-4719-888e-1ab441d22817"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d0813a5c-d171-46ef-bccd-bd99d9d65eff"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e3ffb38d-5293-44b6-ba99-4270c18dc124"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f8936f22-e6a5-41e5-bfa2-054465051c25"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fb25ba82-fd8e-49c9-b8f1-9fee32ecc557"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fbc70c8e-2e49-4073-b45f-5bf70cafe7c2"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("fc29c64a-5183-44c3-9113-34ad0e8f3e6d"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("00d77779-7147-4d9b-91f4-5caae3deb1ef"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("3ccaf24b-04b1-440c-8ca5-45396b562ed9"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("82b06897-bf66-423b-95ff-5359d66c69f2"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("36aec262-07ad-4cc3-a793-95e9697ed275"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("381438f3-cba7-4718-b9b1-f0f6b8bb7802"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("9061f82a-bfaa-45ed-b96e-4fd94a605c68"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("243fb016-95f6-4d5c-8492-763eaf2342f4"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("3a912e55-f477-4e70-86a0-62446c8f3538"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("1645954e-43ec-4be6-9aba-1d262f8659df"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("236e5035-cba4-4dff-acd6-2dca83229cf4"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("2d0e08b6-443a-471d-990b-3f685cdf8862"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("b318597b-a1b8-458d-9989-496e6e7f8db0"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("b66a844e-b7f0-4561-b4d7-17c9fcbc2f09"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("d7df5d3f-cf52-4de1-8c0c-ecc7e93b2bd8"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("e27a7325-0635-4fe3-945c-877ba120b7e4"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("c33b0b6b-ae7e-44c6-ae0e-8d13d4dd1fc5"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("6da31e85-d0ae-4448-9a8c-266456d8d3d9"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("a9aca786-605a-4e8c-8014-b08a427aa6f3"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("1b91e550-4b23-459f-b3bf-263d106a7473"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("7589deb4-f186-45ec-aa68-c6562503ed03"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("8d1f0413-e42e-4fbc-87ab-e5f6805fc28c"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("c851712f-c663-4251-adbd-6820ca937f6c"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("ec9eafdd-84dc-4f50-8c43-d286477b3792"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("0c04937e-8885-480a-beed-2cf946c70819"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("209475f0-a4fa-4925-b7e3-a7aa5e6e474c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("5aeb25c2-2eb5-4eeb-94c4-3802a800b18c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("782452eb-eede-4b4a-9053-4c79328adb0f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("7fa0bb75-4ee9-417b-93ad-b1947a728652"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("89618a45-9bb3-45d0-b940-6ebcfd5cba3f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("9673aade-f07b-478b-894b-dc4d2282c847"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("99349758-1a84-42de-a927-e549195f7975"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("f741ce79-a158-40ac-bedc-d6473f441e46"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("fd1efc42-2c14-477b-908e-89363a258b3e"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("4c688e47-3132-43df-a2cd-473dc689e450"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9ceb4bba-c879-42c2-bd30-5f690006c40f"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("f8d5eec0-4e2d-49e9-8bbb-37e11e078efd"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70498912-9de9-47fc-a5c3-7afd7b4431df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1730a8a1-5239-4905-86b5-32a6fa628603");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67ce3d19-85fa-42e2-9379-5b91be295661");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0513effd-f3c7-42fe-87de-01ae9f685d4f"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("43d1a26c-e9b3-497e-8341-cbff145ae482"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("a6526e02-0dfa-4c08-b5d7-a16cc7c1109d"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("ade47e52-8e07-4736-8ab4-0aae2dbaa124"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaecde13-1dee-4899-860a-07709cc7705c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc73b74e-b3a6-4f1e-8a07-4faa1e9f580f");

            migrationBuilder.AddColumn<Guid>(
                name: "SizeId",
                table: "OrderSides",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "SizeId",
                table: "OrderDrinks",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6193b0cd-fca5-4cb8-aeb9-59dc958a0902", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4134fba2-7c1c-40e7-82ba-233f4ec9d767", "AQAAAAIAAYagAAAAEJlyoNnl19Zm3Xhx0LXeSMQeyqfVbg8YTbKW2/k/aZq2aLcvQ7sFXZICM2LFNSs46w==", "ae987f1c-b1ce-442e-9132-45a24a60f308" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3e8e50ad-4770-4767-bb9a-189d3f93d687", 0, "2aff8d68-f0fa-4e72-8e20-20222ff6bc38", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEBT4t5+yePW+WUSV/T2QwTvFKH+wDHHq9wdKLd6lERRUHmY/xu5O6LmnNEKPS6l7KA==", null, false, "36278c69-68ee-4e5d-9272-023c696d3381", false, "ssquarepants" },
                    { "62761d6f-3fd9-4011-84fc-263420bd78f4", 0, "9dccd460-7c97-4d57-8bd2-225c4de7d12f", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEDP0SgjI3Oz11LDqPNqQURorLWkynnem7x9fh8EOgYqAFsgwtKWq80Lxia+N+p7PSQ==", null, false, "fd790184-e813-4c9b-9e02-9a1ccedabe4e", false, "stentacles" },
                    { "6c485b91-7cd9-4d8d-8a42-a1427e7c5f4b", 0, "4e7a71ee-e4b3-4a70-8ada-1b52cf9820a8", "patrickstar@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAED2POCrr94JSxkAx0SqyxSmyFD4WWhqGcJN6s2pLvozGNkxsZ1CAu7V6hYq/KK0dig==", null, false, "983315d5-bd22-45d7-9beb-d73a058c6e18", false, "pstar" },
                    { "ece95ccb-0fa5-48d9-a4dd-f029b2b9ac6f", 0, "7014b445-5b54-4063-a89f-1abe197d0ed6", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEGFXVBu/NWiTrQBaeN3NFDjR9n9/Q5fOpbRtGRpc/zf81NN7wYF3TOCFVeGzC3W5Zw==", null, false, "9c0d18d8-57d7-4e1f-bdc9-9157c3c72645", false, "ekrabs" }
                });

            migrationBuilder.InsertData(
                table: "BurgerToppings",
                columns: new[] { "Id", "BurgerId", "ToppingId" },
                values: new object[,]
                {
                    { new Guid("02ce495c-1104-44d2-a682-25634e75545b"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("8e968e34-174b-406d-9ac4-1abee932ae0a") },
                    { new Guid("095f223a-cca3-401f-b395-5ac07c47073f"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04") },
                    { new Guid("11f5a471-ed15-4c6a-b354-fd8096c9fa67"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("2928acdc-61c3-4f5a-8a90-df82e463fca8") },
                    { new Guid("12796316-2757-451e-bfa2-2882c854504d"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04") },
                    { new Guid("146aff6a-57ff-45b4-8388-a474d6ec4539"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("d5bad07c-32bd-4ae1-bc0f-5912705fcfd3") },
                    { new Guid("19b33277-2c60-41d5-ae25-b7d86d3b3cf3"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("05b9ebc6-06c0-4d9b-9dc2-f72c2f19fa8f") },
                    { new Guid("1c5bb4a4-0e0f-4a1f-ae8f-326e2b3316d3"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("d81d3bf7-6eef-4ee7-beda-870438505893") },
                    { new Guid("33be3a28-aea3-4d69-b918-4805ba670941"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("d5bad07c-32bd-4ae1-bc0f-5912705fcfd3") },
                    { new Guid("41a595f9-5e5e-4e8b-b5b3-27f3764522c4"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("05b9ebc6-06c0-4d9b-9dc2-f72c2f19fa8f") },
                    { new Guid("435bec6e-3cb3-4e2a-bdae-972ba27c9546"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("2ba4b445-4a4d-4bc6-aa6b-320c4170cb26") },
                    { new Guid("471a77d5-7ceb-4265-a030-574183dbedf4"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("d81d3bf7-6eef-4ee7-beda-870438505893") },
                    { new Guid("52c18c64-12db-41e1-863e-ad2233437899"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("05b9ebc6-06c0-4d9b-9dc2-f72c2f19fa8f") },
                    { new Guid("77b00702-11c2-433a-a301-95fa26334727"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("b830c0f1-6ad2-493f-a01d-968ea6b56bcf") },
                    { new Guid("826dd43f-d766-42a8-97b5-ed7f66dd0ca0"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("2ba4b445-4a4d-4bc6-aa6b-320c4170cb26") },
                    { new Guid("aef04fa3-11d9-4b2e-9679-5b4e3cb4cf03"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("df6c8a94-78f0-435b-a5f5-380c13ef6c28") },
                    { new Guid("b9616298-cfb2-4b21-b833-adadd1509ee0"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("d81d3bf7-6eef-4ee7-beda-870438505893") },
                    { new Guid("ba73eec5-6512-4966-8c8b-aea40def8a3c"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("d5bad07c-32bd-4ae1-bc0f-5912705fcfd3") },
                    { new Guid("c89831b1-79a7-4901-89c4-0418f854f5cb"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("8e968e34-174b-406d-9ac4-1abee932ae0a") },
                    { new Guid("cad1aeed-1c85-45a8-b140-a958a9186ea9"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("2928acdc-61c3-4f5a-8a90-df82e463fca8") },
                    { new Guid("cafe6bc8-9072-4f32-a67b-ea2604dae138"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("2ba4b445-4a4d-4bc6-aa6b-320c4170cb26") },
                    { new Guid("cf62a835-7ccb-4e95-b69c-0e6a06e8854f"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("2928acdc-61c3-4f5a-8a90-df82e463fca8") },
                    { new Guid("d3b0929a-7d3e-4ecf-a7cf-6c19149472b7"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04") },
                    { new Guid("d77d1cc1-c33d-4cb7-83d8-4fa44b980fb3"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04") },
                    { new Guid("daa47ad3-3005-42d4-84b3-adffc892dccb"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("b830c0f1-6ad2-493f-a01d-968ea6b56bcf") },
                    { new Guid("dc1f6b78-8394-4069-8730-078bbbf7c8c5"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("df6c8a94-78f0-435b-a5f5-380c13ef6c28") },
                    { new Guid("dee4a18d-0ff9-440d-97e8-82553c31841e"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("8e968e34-174b-406d-9ac4-1abee932ae0a") },
                    { new Guid("e7eaf4d0-117d-4627-aca5-14ec4ec32bcf"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04") },
                    { new Guid("f231dc45-4b80-4c1b-b66a-26c85ae6a262"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), new Guid("df6c8a94-78f0-435b-a5f5-380c13ef6c28") },
                    { new Guid("f366d530-99fe-436d-996c-729a0eee1a6d"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), new Guid("b830c0f1-6ad2-493f-a01d-968ea6b56bcf") }
                });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), null, 1 },
                    { new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ComboItems",
                columns: new[] { "Id", "ComboId", "ItemId", "OrderId" },
                values: new object[,]
                {
                    { new Guid("a17dac84-4681-41f5-ac7d-0327c8f44832"), new Guid("c0f13c93-71ce-4655-92c5-63a8b31c02cd"), new Guid("3ebbafe8-8c98-4b8d-b007-65ae39536441"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32") },
                    { new Guid("c5c844e3-a3da-4b47-a43e-ada5a71fd7c3"), new Guid("c0f13c93-71ce-4655-92c5-63a8b31c02cd"), new Guid("a3d5a304-04c2-4b38-8b99-c212b04fda1e"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32") },
                    { new Guid("f3bc7349-9147-45ae-b899-8ee786ec4888"), new Guid("c0f13c93-71ce-4655-92c5-63a8b31c02cd"), new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32") }
                });

            migrationBuilder.InsertData(
                table: "Combos",
                columns: new[] { "Id", "BurgerId", "Discount", "Name" },
                values: new object[,]
                {
                    { new Guid("5fbefc0c-9c05-4b16-ac90-2819c458e1ef"), new Guid("5c768986-178a-464c-af20-0d27bcecfd38"), -1f, "krabby patty combo" },
                    { new Guid("c0f13c93-71ce-4655-92c5-63a8b31c02cd"), new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"), -1.25f, "double krabby patty combo" }
                });

            migrationBuilder.InsertData(
                table: "Drinks",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("45cb03cd-b0f3-4b41-8aff-b3c3e86db932"), "dr. kelp", 1f },
                    { new Guid("4f8f7ef3-6586-4c86-b4f0-e166cedc5031"), "water", 0.1f },
                    { new Guid("6fe9d637-55d0-4f4e-a893-3eab62cc3634"), "red tide", 1f },
                    { new Guid("84af3e9f-e390-4b50-b63c-b11bd7133656"), "kelp shake", 1.5f },
                    { new Guid("9a058b47-8dc8-4573-80fe-3b5aee9aaaf9"), "seafoam soda", 1f },
                    { new Guid("dd91263f-c9e6-4bef-9388-57451511456a"), "diet dr. kelp", 1f }
                });

            migrationBuilder.InsertData(
                table: "OrderTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45ff73bd-9145-4305-9d77-1dbcd9af6be2"), "here" },
                    { new Guid("9e6d2365-2ea5-4f96-98cb-be8d82058154"), "togo" },
                    { new Guid("ecbfaa90-845a-4b9a-b486-7c1c19d3de8f"), "pickup" }
                });

            migrationBuilder.InsertData(
                table: "Sides",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1ffc83fe-201e-40a0-8399-64c18a1c914e"), "seaweed salad", 2f },
                    { new Guid("366f74e8-6507-48c5-94ae-c0ee2449d66f"), "coral bits", 1.25f },
                    { new Guid("4e5a2096-ee14-4a74-a4d6-f9df0698c336"), "barnacle rings", 1.25f },
                    { new Guid("a5dfbb9d-5171-41a5-8b1c-d1b95fb0eb98"), "oyster skins", 1.25f },
                    { new Guid("c9837050-72f7-4ae4-9396-5a8894cd7539"), "kelp fries", 1.25f }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("05b9ebc6-06c0-4d9b-9dc2-f72c2f19fa8f"), "onion", 0.05f },
                    { new Guid("2928acdc-61c3-4f5a-8a90-df82e463fca8"), "secret sauce", 0f },
                    { new Guid("2ba4b445-4a4d-4bc6-aa6b-320c4170cb26"), "bun", 0.2f },
                    { new Guid("6785e0ff-396c-4b9a-bae5-19bef5e47e88"), "sea cheese", 0.25f },
                    { new Guid("8e968e34-174b-406d-9ac4-1abee932ae0a"), "lettuce", 0.05f },
                    { new Guid("b830c0f1-6ad2-493f-a01d-968ea6b56bcf"), "tomato", 0.05f },
                    { new Guid("d5bad07c-32bd-4ae1-bc0f-5912705fcfd3"), "mustard", 0f },
                    { new Guid("d81d3bf7-6eef-4ee7-beda-870438505893"), "ketchup", 0f },
                    { new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04"), "patty", 1f },
                    { new Guid("df6c8a94-78f0-435b-a5f5-380c13ef6c28"), "pickle", 0.05f }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("c9b05717-e64a-4a36-8628-11e6580edb03"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6193b0cd-fca5-4cb8-aeb9-59dc958a0902", "3e8e50ad-4770-4767-bb9a-189d3f93d687" },
                    { "6193b0cd-fca5-4cb8-aeb9-59dc958a0902", "62761d6f-3fd9-4011-84fc-263420bd78f4" },
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "ece95ccb-0fa5-48d9-a4dd-f029b2b9ac6f" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("3d564ad5-7ecf-4a86-b038-07e5cec42db0"), "120 Conch Street", "Patrick", "6c485b91-7cd9-4d8d-8a42-a1427e7c5f4b", "Star" },
                    { new Guid("9d864aa6-f64e-485a-817a-ff4de9c2f395"), "122 Conch Street", "Squidward", "62761d6f-3fd9-4011-84fc-263420bd78f4", "Tentacles" },
                    { new Guid("c2e165a1-d7f5-4e3c-971e-2b0f49c1c6cc"), "124 Conch Street", "SpongeBob", "3e8e50ad-4770-4767-bb9a-189d3f93d687", "SquarePants" },
                    { new Guid("d849d94e-9b67-4fa6-b0de-6edab966fb96"), "3541 Anchor Way", "Eugene", "ece95ccb-0fa5-48d9-a4dd-f029b2b9ac6f", "Krabs" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerId", "EmployeeId", "OrderTime", "OrderTypeId" },
                values: new object[] { new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32"), new Guid("3d564ad5-7ecf-4a86-b038-07e5cec42db0"), new Guid("9d864aa6-f64e-485a-817a-ff4de9c2f395"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45ff73bd-9145-4305-9d77-1dbcd9af6be2") });

            migrationBuilder.InsertData(
                table: "Burgers",
                columns: new[] { "Id", "OrderId", "Quantity" },
                values: new object[] { new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDrinks",
                columns: new[] { "Id", "DrinkId", "OrderId", "Quantity", "SizeId" },
                values: new object[] { new Guid("3ebbafe8-8c98-4b8d-b007-65ae39536441"), new Guid("6fe9d637-55d0-4f4e-a893-3eab62cc3634"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32"), 1, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "OrderSides",
                columns: new[] { "Id", "ComboItemId", "OrderId", "Quantity", "SideId", "SizeId" },
                values: new object[] { new Guid("a3d5a304-04c2-4b38-8b99-c212b04fda1e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32"), 1, new Guid("366f74e8-6507-48c5-94ae-c0ee2449d66f"), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserProfiles_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "UserProfiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserProfiles_CustomerId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6193b0cd-fca5-4cb8-aeb9-59dc958a0902", "3e8e50ad-4770-4767-bb9a-189d3f93d687" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6193b0cd-fca5-4cb8-aeb9-59dc958a0902", "62761d6f-3fd9-4011-84fc-263420bd78f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "ece95ccb-0fa5-48d9-a4dd-f029b2b9ac6f" });

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("02ce495c-1104-44d2-a682-25634e75545b"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("095f223a-cca3-401f-b395-5ac07c47073f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("11f5a471-ed15-4c6a-b354-fd8096c9fa67"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("12796316-2757-451e-bfa2-2882c854504d"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("146aff6a-57ff-45b4-8388-a474d6ec4539"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("19b33277-2c60-41d5-ae25-b7d86d3b3cf3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("1c5bb4a4-0e0f-4a1f-ae8f-326e2b3316d3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("33be3a28-aea3-4d69-b918-4805ba670941"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("41a595f9-5e5e-4e8b-b5b3-27f3764522c4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("435bec6e-3cb3-4e2a-bdae-972ba27c9546"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("471a77d5-7ceb-4265-a030-574183dbedf4"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("52c18c64-12db-41e1-863e-ad2233437899"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("77b00702-11c2-433a-a301-95fa26334727"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("826dd43f-d766-42a8-97b5-ed7f66dd0ca0"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("aef04fa3-11d9-4b2e-9679-5b4e3cb4cf03"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("b9616298-cfb2-4b21-b833-adadd1509ee0"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("ba73eec5-6512-4966-8c8b-aea40def8a3c"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("c89831b1-79a7-4901-89c4-0418f854f5cb"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cad1aeed-1c85-45a8-b140-a958a9186ea9"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cafe6bc8-9072-4f32-a67b-ea2604dae138"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("cf62a835-7ccb-4e95-b69c-0e6a06e8854f"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d3b0929a-7d3e-4ecf-a7cf-6c19149472b7"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("d77d1cc1-c33d-4cb7-83d8-4fa44b980fb3"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("daa47ad3-3005-42d4-84b3-adffc892dccb"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("dc1f6b78-8394-4069-8730-078bbbf7c8c5"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("dee4a18d-0ff9-440d-97e8-82553c31841e"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("e7eaf4d0-117d-4627-aca5-14ec4ec32bcf"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f231dc45-4b80-4c1b-b66a-26c85ae6a262"));

            migrationBuilder.DeleteData(
                table: "BurgerToppings",
                keyColumn: "Id",
                keyValue: new Guid("f366d530-99fe-436d-996c-729a0eee1a6d"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("5c768986-178a-464c-af20-0d27bcecfd38"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("68a40cd8-8101-4b94-ad85-b8166feb1a5f"));

            migrationBuilder.DeleteData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: new Guid("b715cea4-1005-48b9-84bc-3640a24a0e7d"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("a17dac84-4681-41f5-ac7d-0327c8f44832"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("c5c844e3-a3da-4b47-a43e-ada5a71fd7c3"));

            migrationBuilder.DeleteData(
                table: "ComboItems",
                keyColumn: "Id",
                keyValue: new Guid("f3bc7349-9147-45ae-b899-8ee786ec4888"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("5fbefc0c-9c05-4b16-ac90-2819c458e1ef"));

            migrationBuilder.DeleteData(
                table: "Combos",
                keyColumn: "Id",
                keyValue: new Guid("c0f13c93-71ce-4655-92c5-63a8b31c02cd"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("45cb03cd-b0f3-4b41-8aff-b3c3e86db932"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("4f8f7ef3-6586-4c86-b4f0-e166cedc5031"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("6fe9d637-55d0-4f4e-a893-3eab62cc3634"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("84af3e9f-e390-4b50-b63c-b11bd7133656"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("9a058b47-8dc8-4573-80fe-3b5aee9aaaf9"));

            migrationBuilder.DeleteData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: new Guid("dd91263f-c9e6-4bef-9388-57451511456a"));

            migrationBuilder.DeleteData(
                table: "OrderDrinks",
                keyColumn: "Id",
                keyValue: new Guid("3ebbafe8-8c98-4b8d-b007-65ae39536441"));

            migrationBuilder.DeleteData(
                table: "OrderSides",
                keyColumn: "Id",
                keyValue: new Guid("a3d5a304-04c2-4b38-8b99-c212b04fda1e"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("9e6d2365-2ea5-4f96-98cb-be8d82058154"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("ecbfaa90-845a-4b9a-b486-7c1c19d3de8f"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("1ffc83fe-201e-40a0-8399-64c18a1c914e"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("366f74e8-6507-48c5-94ae-c0ee2449d66f"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("4e5a2096-ee14-4a74-a4d6-f9df0698c336"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("a5dfbb9d-5171-41a5-8b1c-d1b95fb0eb98"));

            migrationBuilder.DeleteData(
                table: "Sides",
                keyColumn: "Id",
                keyValue: new Guid("c9837050-72f7-4ae4-9396-5a8894cd7539"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("05b9ebc6-06c0-4d9b-9dc2-f72c2f19fa8f"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("2928acdc-61c3-4f5a-8a90-df82e463fca8"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("2ba4b445-4a4d-4bc6-aa6b-320c4170cb26"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("6785e0ff-396c-4b9a-bae5-19bef5e47e88"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("8e968e34-174b-406d-9ac4-1abee932ae0a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("b830c0f1-6ad2-493f-a01d-968ea6b56bcf"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("d5bad07c-32bd-4ae1-bc0f-5912705fcfd3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("d81d3bf7-6eef-4ee7-beda-870438505893"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("de21ce8f-3a35-4b70-90ad-3fa652f34b04"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "Id",
                keyValue: new Guid("df6c8a94-78f0-435b-a5f5-380c13ef6c28"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("c2e165a1-d7f5-4e3c-971e-2b0f49c1c6cc"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("c9b05717-e64a-4a36-8628-11e6580edb03"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("d849d94e-9b67-4fa6-b0de-6edab966fb96"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6193b0cd-fca5-4cb8-aeb9-59dc958a0902");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e8e50ad-4770-4767-bb9a-189d3f93d687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ece95ccb-0fa5-48d9-a4dd-f029b2b9ac6f");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c803349b-6bc9-43b4-963c-56a5295a5f32"));

            migrationBuilder.DeleteData(
                table: "OrderTypes",
                keyColumn: "Id",
                keyValue: new Guid("45ff73bd-9145-4305-9d77-1dbcd9af6be2"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("3d564ad5-7ecf-4a86-b038-07e5cec42db0"));

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: new Guid("9d864aa6-f64e-485a-817a-ff4de9c2f395"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62761d6f-3fd9-4011-84fc-263420bd78f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c485b91-7cd9-4d8d-8a42-a1427e7c5f4b");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "OrderSides");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "OrderDrinks");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Orders",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70498912-9de9-47fc-a5c3-7afd7b4431df", null, "Employee", "employee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68ad901e-fc07-46ec-9051-348bc5513e98", "AQAAAAIAAYagAAAAEDLFBA23+m7bh+82jG9aKQppT8SYHUn4buaSRXzV/Zgs8CjfC1IGynSOG4kUAt0q2g==", "e6056296-2abe-4491-b6f3-05cd2fbd0f87" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1730a8a1-5239-4905-86b5-32a6fa628603", 0, "1893ace2-8b04-4a26-a0f7-276a9b24b464", "saltydog@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEJn7ouarooZQ+YNvGlA1fivKy2omGGv/mZA8SRaZXBGuOiu71NZZpLODfIvtaQDlLg==", null, false, "cf145d4c-e2cd-4649-be6e-2b2dc9aa1ad1", false, "ekrabs" },
                    { "67ce3d19-85fa-42e2-9379-5b91be295661", 0, "9d25b037-ee8e-422e-9283-b3952da6925c", "jellyfanatic12@goofygoober.com", false, false, null, null, null, "AQAAAAIAAYagAAAAENmomMnps9yQ5wpQ6j0Wl0wmcVp6F0nPE8+ktQ9xI/2JC+RmI8ImfjTA/tEcMBbqVA==", null, false, "d6ff6415-0213-4be3-9029-545f10e68c40", false, "ssquarepants" },
                    { "aaecde13-1dee-4899-860a-07709cc7705c", 0, "27d4f2a0-fa26-4789-8016-d90c1b24ffe3", "stentacles2@seamail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEIbI2pLOyXxVEf3X+XNLT8vwGUbUMo6wo/JSdYE8/djw7aZltWSrfr4gSZ+EQc+wEg==", null, false, "766c53d1-2310-4e6b-b775-e652e5cd71e0", false, "stentacles" },
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
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[] { new Guid("9ceb4bba-c879-42c2-bd30-5f690006c40f"), "101 Main Street", "Admina", "dbc40bc6-0829-4ac5-a3ed-180f5e916a5f", "Strator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c3aaeb97-d2ba-4a53-a521-4eea61e59b35", "1730a8a1-5239-4905-86b5-32a6fa628603" },
                    { "70498912-9de9-47fc-a5c3-7afd7b4431df", "67ce3d19-85fa-42e2-9379-5b91be295661" },
                    { "70498912-9de9-47fc-a5c3-7afd7b4431df", "aaecde13-1dee-4899-860a-07709cc7705c" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "FirstName", "IdentityUserId", "LastName" },
                values: new object[,]
                {
                    { new Guid("4c688e47-3132-43df-a2cd-473dc689e450"), "3541 Anchor Way", "Eugene", "1730a8a1-5239-4905-86b5-32a6fa628603", "Krabs" },
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

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserProfiles_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "UserProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
