using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class FieldsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    TournamentPrize = table.Column<float>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournament_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Total = table.Column<float>(nullable: false),
                    TournamentId = table.Column<Guid>(nullable: false),
                    BiddingRestrictedTos = table.Column<float>(nullable: false),
                    Won = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bidding",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Amount = table.Column<float>(nullable: false),
                    TeamId1 = table.Column<Guid>(nullable: true),
                    TeamId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bidding_Team_TeamId1",
                        column: x => x.TeamId1,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bidding_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId1 = table.Column<Guid>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMember_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMember_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("d1ffe0a2-1778-42d4-a6f6-7d2537653815"), "MichaelRobert1@gmail.com", "Michael", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelRobert1" },
                    { new Guid("4d6b3804-cfb4-43c7-9020-abf7f6b8a7fd"), "CharlesRobert17@gmail.com", "Charles", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesRobert17" },
                    { new Guid("0b9c2287-e27f-447f-bd88-cd59973aa78e"), "WilliamDavid16@gmail.com", "William", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamDavid16" },
                    { new Guid("72442de3-bff7-41d7-9ee2-efd861397fb0"), "RobertJoseph15@gmail.com", "Robert", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertJoseph15" },
                    { new Guid("87094c13-483e-4b79-ae67-b7d27690ac81"), "MichaelThomas14@gmail.com", "Michael", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelThomas14" },
                    { new Guid("3d9430e4-d038-4742-bc2f-cdedd68b8669"), "RobertJames13@gmail.com", "Robert", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertJames13" },
                    { new Guid("4e39ae3c-00c9-4bee-a308-8e76f87eb7eb"), "JosephRobert12@gmail.com", "Joseph", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephRobert12" },
                    { new Guid("5b780ead-9753-47f5-9236-bde7321e918b"), "JosephMichael11@gmail.com", "Joseph", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephMichael11" },
                    { new Guid("5148d808-ab0c-468b-a350-1f96c4ae4efb"), "RichardRichard18@gmail.com", "Richard", "Richard", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardRichard18" },
                    { new Guid("349e1e79-9a86-4a05-92d3-7aa67bc28f8c"), "WilliamJoseph10@gmail.com", "William", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamJoseph10" },
                    { new Guid("aa675a3c-d960-4e81-ac89-3fb567d40108"), "ThomasDavid8@gmail.com", "Thomas", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasDavid8" },
                    { new Guid("f9158170-f47e-4e15-9573-d1a00bc9aecd"), "CharlesJohn7@gmail.com", "Charles", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "CharlesJohn7" },
                    { new Guid("b0b7f05d-3192-46a9-8cad-8d10f581d09b"), "JamesRobert6@gmail.com", "James", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesRobert6" },
                    { new Guid("3a2f9a41-3d1a-46f5-9fe1-5ad80a52e2ac"), "JohnThomas5@gmail.com", "John", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnThomas5" },
                    { new Guid("0dc4c235-45dc-46f0-a65a-57c15eeac838"), "ThomasCharles4@gmail.com", "Thomas", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "ThomasCharles4" },
                    { new Guid("ff3be9d5-01d3-4969-a21c-068d4358c79e"), "JamesJoseph3@gmail.com", "James", "Joseph", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesJoseph3" },
                    { new Guid("94c0db61-8a44-452e-a833-c230b15f0d5c"), "JohnCharles2@gmail.com", "John", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnCharles2" },
                    { new Guid("c7f55bbb-351d-4b09-8010-3bb4526ddf75"), "WilliamCharles9@gmail.com", "William", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "WilliamCharles9" },
                    { new Guid("10f42cb4-fff0-467a-9b95-a28e836d71f6"), "RichardRobert19@gmail.com", "Richard", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardRobert19" }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "CreatedBy", "Description", "StartingDate", "Title", "TournamentPrize" },
                values: new object[,]
                {
                    { new Guid("0968563a-6a71-4996-a1ac-90f8f2d2aef9"), new Guid("94c0db61-8a44-452e-a833-c230b15f0d5c"), "Sample description for A1 Grand Prix", new DateTime(2021, 4, 29, 9, 26, 0, 66, DateTimeKind.Local).AddTicks(2986), "A1 Grand Prix", 86383770f },
                    { new Guid("a9ae134a-1ca6-4f5f-9c76-5d33c8985333"), new Guid("ff3be9d5-01d3-4969-a21c-068d4358c79e"), "Sample description for Formula One World Championship", new DateTime(2021, 5, 2, 9, 26, 0, 73, DateTimeKind.Local).AddTicks(7184), "Formula One World Championship", 16369940f },
                    { new Guid("ffde6d03-c8ab-4bdb-9633-bb38dc9d35ab"), new Guid("0dc4c235-45dc-46f0-a65a-57c15eeac838"), "Sample description for FIA World Endurance Championship", new DateTime(2021, 5, 5, 9, 26, 0, 73, DateTimeKind.Local).AddTicks(8303), "FIA World Endurance Championship", 18019016f },
                    { new Guid("ba35ced5-119f-4783-8f30-0c26b20b485f"), new Guid("3a2f9a41-3d1a-46f5-9fe1-5ad80a52e2ac"), "Sample description for FIA GT1 World Championship", new DateTime(2021, 4, 27, 9, 26, 0, 73, DateTimeKind.Local).AddTicks(9093), "FIA GT1 World Championship", 81090480f },
                    { new Guid("77c19d35-9d55-4df0-aba8-1ed2ffee05f1"), new Guid("b0b7f05d-3192-46a9-8cad-8d10f581d09b"), "Sample description for World Gliding Championships", new DateTime(2021, 4, 30, 9, 26, 0, 73, DateTimeKind.Local).AddTicks(9848), "World Gliding Championships", 89821056f }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "BiddingRestrictedTos", "Description", "Title", "Total", "TournamentId", "Won" },
                values: new object[,]
                {
                    { new Guid("8dd2ba56-330f-4bbc-93f6-5cfcdf941693"), 0f, "Sample description for A1 Grand Prix Team 1", "A1 Grand Prix Team 1", 0f, new Guid("0968563a-6a71-4996-a1ac-90f8f2d2aef9"), true },
                    { new Guid("140f5997-3039-4514-a372-64689553ca98"), 0f, "Sample description for A1 Grand Prix Team 2", "A1 Grand Prix Team 2", 0f, new Guid("0968563a-6a71-4996-a1ac-90f8f2d2aef9"), false },
                    { new Guid("7d820849-f2ea-4868-9651-cfa5f572c033"), 0f, "Sample description for Formula One World Championship Team 1", "Formula One World Championship Team 1", 0f, new Guid("a9ae134a-1ca6-4f5f-9c76-5d33c8985333"), true },
                    { new Guid("04e68cf6-362c-4ca1-afad-df04e78a2a68"), 0f, "Sample description for Formula One World Championship Team 2", "Formula One World Championship Team 2", 0f, new Guid("a9ae134a-1ca6-4f5f-9c76-5d33c8985333"), false },
                    { new Guid("de28135e-cd70-45cd-8e75-457887734fa6"), 0f, "Sample description for FIA World Endurance Championship Team 1", "FIA World Endurance Championship Team 1", 0f, new Guid("ffde6d03-c8ab-4bdb-9633-bb38dc9d35ab"), true },
                    { new Guid("d4e1887b-f3ec-447b-8549-414f1f58413d"), 0f, "Sample description for FIA World Endurance Championship Team 2", "FIA World Endurance Championship Team 2", 0f, new Guid("ffde6d03-c8ab-4bdb-9633-bb38dc9d35ab"), false },
                    { new Guid("240ac667-86d6-468a-bc68-2399a403f303"), 0f, "Sample description for FIA GT1 World Championship Team 1", "FIA GT1 World Championship Team 1", 0f, new Guid("ba35ced5-119f-4783-8f30-0c26b20b485f"), true },
                    { new Guid("04f85a5e-b18f-4a6d-9003-db6bc46cc1e5"), 0f, "Sample description for FIA GT1 World Championship Team 2", "FIA GT1 World Championship Team 2", 0f, new Guid("ba35ced5-119f-4783-8f30-0c26b20b485f"), false },
                    { new Guid("0ba6d288-ee95-4566-af36-53fecd6714e7"), 0f, "Sample description for World Gliding Championships Team 1", "World Gliding Championships Team 1", 0f, new Guid("77c19d35-9d55-4df0-aba8-1ed2ffee05f1"), true },
                    { new Guid("cfce8c6c-3a10-43f9-929b-54911a48287c"), 0f, "Sample description for World Gliding Championships Team 2", "World Gliding Championships Team 2", 0f, new Guid("77c19d35-9d55-4df0-aba8-1ed2ffee05f1"), false }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "Id", "TeamId", "UserId", "UserId1" },
                values: new object[,]
                {
                    { new Guid("61d38af5-6392-4a7c-b6ae-bca604c5fd6f"), new Guid("8dd2ba56-330f-4bbc-93f6-5cfcdf941693"), 1, null },
                    { new Guid("6ac1ed0f-9254-4b35-a69b-1f7132d108f1"), new Guid("0ba6d288-ee95-4566-af36-53fecd6714e7"), 5, null },
                    { new Guid("f960510a-5437-4387-bfb1-9f3dd8b7dc0d"), new Guid("0ba6d288-ee95-4566-af36-53fecd6714e7"), 5, null },
                    { new Guid("337b1fe9-4cf1-4850-acff-2e9a50e20178"), new Guid("04f85a5e-b18f-4a6d-9003-db6bc46cc1e5"), 4, null },
                    { new Guid("1a311658-f5d9-495e-866c-c41c6525b231"), new Guid("04f85a5e-b18f-4a6d-9003-db6bc46cc1e5"), 4, null },
                    { new Guid("1e07e601-22d2-4872-90ae-267297a210e3"), new Guid("240ac667-86d6-468a-bc68-2399a403f303"), 4, null },
                    { new Guid("992cfb77-8dec-497b-b2bf-e1cb1aae20a7"), new Guid("240ac667-86d6-468a-bc68-2399a403f303"), 4, null },
                    { new Guid("c386aa1b-d1ed-4b5c-8591-99305b30cb59"), new Guid("d4e1887b-f3ec-447b-8549-414f1f58413d"), 3, null },
                    { new Guid("17bb9d03-1b22-49c5-83b0-ef89556e3aeb"), new Guid("d4e1887b-f3ec-447b-8549-414f1f58413d"), 3, null },
                    { new Guid("f38a31c8-bf07-4e2e-b2be-ac218a5acb65"), new Guid("de28135e-cd70-45cd-8e75-457887734fa6"), 3, null },
                    { new Guid("773fcc3c-d53a-45f9-8a52-5facfec298e8"), new Guid("de28135e-cd70-45cd-8e75-457887734fa6"), 3, null },
                    { new Guid("bff95abb-110d-4dc8-8872-724754dcf66f"), new Guid("04e68cf6-362c-4ca1-afad-df04e78a2a68"), 2, null },
                    { new Guid("cf1555dd-4b5b-4a4a-ba39-ec5289ba20e3"), new Guid("04e68cf6-362c-4ca1-afad-df04e78a2a68"), 2, null },
                    { new Guid("2be07827-c9a6-4e60-9c9b-550fc5e9904b"), new Guid("7d820849-f2ea-4868-9651-cfa5f572c033"), 2, null },
                    { new Guid("07a50dcf-96e9-47de-b393-d2ed44c3c13e"), new Guid("7d820849-f2ea-4868-9651-cfa5f572c033"), 2, null },
                    { new Guid("0f3e724a-0785-4c67-a846-f802ba4fa252"), new Guid("140f5997-3039-4514-a372-64689553ca98"), 1, null },
                    { new Guid("008180c8-6745-41ab-851f-a44da3eea6d2"), new Guid("140f5997-3039-4514-a372-64689553ca98"), 1, null },
                    { new Guid("8f513448-b3af-4b0c-9bf2-4346e29ddc14"), new Guid("8dd2ba56-330f-4bbc-93f6-5cfcdf941693"), 1, null },
                    { new Guid("cc160837-5662-45d8-9fa9-8c36c0ae3331"), new Guid("cfce8c6c-3a10-43f9-929b-54911a48287c"), 5, null },
                    { new Guid("6ee529da-7683-4c52-a498-b49e9b8c249b"), new Guid("cfce8c6c-3a10-43f9-929b-54911a48287c"), 5, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_TeamId1",
                table: "Bidding",
                column: "TeamId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_UserId",
                table: "Bidding",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_TournamentId",
                table: "Team",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TeamId",
                table: "TeamMember",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_UserId1",
                table: "TeamMember",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_CreatedBy",
                table: "Tournament",
                column: "CreatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bidding");

            migrationBuilder.DropTable(
                name: "TeamMember");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
