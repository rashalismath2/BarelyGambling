using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class TournamentMemberIndexUniqeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_UserId",
                table: "TeamMember");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember",
                columns: new[] { "UserId", "Id", "TeamId" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CoverUrl", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), "https://via.placeholder.com/150", "JamesJames1@gmail.com", "James", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesJames1" },
                    { new Guid("c6ffca93-bbc9-4b66-9b28-e0a79334f83c"), "https://via.placeholder.com/150", "DavidThomas17@gmail.com", "David", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidThomas17" },
                    { new Guid("bfd0cd5f-420f-4208-8558-05e0da34b0da"), "https://via.placeholder.com/150", "JamesMichael16@gmail.com", "James", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesMichael16" },
                    { new Guid("8550f464-f7df-4328-8642-18f4b98d24e9"), "https://via.placeholder.com/150", "DavidCharles15@gmail.com", "David", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "DavidCharles15" },
                    { new Guid("11ced1f7-0778-47e8-bd44-d13128b6c557"), "https://via.placeholder.com/150", "MichaelMichael14@gmail.com", "Michael", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelMichael14" },
                    { new Guid("2fb6ac40-3076-4b10-8324-80a4ff62fca2"), "https://via.placeholder.com/150", "CharlesJoseph13@gmail.com", "Charles", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesJoseph13" },
                    { new Guid("beea1cdc-209e-4080-86af-f30f6bc9a599"), "https://via.placeholder.com/150", "WilliamJohn12@gmail.com", "William", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamJohn12" },
                    { new Guid("eef3c005-df19-4917-8f11-d78ee794f74e"), "https://via.placeholder.com/150", "CharlesJames11@gmail.com", "Charles", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesJames11" },
                    { new Guid("78b1330e-67cf-4d6b-9be5-2553155fa896"), "https://via.placeholder.com/150", "MichaelRichard18@gmail.com", "Michael", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelRichard18" },
                    { new Guid("fb4e40f7-f376-4284-8548-c7e5c8860391"), "https://via.placeholder.com/150", "ThomasJames10@gmail.com", "Thomas", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasJames10" },
                    { new Guid("3cca193f-0e2c-4a52-b46c-8b1fbaf9c9ab"), "https://via.placeholder.com/150", "JosephJohn8@gmail.com", "Joseph", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJohn8" },
                    { new Guid("ce4691f6-d753-4ab8-9779-4029577f43e1"), "https://via.placeholder.com/150", "CharlesRichard7@gmail.com", "Charles", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesRichard7" },
                    { new Guid("e6883091-0fab-4cd8-90f9-0b3fa1ce9923"), "https://via.placeholder.com/150", "JamesMichael6@gmail.com", "James", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesMichael6" },
                    { new Guid("8edd90be-753c-4029-8f88-84e3c8cb418b"), "https://via.placeholder.com/150", "JohnWilliam5@gmail.com", "John", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnWilliam5" },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), "https://via.placeholder.com/150", "RobertJames4@gmail.com", "Robert", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertJames4" },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), "https://via.placeholder.com/150", "WilliamJoseph3@gmail.com", "William", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamJoseph3" },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), "https://via.placeholder.com/150", "WilliamRichard2@gmail.com", "William", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamRichard2" },
                    { new Guid("c3f35c49-e005-4ef1-a1a3-d535e16d2401"), "https://via.placeholder.com/150", "RichardDavid9@gmail.com", "Richard", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardDavid9" },
                    { new Guid("61c3e5b1-553e-4608-b171-22df1d66e95d"), "https://via.placeholder.com/150", "WilliamThomas19@gmail.com", "William", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamThomas19" }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "HasEnded", "HasStarted", "Place", "StartingDate", "Title", "TournamentPrize" },
                values: new object[,]
                {
                    { new Guid("c4e58d1c-e45c-4449-b880-d6df7ed3b7b4"), new DateTime(2021, 4, 29, 13, 31, 9, 739, DateTimeKind.Local).AddTicks(2673), new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), "Sample description for A1 Grand Prix", false, false, "Los Angeles", new DateTime(2021, 5, 1, 13, 31, 9, 737, DateTimeKind.Local).AddTicks(843), "A1 Grand Prix", 42003676f },
                    { new Guid("eed5cb93-11e3-408d-af52-335bd8104036"), new DateTime(2021, 4, 29, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(6592), new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), "Sample description for Formula One World Championship", false, false, "Los Angeles", new DateTime(2021, 5, 8, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(6505), "Formula One World Championship", 26585356f },
                    { new Guid("a60c0977-3634-433c-a753-76dc8a15cb0d"), new DateTime(2021, 4, 29, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(7490), new Guid("03b6544b-350d-477d-9077-77958dacbf07"), "Sample description for FIA World Endurance Championship", false, false, "Los Angeles", new DateTime(2021, 4, 29, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(7480), "FIA World Endurance Championship", 76418280f },
                    { new Guid("5c925585-14ba-46fa-b671-5d425a53bad2"), new DateTime(2021, 4, 29, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(8024), new Guid("8edd90be-753c-4029-8f88-84e3c8cb418b"), "Sample description for FIA GT1 World Championship", false, false, "Los Angeles", new DateTime(2021, 5, 5, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(8018), "FIA GT1 World Championship", 47028100f },
                    { new Guid("9d260587-c108-4188-9b67-71cd624aa093"), new DateTime(2021, 4, 29, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(8655), new Guid("e6883091-0fab-4cd8-90f9-0b3fa1ce9923"), "Sample description for World Gliding Championships", false, false, "Los Angeles", new DateTime(2021, 5, 7, 13, 31, 9, 741, DateTimeKind.Local).AddTicks(8650), "World Gliding Championships", 74099800f }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "BiddingRestrictedTo", "Description", "Title", "Total", "TournamentId", "Won" },
                values: new object[,]
                {
                    { new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc"), 0f, "Sample description for A1 Grand Prix Team 1", "A1 Grand Prix Team 1", 0f, new Guid("c4e58d1c-e45c-4449-b880-d6df7ed3b7b4"), true },
                    { new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f"), 0f, "Sample description for A1 Grand Prix Team 2", "A1 Grand Prix Team 2", 0f, new Guid("c4e58d1c-e45c-4449-b880-d6df7ed3b7b4"), false },
                    { new Guid("d87c76df-660c-41bb-9e55-039dfad339ee"), 0f, "Sample description for Formula One World Championship Team 1", "Formula One World Championship Team 1", 0f, new Guid("eed5cb93-11e3-408d-af52-335bd8104036"), true },
                    { new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db"), 0f, "Sample description for Formula One World Championship Team 2", "Formula One World Championship Team 2", 0f, new Guid("eed5cb93-11e3-408d-af52-335bd8104036"), false },
                    { new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b"), 0f, "Sample description for FIA World Endurance Championship Team 1", "FIA World Endurance Championship Team 1", 0f, new Guid("a60c0977-3634-433c-a753-76dc8a15cb0d"), true },
                    { new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de"), 0f, "Sample description for FIA World Endurance Championship Team 2", "FIA World Endurance Championship Team 2", 0f, new Guid("a60c0977-3634-433c-a753-76dc8a15cb0d"), false },
                    { new Guid("94c7ad84-e955-4602-812d-4d943e49366a"), 0f, "Sample description for FIA GT1 World Championship Team 1", "FIA GT1 World Championship Team 1", 0f, new Guid("5c925585-14ba-46fa-b671-5d425a53bad2"), true },
                    { new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb"), 0f, "Sample description for FIA GT1 World Championship Team 2", "FIA GT1 World Championship Team 2", 0f, new Guid("5c925585-14ba-46fa-b671-5d425a53bad2"), false },
                    { new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1"), 0f, "Sample description for World Gliding Championships Team 1", "World Gliding Championships Team 1", 0f, new Guid("9d260587-c108-4188-9b67-71cd624aa093"), true },
                    { new Guid("1566ea85-2541-44e4-b2b8-db87865120c7"), 0f, "Sample description for World Gliding Championships Team 2", "World Gliding Championships Team 2", 0f, new Guid("9d260587-c108-4188-9b67-71cd624aa093"), false }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "UserId", "Id", "TeamId" },
                values: new object[,]
                {
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("b2876545-e0df-426a-a848-d90140cbc713"), new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc") },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("079c07a5-6868-40b9-a0f7-bf2d22db0ae9"), new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1") },
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("e973465f-f585-4ccd-adc4-6ce106f7eace"), new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1") },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("2856eaf5-9324-4b6a-8c9b-3ce574d12f4a"), new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb") },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("5a736a4b-5cf0-4125-846a-6da1df6e4bcc"), new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb") },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("804b4b6b-ace7-40ee-aecb-98277e92bbe4"), new Guid("94c7ad84-e955-4602-812d-4d943e49366a") },
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("01990f90-25be-43b2-a20e-d25c4d4bec2c"), new Guid("94c7ad84-e955-4602-812d-4d943e49366a") },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("153f399f-cf52-4f40-9020-51809733e9a4"), new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de") },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("7eb57e8b-1f10-493c-8de1-21dc2fa06e93"), new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de") },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("e139e6eb-b803-414c-826f-29cfc0c60dda"), new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b") },
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("4e71c0c0-269f-4ae9-9581-040d44ab79be"), new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b") },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("71aa401a-f790-4c27-8ebc-6077f814e9b2"), new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db") },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("b94d59ce-cdbb-43a5-92c0-ae60fa696a9a"), new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db") },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("ade62dff-5843-42c5-86f3-f7bbb039f2d9"), new Guid("d87c76df-660c-41bb-9e55-039dfad339ee") },
                    { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("88963e46-023f-4889-a7fc-a0aafb185347"), new Guid("d87c76df-660c-41bb-9e55-039dfad339ee") },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("d63e8ea0-92df-4034-bdae-3023b3182e52"), new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f") },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("725dce06-91c8-4ffe-83fc-282ef865e1df"), new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f") },
                    { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("6c441747-ec6f-4aae-9fc0-523d29241e92"), new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc") },
                    { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("cf6587af-df7f-4b6d-bd78-191e4285b41b"), new Guid("1566ea85-2541-44e4-b2b8-db87865120c7") },
                    { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("65d026ea-f449-4f5d-8588-23eb71683cfe"), new Guid("1566ea85-2541-44e4-b2b8-db87865120c7") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember");

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("153f399f-cf52-4f40-9020-51809733e9a4"), new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("2856eaf5-9324-4b6a-8c9b-3ce574d12f4a"), new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("65d026ea-f449-4f5d-8588-23eb71683cfe"), new Guid("1566ea85-2541-44e4-b2b8-db87865120c7") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("71aa401a-f790-4c27-8ebc-6077f814e9b2"), new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("03b6544b-350d-477d-9077-77958dacbf07"), new Guid("d63e8ea0-92df-4034-bdae-3023b3182e52"), new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("5a736a4b-5cf0-4125-846a-6da1df6e4bcc"), new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("725dce06-91c8-4ffe-83fc-282ef865e1df"), new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("7eb57e8b-1f10-493c-8de1-21dc2fa06e93"), new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("b94d59ce-cdbb-43a5-92c0-ae60fa696a9a"), new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"), new Guid("cf6587af-df7f-4b6d-bd78-191e4285b41b"), new Guid("1566ea85-2541-44e4-b2b8-db87865120c7") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("01990f90-25be-43b2-a20e-d25c4d4bec2c"), new Guid("94c7ad84-e955-4602-812d-4d943e49366a") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("4e71c0c0-269f-4ae9-9581-040d44ab79be"), new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("88963e46-023f-4889-a7fc-a0aafb185347"), new Guid("d87c76df-660c-41bb-9e55-039dfad339ee") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("b2876545-e0df-426a-a848-d90140cbc713"), new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("b1367521-a186-4107-a9e9-289f2608d642"), new Guid("e973465f-f585-4ccd-adc4-6ce106f7eace"), new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("079c07a5-6868-40b9-a0f7-bf2d22db0ae9"), new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("6c441747-ec6f-4aae-9fc0-523d29241e92"), new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("804b4b6b-ace7-40ee-aecb-98277e92bbe4"), new Guid("94c7ad84-e955-4602-812d-4d943e49366a") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("ade62dff-5843-42c5-86f3-f7bbb039f2d9"), new Guid("d87c76df-660c-41bb-9e55-039dfad339ee") });

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumns: new[] { "UserId", "Id", "TeamId" },
                keyValues: new object[] { new Guid("f376b451-a815-45f9-b68d-5645b31d509a"), new Guid("e139e6eb-b803-414c-826f-29cfc0c60dda"), new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b") });

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("11ced1f7-0778-47e8-bd44-d13128b6c557"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("2fb6ac40-3076-4b10-8324-80a4ff62fca2"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("3cca193f-0e2c-4a52-b46c-8b1fbaf9c9ab"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("61c3e5b1-553e-4608-b171-22df1d66e95d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("78b1330e-67cf-4d6b-9be5-2553155fa896"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8550f464-f7df-4328-8642-18f4b98d24e9"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("beea1cdc-209e-4080-86af-f30f6bc9a599"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("bfd0cd5f-420f-4208-8558-05e0da34b0da"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c3f35c49-e005-4ef1-a1a3-d535e16d2401"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("c6ffca93-bbc9-4b66-9b28-e0a79334f83c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("ce4691f6-d753-4ab8-9779-4029577f43e1"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("eef3c005-df19-4917-8f11-d78ee794f74e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("fb4e40f7-f376-4284-8548-c7e5c8860391"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("1566ea85-2541-44e4-b2b8-db87865120c7"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("29897d3d-91a3-4d3f-93a3-a0ec3ef996e1"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("5ae68f6e-cafc-4cbe-ad67-a21ec20cdfcc"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("6595ddd6-a9fc-4496-87dd-249d529ef96b"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("94c7ad84-e955-4602-812d-4d943e49366a"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("9a40dab2-6ee8-4d68-a996-83ed846f74db"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("c8c5b5ec-35c6-4f36-83f2-a08b3f01a77f"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("d87c76df-660c-41bb-9e55-039dfad339ee"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("d9ebf5f2-8665-4698-83aa-2849b40abcfb"));

            migrationBuilder.DeleteData(
                table: "Team",
                keyColumn: "Id",
                keyValue: new Guid("fe0b0b69-1c59-49b7-92e3-793b7903d3de"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b1367521-a186-4107-a9e9-289f2608d642"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("5c925585-14ba-46fa-b671-5d425a53bad2"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("9d260587-c108-4188-9b67-71cd624aa093"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("a60c0977-3634-433c-a753-76dc8a15cb0d"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("c4e58d1c-e45c-4449-b880-d6df7ed3b7b4"));

            migrationBuilder.DeleteData(
                table: "Tournament",
                keyColumn: "Id",
                keyValue: new Guid("eed5cb93-11e3-408d-af52-335bd8104036"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("03b6544b-350d-477d-9077-77958dacbf07"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8edd90be-753c-4029-8f88-84e3c8cb418b"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a9d83a6b-4140-4086-98f6-97a8a18282f6"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("e6883091-0fab-4cd8-90f9-0b3fa1ce9923"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("f376b451-a815-45f9-b68d-5645b31d509a"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_UserId",
                table: "TeamMember",
                column: "UserId");
        }
    }
}
