using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class TournamentTableChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("074a7401-6d64-4436-8375-bf92b0c29d16"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("1cc0e4ad-0156-4010-b360-80cb3361edcf"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("22a9718d-6914-488c-a0ae-333147838568"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("35c47c75-fb41-485c-8e00-a767b7feab3c"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("36ee3c12-5468-41e6-a38a-578a85c0af03"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("447e4b26-fbe2-4d4a-8b5a-2131e83466ac"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("64caa2ca-5c4b-4bb1-8f62-a0d4a91727c8"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("6ac8a735-784a-4a04-951d-9c1fac7f4294"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("7b5a116e-961f-4b7e-9bab-51abb14f52e3"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("81fb2d52-29f9-42af-aa64-0fdc3d0dbf64"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("8f74b356-9b6d-4989-ad5d-3c6c62c19de0"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("920b8ac8-e242-4b15-bd1a-f229e1936353"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("9eb3fca8-802c-44e0-a0d3-92ecf164459d"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("9f36fe3b-101e-4bf4-b01e-e9f1061d203b"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("afe38b4a-ac29-4fe0-9a8b-725e89187c75"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("b5adfcbc-dac7-4fba-9678-2f86d4063df5"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("c11529e9-122e-4e53-acb7-c991e9294a96"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("cae34f97-bd33-4b53-9fe1-d95da85d5b2b"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("e0bda98d-9d33-4bd7-b2d2-d6a5f08d3725"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("fe0ef53e-9349-4e9c-9ede-0b57e61f8ba7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("02bdfb5b-2a23-4157-822a-2a3236bbf54a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("04617956-4130-4401-9d00-f64768321149"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1613f4fe-6a42-4ec9-8c9f-94b3e748d102"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2451e0f4-cade-4902-8ed5-18e4a6270c1b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4256708a-8bb1-4f8b-91f7-5e7a8f086990"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("56f14b92-322a-4a53-8769-6082895094d8"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6875e1e4-059b-49cf-bd07-843be6e7a235"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("78151af4-e289-4e3e-8846-9cd0c583ecc9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("85cef19f-8cf6-4b0e-b15d-ea6f2f0a5920"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("94a4d9f8-fd57-4927-bfb2-d5706c5fe118"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a0bb16b1-3d09-4c5a-b26b-b9dc1d2e600b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d354468c-b5fb-444a-b2e6-3fd6cddfc47b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("d8424614-6592-4446-ae7a-d113e15fca46"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dc06a474-5a03-412c-ae6c-0a67cfb80bb1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("02fd4c1a-ad53-4f7c-87aa-3ecc9261bec2"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("04ed3c78-526f-469b-b7ad-e08748b7467e"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("2186f576-6338-41bd-9f89-f79bc6648279"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("8b0e73b4-0a84-4940-8f71-1aa85c9432b1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("ac4e57f9-e8e2-4757-bc7c-11b4d11e1be7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("ae095d8e-b47e-471e-835e-61f7abc950b4"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("b0000861-a875-4018-ba35-e6afd961afee"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("c24e6077-c541-4ec0-a095-b1d3335d961a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("f6dd0db4-4092-4cad-9fe8-257e46ffa125"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("f71d4710-aeb0-4e7e-90bb-6b2a67a480ba"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("3b539340-b19e-4af7-ae04-6efcd34e7474"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("906902c8-34dd-42c7-9296-09000832de6a"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("e02f13a1-f68c-4a28-90f3-7a416b08eb87"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("e611d79d-0a26-40fa-9df9-5315bbf589be"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("ee6119ae-7fb1-4696-90ab-b79c9512103a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5"));

            migrationBuilder.AddColumn<bool>(
                name: "HasEnded",
                table: "Tournament",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasStarted",
                table: "Tournament",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CoverUrl", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("cce5841e-5d75-41ae-95c7-9c69c13dfb70"), "https://via.placeholder.com/150", "JamesWilliam1@gmail.com", "James", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesWilliam1" },
                    { new Guid("b49c6427-3495-48e5-9575-f50d5f6be1b6"), "https://via.placeholder.com/150", "ThomasWilliam17@gmail.com", "Thomas", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasWilliam17" },
                    { new Guid("cfeb5e80-921a-4d93-b67e-6843360d6227"), "https://via.placeholder.com/150", "RichardJohn16@gmail.com", "Richard", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardJohn16" },
                    { new Guid("0222530e-7796-4a43-b94e-cac0d84836b1"), "https://via.placeholder.com/150", "DavidRobert15@gmail.com", "David", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidRobert15" },
                    { new Guid("f2e47e7c-f8fe-46ac-8b1c-c7a6b45c0597"), "https://via.placeholder.com/150", "JohnDavid14@gmail.com", "John", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnDavid14" },
                    { new Guid("781cfc43-ca09-4dd9-a371-e9a24ab68f0d"), "https://via.placeholder.com/150", "MichaelThomas13@gmail.com", "Michael", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelThomas13" },
                    { new Guid("6c74d4e1-ffec-4d99-bf5e-4f15e45659d4"), "https://via.placeholder.com/150", "JohnRichard12@gmail.com", "John", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnRichard12" },
                    { new Guid("f1002f1c-17b2-43ee-b282-073d6b6a062b"), "https://via.placeholder.com/150", "JohnDavid11@gmail.com", "John", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnDavid11" },
                    { new Guid("ad43917f-4e01-4841-b123-c5fe21e617ee"), "https://via.placeholder.com/150", "ThomasJoseph18@gmail.com", "Thomas", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasJoseph18" },
                    { new Guid("8c6b2a1e-0cf4-4175-8d94-54cddfd04a8e"), "https://via.placeholder.com/150", "DavidJohn10@gmail.com", "David", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidJohn10" },
                    { new Guid("352bd933-804a-488b-ac14-506e90ce4168"), "https://via.placeholder.com/150", "JosephJohn8@gmail.com", "Joseph", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJohn8" },
                    { new Guid("f02a6019-42b1-4c9c-a45e-0c73edb64530"), "https://via.placeholder.com/150", "ThomasThomas7@gmail.com", "Thomas", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasThomas7" },
                    { new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8"), "https://via.placeholder.com/150", "RobertDavid6@gmail.com", "Robert", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertDavid6" },
                    { new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe"), "https://via.placeholder.com/150", "JosephJames5@gmail.com", "Joseph", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJames5" },
                    { new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a"), "https://via.placeholder.com/150", "RobertMichael4@gmail.com", "Robert", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertMichael4" },
                    { new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae"), "https://via.placeholder.com/150", "JamesRobert3@gmail.com", "James", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesRobert3" },
                    { new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784"), "https://via.placeholder.com/150", "JosephJames2@gmail.com", "Joseph", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJames2" },
                    { new Guid("dca0a285-7224-4c33-92b3-3369d291ce18"), "https://via.placeholder.com/150", "RichardCharles9@gmail.com", "Richard", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardCharles9" },
                    { new Guid("68abee57-1228-419d-9b6a-c48d1cdd84a4"), "https://via.placeholder.com/150", "DavidWilliam19@gmail.com", "David", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidWilliam19" }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "HasEnded", "HasStarted", "Place", "StartingDate", "Title", "TournamentPrize" },
                values: new object[,]
                {
                    { new Guid("0553498d-b9e3-4a76-9b48-bd50edf7f815"), new DateTime(2021, 4, 29, 12, 13, 51, 782, DateTimeKind.Local).AddTicks(5015), new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784"), "Sample description for A1 Grand Prix", false, false, "Los Angeles", new DateTime(2021, 4, 30, 12, 13, 51, 780, DateTimeKind.Local).AddTicks(4956), "A1 Grand Prix", 51167628f },
                    { new Guid("7d2445cb-d274-488a-8c0e-41c73d6c8f31"), new DateTime(2021, 4, 29, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(6865), new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae"), "Sample description for Formula One World Championship", false, false, "Los Angeles", new DateTime(2021, 4, 29, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(6799), "Formula One World Championship", 904996f },
                    { new Guid("40fc5578-4199-4d40-a0a7-db1d05817dfc"), new DateTime(2021, 4, 29, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(7738), new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a"), "Sample description for FIA World Endurance Championship", false, false, "Los Angeles", new DateTime(2021, 5, 6, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(7733), "FIA World Endurance Championship", 32470934f },
                    { new Guid("849a8d54-283c-4c8d-8a41-8deeb0333f51"), new DateTime(2021, 4, 29, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(8241), new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe"), "Sample description for FIA GT1 World Championship", false, false, "Los Angeles", new DateTime(2021, 5, 7, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(8236), "FIA GT1 World Championship", 46769332f },
                    { new Guid("12211770-08b6-485b-af05-1af514435f5e"), new DateTime(2021, 4, 29, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(8857), new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8"), "Sample description for World Gliding Championships", false, false, "Los Angeles", new DateTime(2021, 5, 5, 12, 13, 51, 784, DateTimeKind.Local).AddTicks(8852), "World Gliding Championships", 64506352f }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "BiddingRestrictedTo", "Description", "Title", "Total", "TournamentId", "Won" },
                values: new object[,]
                {
                    { new Guid("c156b6b6-b0b4-485a-93b4-de4aae62055d"), 0f, "Sample description for A1 Grand Prix Team 1", "A1 Grand Prix Team 1", 0f, new Guid("0553498d-b9e3-4a76-9b48-bd50edf7f815"), true },
                    { new Guid("add89ca3-4406-4aaf-a27c-d97bf0bdc217"), 0f, "Sample description for A1 Grand Prix Team 2", "A1 Grand Prix Team 2", 0f, new Guid("0553498d-b9e3-4a76-9b48-bd50edf7f815"), false },
                    { new Guid("6b1675bd-d745-4c9f-8a4f-e8ddf87943af"), 0f, "Sample description for Formula One World Championship Team 1", "Formula One World Championship Team 1", 0f, new Guid("7d2445cb-d274-488a-8c0e-41c73d6c8f31"), true },
                    { new Guid("bffadcbc-66d6-483f-a4cb-bb40a0db68b7"), 0f, "Sample description for Formula One World Championship Team 2", "Formula One World Championship Team 2", 0f, new Guid("7d2445cb-d274-488a-8c0e-41c73d6c8f31"), false },
                    { new Guid("b8f8d5e7-62e4-4bb4-bae6-40e4ff597414"), 0f, "Sample description for FIA World Endurance Championship Team 1", "FIA World Endurance Championship Team 1", 0f, new Guid("40fc5578-4199-4d40-a0a7-db1d05817dfc"), true },
                    { new Guid("5b6d5f7c-8618-4d84-8869-484eb4b3efcc"), 0f, "Sample description for FIA World Endurance Championship Team 2", "FIA World Endurance Championship Team 2", 0f, new Guid("40fc5578-4199-4d40-a0a7-db1d05817dfc"), false },
                    { new Guid("01ce99f8-f922-45c4-b3ab-2f41462207b1"), 0f, "Sample description for FIA GT1 World Championship Team 1", "FIA GT1 World Championship Team 1", 0f, new Guid("849a8d54-283c-4c8d-8a41-8deeb0333f51"), true },
                    { new Guid("399e6797-4053-4ddc-beb0-f20a50c1e555"), 0f, "Sample description for FIA GT1 World Championship Team 2", "FIA GT1 World Championship Team 2", 0f, new Guid("849a8d54-283c-4c8d-8a41-8deeb0333f51"), false },
                    { new Guid("e9674b0e-6d7e-4ac4-adf4-b693cc60f726"), 0f, "Sample description for World Gliding Championships Team 1", "World Gliding Championships Team 1", 0f, new Guid("12211770-08b6-485b-af05-1af514435f5e"), true },
                    { new Guid("fef73b7f-b197-4763-a2fe-1faebe8795c5"), 0f, "Sample description for World Gliding Championships Team 2", "World Gliding Championships Team 2", 0f, new Guid("12211770-08b6-485b-af05-1af514435f5e"), false }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "Id", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cada4617-0fa3-4fad-b58f-747a6d45d3c3"), new Guid("c156b6b6-b0b4-485a-93b4-de4aae62055d"), new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784") },
                    { new Guid("9ce24dd0-6ad2-4bbc-9d4f-093998680497"), new Guid("e9674b0e-6d7e-4ac4-adf4-b693cc60f726"), new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8") },
                    { new Guid("9c4cf6ba-66d6-4416-bd50-7648e8f099ce"), new Guid("e9674b0e-6d7e-4ac4-adf4-b693cc60f726"), new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8") },
                    { new Guid("091fb1d4-6f20-459f-bb1e-ffb509a67a19"), new Guid("399e6797-4053-4ddc-beb0-f20a50c1e555"), new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe") },
                    { new Guid("e4023260-ef85-4a6f-ab29-97301484d0a5"), new Guid("399e6797-4053-4ddc-beb0-f20a50c1e555"), new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe") },
                    { new Guid("c98b1724-35cc-4a0d-94b7-5f960075bbb6"), new Guid("01ce99f8-f922-45c4-b3ab-2f41462207b1"), new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe") },
                    { new Guid("c4995480-4e0c-43f5-b9a1-3d03b06b2469"), new Guid("01ce99f8-f922-45c4-b3ab-2f41462207b1"), new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe") },
                    { new Guid("b74f24cf-2bc9-4e5e-80c5-84b478aea831"), new Guid("5b6d5f7c-8618-4d84-8869-484eb4b3efcc"), new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a") },
                    { new Guid("524c0e48-df66-4319-ad63-73142f763a12"), new Guid("5b6d5f7c-8618-4d84-8869-484eb4b3efcc"), new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a") },
                    { new Guid("b674e95b-24e3-4501-8979-643b01af12d9"), new Guid("b8f8d5e7-62e4-4bb4-bae6-40e4ff597414"), new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a") },
                    { new Guid("4f2e63db-b58b-42ff-b53c-99e48283b8c8"), new Guid("b8f8d5e7-62e4-4bb4-bae6-40e4ff597414"), new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a") },
                    { new Guid("074797c3-e92a-4656-b6a2-7901e20317cb"), new Guid("bffadcbc-66d6-483f-a4cb-bb40a0db68b7"), new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae") },
                    { new Guid("c120771b-f5d9-4e0e-9f7a-a4722bd4e5f9"), new Guid("bffadcbc-66d6-483f-a4cb-bb40a0db68b7"), new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae") },
                    { new Guid("0b550b2c-e118-4c40-a050-3829fb1798c4"), new Guid("6b1675bd-d745-4c9f-8a4f-e8ddf87943af"), new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae") },
                    { new Guid("ca22fd0b-20dd-4f82-b3a9-b078a838c072"), new Guid("6b1675bd-d745-4c9f-8a4f-e8ddf87943af"), new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae") },
                    { new Guid("45dec03e-4acc-408d-b482-ea9e96856887"), new Guid("add89ca3-4406-4aaf-a27c-d97bf0bdc217"), new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784") },
                    { new Guid("435ef6ef-4206-4776-a51b-8b63130681da"), new Guid("add89ca3-4406-4aaf-a27c-d97bf0bdc217"), new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784") },
                    { new Guid("07722069-d718-4d2c-a3f6-3a8e0299b248"), new Guid("c156b6b6-b0b4-485a-93b4-de4aae62055d"), new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784") },
                    { new Guid("8e4ff5e0-317d-440c-a77e-0cb865060c6c"), new Guid("fef73b7f-b197-4763-a2fe-1faebe8795c5"), new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8") },
                    { new Guid("68156620-031e-436b-b067-0cc1490d44a3"), new Guid("fef73b7f-b197-4763-a2fe-1faebe8795c5"), new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("074797c3-e92a-4656-b6a2-7901e20317cb"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("07722069-d718-4d2c-a3f6-3a8e0299b248"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("091fb1d4-6f20-459f-bb1e-ffb509a67a19"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("0b550b2c-e118-4c40-a050-3829fb1798c4"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("435ef6ef-4206-4776-a51b-8b63130681da"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("45dec03e-4acc-408d-b482-ea9e96856887"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("4f2e63db-b58b-42ff-b53c-99e48283b8c8"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("524c0e48-df66-4319-ad63-73142f763a12"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("68156620-031e-436b-b067-0cc1490d44a3"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("8e4ff5e0-317d-440c-a77e-0cb865060c6c"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("9c4cf6ba-66d6-4416-bd50-7648e8f099ce"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("9ce24dd0-6ad2-4bbc-9d4f-093998680497"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("b674e95b-24e3-4501-8979-643b01af12d9"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("b74f24cf-2bc9-4e5e-80c5-84b478aea831"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("c120771b-f5d9-4e0e-9f7a-a4722bd4e5f9"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("c4995480-4e0c-43f5-b9a1-3d03b06b2469"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("c98b1724-35cc-4a0d-94b7-5f960075bbb6"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("ca22fd0b-20dd-4f82-b3a9-b078a838c072"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("cada4617-0fa3-4fad-b58f-747a6d45d3c3"));

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "Id",
                keyValue: new Guid("e4023260-ef85-4a6f-ab29-97301484d0a5"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("0222530e-7796-4a43-b94e-cac0d84836b1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("352bd933-804a-488b-ac14-506e90ce4168"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("68abee57-1228-419d-9b6a-c48d1cdd84a4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("6c74d4e1-ffec-4d99-bf5e-4f15e45659d4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("781cfc43-ca09-4dd9-a371-e9a24ab68f0d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8c6b2a1e-0cf4-4175-8d94-54cddfd04a8e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ad43917f-4e01-4841-b123-c5fe21e617ee"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b49c6427-3495-48e5-9575-f50d5f6be1b6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cce5841e-5d75-41ae-95c7-9c69c13dfb70"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("cfeb5e80-921a-4d93-b67e-6843360d6227"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("dca0a285-7224-4c33-92b3-3369d291ce18"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f02a6019-42b1-4c9c-a45e-0c73edb64530"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f1002f1c-17b2-43ee-b282-073d6b6a062b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f2e47e7c-f8fe-46ac-8b1c-c7a6b45c0597"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("01ce99f8-f922-45c4-b3ab-2f41462207b1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("399e6797-4053-4ddc-beb0-f20a50c1e555"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("5b6d5f7c-8618-4d84-8869-484eb4b3efcc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("6b1675bd-d745-4c9f-8a4f-e8ddf87943af"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("add89ca3-4406-4aaf-a27c-d97bf0bdc217"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("b8f8d5e7-62e4-4bb4-bae6-40e4ff597414"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("bffadcbc-66d6-483f-a4cb-bb40a0db68b7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("c156b6b6-b0b4-485a-93b4-de4aae62055d"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("e9674b0e-6d7e-4ac4-adf4-b693cc60f726"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("fef73b7f-b197-4763-a2fe-1faebe8795c5"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("0553498d-b9e3-4a76-9b48-bd50edf7f815"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("12211770-08b6-485b-af05-1af514435f5e"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("40fc5578-4199-4d40-a0a7-db1d05817dfc"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("7d2445cb-d274-488a-8c0e-41c73d6c8f31"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("849a8d54-283c-4c8d-8a41-8deeb0333f51"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("69e35e08-b342-4fc2-b2b4-68ef0fd36bae"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("7ae9844b-96f2-489c-989a-9519eeec63fe"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b11b3351-be60-48f5-b68d-44ad7074b02a"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c084366b-51b4-4ee4-97c4-9ef163d64784"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f87f7bbf-bb5f-450a-9974-f441171e2cc8"));

            migrationBuilder.DropColumn(
                name: "HasEnded",
                table: "Tournament");

            migrationBuilder.DropColumn(
                name: "HasStarted",
                table: "Tournament");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CoverUrl", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("dc06a474-5a03-412c-ae6c-0a67cfb80bb1"), "https://via.placeholder.com/150", "MichaelDavid1@gmail.com", "Michael", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelDavid1" },
                    { new Guid("94a4d9f8-fd57-4927-bfb2-d5706c5fe118"), "https://via.placeholder.com/150", "ThomasThomas17@gmail.com", "Thomas", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasThomas17" },
                    { new Guid("6875e1e4-059b-49cf-bd07-843be6e7a235"), "https://via.placeholder.com/150", "JosephJames16@gmail.com", "Joseph", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJames16" },
                    { new Guid("02bdfb5b-2a23-4157-822a-2a3236bbf54a"), "https://via.placeholder.com/150", "DavidWilliam15@gmail.com", "David", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidWilliam15" },
                    { new Guid("4256708a-8bb1-4f8b-91f7-5e7a8f086990"), "https://via.placeholder.com/150", "JohnRichard14@gmail.com", "John", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnRichard14" },
                    { new Guid("78151af4-e289-4e3e-8846-9cd0c583ecc9"), "https://via.placeholder.com/150", "MichaelDavid13@gmail.com", "Michael", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelDavid13" },
                    { new Guid("04617956-4130-4401-9d00-f64768321149"), "https://via.placeholder.com/150", "JohnRobert12@gmail.com", "John", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnRobert12" },
                    { new Guid("85cef19f-8cf6-4b0e-b15d-ea6f2f0a5920"), "https://via.placeholder.com/150", "RobertWilliam11@gmail.com", "Robert", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertWilliam11" },
                    { new Guid("1613f4fe-6a42-4ec9-8c9f-94b3e748d102"), "https://via.placeholder.com/150", "RobertJames18@gmail.com", "Robert", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertJames18" },
                    { new Guid("56f14b92-322a-4a53-8769-6082895094d8"), "https://via.placeholder.com/150", "JamesJoseph10@gmail.com", "James", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesJoseph10" },
                    { new Guid("d354468c-b5fb-444a-b2e6-3fd6cddfc47b"), "https://via.placeholder.com/150", "ThomasJoseph8@gmail.com", "Thomas", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasJoseph8" },
                    { new Guid("2451e0f4-cade-4902-8ed5-18e4a6270c1b"), "https://via.placeholder.com/150", "WilliamWilliam7@gmail.com", "William", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamWilliam7" },
                    { new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7"), "https://via.placeholder.com/150", "RichardCharles6@gmail.com", "Richard", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardCharles6" },
                    { new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5"), "https://via.placeholder.com/150", "RichardCharles5@gmail.com", "Richard", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardCharles5" },
                    { new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e"), "https://via.placeholder.com/150", "CharlesDavid4@gmail.com", "Charles", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesDavid4" },
                    { new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95"), "https://via.placeholder.com/150", "JohnCharles3@gmail.com", "John", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnCharles3" },
                    { new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b"), "https://via.placeholder.com/150", "WilliamRichard2@gmail.com", "William", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamRichard2" },
                    { new Guid("a0bb16b1-3d09-4c5a-b26b-b9dc1d2e600b"), "https://via.placeholder.com/150", "JohnMichael9@gmail.com", "John", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnMichael9" },
                    { new Guid("d8424614-6592-4446-ae7a-d113e15fca46"), "https://via.placeholder.com/150", "JamesThomas19@gmail.com", "James", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesThomas19" }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Place", "StartingDate", "Title", "TournamentPrize" },
                values: new object[,]
                {
                    { new Guid("e611d79d-0a26-40fa-9df9-5315bbf589be"), new DateTime(2021, 4, 29, 9, 3, 15, 826, DateTimeKind.Local).AddTicks(6457), new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b"), "Sample description for A1 Grand Prix", "Los Angeles", new DateTime(2021, 5, 2, 9, 3, 15, 824, DateTimeKind.Local).AddTicks(7346), "A1 Grand Prix", 98208656f },
                    { new Guid("3b539340-b19e-4af7-ae04-6efcd34e7474"), new DateTime(2021, 4, 29, 9, 3, 15, 828, DateTimeKind.Local).AddTicks(9318), new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95"), "Sample description for Formula One World Championship", "Los Angeles", new DateTime(2021, 5, 4, 9, 3, 15, 828, DateTimeKind.Local).AddTicks(9257), "Formula One World Championship", 1924158f },
                    { new Guid("e02f13a1-f68c-4a28-90f3-7a416b08eb87"), new DateTime(2021, 4, 29, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(37), new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e"), "Sample description for FIA World Endurance Championship", "Los Angeles", new DateTime(2021, 5, 7, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(32), "FIA World Endurance Championship", 47768164f },
                    { new Guid("ee6119ae-7fb1-4696-90ab-b79c9512103a"), new DateTime(2021, 4, 29, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(555), new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5"), "Sample description for FIA GT1 World Championship", "Los Angeles", new DateTime(2021, 4, 29, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(550), "FIA GT1 World Championship", 28883968f },
                    { new Guid("906902c8-34dd-42c7-9296-09000832de6a"), new DateTime(2021, 4, 29, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(1156), new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7"), "Sample description for World Gliding Championships", "Los Angeles", new DateTime(2021, 5, 8, 9, 3, 15, 829, DateTimeKind.Local).AddTicks(1150), "World Gliding Championships", 24374584f }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "BiddingRestrictedTo", "Description", "Title", "Total", "TournamentId", "Won" },
                values: new object[,]
                {
                    { new Guid("8b0e73b4-0a84-4940-8f71-1aa85c9432b1"), 0f, "Sample description for A1 Grand Prix Team 1", "A1 Grand Prix Team 1", 0f, new Guid("e611d79d-0a26-40fa-9df9-5315bbf589be"), true },
                    { new Guid("02fd4c1a-ad53-4f7c-87aa-3ecc9261bec2"), 0f, "Sample description for A1 Grand Prix Team 2", "A1 Grand Prix Team 2", 0f, new Guid("e611d79d-0a26-40fa-9df9-5315bbf589be"), false },
                    { new Guid("ae095d8e-b47e-471e-835e-61f7abc950b4"), 0f, "Sample description for Formula One World Championship Team 1", "Formula One World Championship Team 1", 0f, new Guid("3b539340-b19e-4af7-ae04-6efcd34e7474"), true },
                    { new Guid("ac4e57f9-e8e2-4757-bc7c-11b4d11e1be7"), 0f, "Sample description for Formula One World Championship Team 2", "Formula One World Championship Team 2", 0f, new Guid("3b539340-b19e-4af7-ae04-6efcd34e7474"), false },
                    { new Guid("2186f576-6338-41bd-9f89-f79bc6648279"), 0f, "Sample description for FIA World Endurance Championship Team 1", "FIA World Endurance Championship Team 1", 0f, new Guid("e02f13a1-f68c-4a28-90f3-7a416b08eb87"), true },
                    { new Guid("f71d4710-aeb0-4e7e-90bb-6b2a67a480ba"), 0f, "Sample description for FIA World Endurance Championship Team 2", "FIA World Endurance Championship Team 2", 0f, new Guid("e02f13a1-f68c-4a28-90f3-7a416b08eb87"), false },
                    { new Guid("c24e6077-c541-4ec0-a095-b1d3335d961a"), 0f, "Sample description for FIA GT1 World Championship Team 1", "FIA GT1 World Championship Team 1", 0f, new Guid("ee6119ae-7fb1-4696-90ab-b79c9512103a"), true },
                    { new Guid("f6dd0db4-4092-4cad-9fe8-257e46ffa125"), 0f, "Sample description for FIA GT1 World Championship Team 2", "FIA GT1 World Championship Team 2", 0f, new Guid("ee6119ae-7fb1-4696-90ab-b79c9512103a"), false },
                    { new Guid("04ed3c78-526f-469b-b7ad-e08748b7467e"), 0f, "Sample description for World Gliding Championships Team 1", "World Gliding Championships Team 1", 0f, new Guid("906902c8-34dd-42c7-9296-09000832de6a"), true },
                    { new Guid("b0000861-a875-4018-ba35-e6afd961afee"), 0f, "Sample description for World Gliding Championships Team 2", "World Gliding Championships Team 2", 0f, new Guid("906902c8-34dd-42c7-9296-09000832de6a"), false }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "Id", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cae34f97-bd33-4b53-9fe1-d95da85d5b2b"), new Guid("8b0e73b4-0a84-4940-8f71-1aa85c9432b1"), new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b") },
                    { new Guid("64caa2ca-5c4b-4bb1-8f62-a0d4a91727c8"), new Guid("04ed3c78-526f-469b-b7ad-e08748b7467e"), new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7") },
                    { new Guid("c11529e9-122e-4e53-acb7-c991e9294a96"), new Guid("04ed3c78-526f-469b-b7ad-e08748b7467e"), new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7") },
                    { new Guid("36ee3c12-5468-41e6-a38a-578a85c0af03"), new Guid("f6dd0db4-4092-4cad-9fe8-257e46ffa125"), new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5") },
                    { new Guid("8f74b356-9b6d-4989-ad5d-3c6c62c19de0"), new Guid("f6dd0db4-4092-4cad-9fe8-257e46ffa125"), new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5") },
                    { new Guid("074a7401-6d64-4436-8375-bf92b0c29d16"), new Guid("c24e6077-c541-4ec0-a095-b1d3335d961a"), new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5") },
                    { new Guid("7b5a116e-961f-4b7e-9bab-51abb14f52e3"), new Guid("c24e6077-c541-4ec0-a095-b1d3335d961a"), new Guid("ef1615c8-b79b-470f-b3ed-87984141a8a5") },
                    { new Guid("81fb2d52-29f9-42af-aa64-0fdc3d0dbf64"), new Guid("f71d4710-aeb0-4e7e-90bb-6b2a67a480ba"), new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e") },
                    { new Guid("9f36fe3b-101e-4bf4-b01e-e9f1061d203b"), new Guid("f71d4710-aeb0-4e7e-90bb-6b2a67a480ba"), new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e") },
                    { new Guid("9eb3fca8-802c-44e0-a0d3-92ecf164459d"), new Guid("2186f576-6338-41bd-9f89-f79bc6648279"), new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e") },
                    { new Guid("b5adfcbc-dac7-4fba-9678-2f86d4063df5"), new Guid("2186f576-6338-41bd-9f89-f79bc6648279"), new Guid("56d8ad32-ef5e-45bd-93be-df9f6eab171e") },
                    { new Guid("35c47c75-fb41-485c-8e00-a767b7feab3c"), new Guid("ac4e57f9-e8e2-4757-bc7c-11b4d11e1be7"), new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95") },
                    { new Guid("920b8ac8-e242-4b15-bd1a-f229e1936353"), new Guid("ac4e57f9-e8e2-4757-bc7c-11b4d11e1be7"), new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95") },
                    { new Guid("e0bda98d-9d33-4bd7-b2d2-d6a5f08d3725"), new Guid("ae095d8e-b47e-471e-835e-61f7abc950b4"), new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95") },
                    { new Guid("447e4b26-fbe2-4d4a-8b5a-2131e83466ac"), new Guid("ae095d8e-b47e-471e-835e-61f7abc950b4"), new Guid("afe37548-6057-44e7-a15d-b257dcf7ca95") },
                    { new Guid("1cc0e4ad-0156-4010-b360-80cb3361edcf"), new Guid("02fd4c1a-ad53-4f7c-87aa-3ecc9261bec2"), new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b") },
                    { new Guid("fe0ef53e-9349-4e9c-9ede-0b57e61f8ba7"), new Guid("02fd4c1a-ad53-4f7c-87aa-3ecc9261bec2"), new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b") },
                    { new Guid("afe38b4a-ac29-4fe0-9a8b-725e89187c75"), new Guid("8b0e73b4-0a84-4940-8f71-1aa85c9432b1"), new Guid("cd5b4687-7187-42d3-9a29-ebbd15d6274b") },
                    { new Guid("6ac8a735-784a-4a04-951d-9c1fac7f4294"), new Guid("b0000861-a875-4018-ba35-e6afd961afee"), new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7") },
                    { new Guid("22a9718d-6914-488c-a0ae-333147838568"), new Guid("b0000861-a875-4018-ba35-e6afd961afee"), new Guid("191e4f5d-3c7e-4670-aced-e9566f4d11e7") }
                });
        }
    }
}
