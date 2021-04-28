using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class init3 : Migration
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
                    UserName = table.Column<string>(nullable: false),
                    CoverUrl = table.Column<string>(nullable: true)
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
                    Place = table.Column<string>(nullable: false),
                    TournamentPrize = table.Column<float>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
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
                    TeamId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bidding", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bidding_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bidding_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
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
                        name: "FK_TeamMember_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CoverUrl", "Email", "FirstName", "LastName", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("0c8f33ce-8adf-4600-986c-8f4900c64f1b"), "https://via.placeholder.com/150", "MichaelJames1@gmail.com", "Michael", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelJames1" },
                    { new Guid("1338c622-25cc-46c0-bc09-018127721692"), "https://via.placeholder.com/150", "MichaelMichael17@gmail.com", "Michael", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelMichael17" },
                    { new Guid("2f627f6e-f7a2-407c-8c95-890c08f8c285"), "https://via.placeholder.com/150", "JosephWilliam16@gmail.com", "Joseph", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephWilliam16" },
                    { new Guid("bb5ab594-aecd-4365-ba51-dbeffc40a7c0"), "https://via.placeholder.com/150", "JohnMichael15@gmail.com", "John", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnMichael15" },
                    { new Guid("50ff2791-a009-4252-b302-2006bb2712f2"), "https://via.placeholder.com/150", "JamesThomas14@gmail.com", "James", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesThomas14" },
                    { new Guid("2a814a97-cbc6-4be6-9a6d-887eeba43d39"), "https://via.placeholder.com/150", "JamesMichael13@gmail.com", "James", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesMichael13" },
                    { new Guid("b8a2508e-fd5f-423a-af6e-1671cf6a2b80"), "https://via.placeholder.com/150", "RobertWilliam12@gmail.com", "Robert", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RobertWilliam12" },
                    { new Guid("6b9323ce-1a5f-4bcf-8ce6-81a992421e03"), "https://via.placeholder.com/150", "RichardJames11@gmail.com", "Richard", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "RichardJames11" },
                    { new Guid("fb345d13-7f7e-4a77-b2cf-ae408bba3490"), "https://via.placeholder.com/150", "JosephJohn18@gmail.com", "Joseph", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJohn18" },
                    { new Guid("5ae9487a-6ea4-4e59-852c-48f60f309b70"), "https://via.placeholder.com/150", "JosephThomas10@gmail.com", "Joseph", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephThomas10" },
                    { new Guid("a89d1159-85cf-48e3-9aad-f770256a1e03"), "https://via.placeholder.com/150", "JohnJames8@gmail.com", "John", "James", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnJames8" },
                    { new Guid("8b92c1d2-222c-4409-931a-fe8c2d662095"), "https://via.placeholder.com/150", "JamesWilliam7@gmail.com", "James", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JamesWilliam7" },
                    { new Guid("594a8031-bbbe-4a93-b63b-848d83c57144"), "https://via.placeholder.com/150", "MichaelMichael6@gmail.com", "Michael", "Michael", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelMichael6" },
                    { new Guid("24485364-9105-4ccd-b5c2-171b691f185d"), "https://via.placeholder.com/150", "JohnDavid5@gmail.com", "John", "David", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnDavid5" },
                    { new Guid("a6bcdd93-d29e-402a-b866-c765817a2461"), "https://via.placeholder.com/150", "JosephJohn4@gmail.com", "Joseph", "John", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephJohn4" },
                    { new Guid("d0ead67c-717f-4df1-816c-844652df604f"), "https://via.placeholder.com/150", "JohnThomas3@gmail.com", "John", "Thomas", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnThomas3" },
                    { new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed"), "https://via.placeholder.com/150", "MichaelWilliam2@gmail.com", "Michael", "William", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "MichaelWilliam2" },
                    { new Guid("9899c8bf-24d4-49cd-a533-3cd93b4b64e1"), "https://via.placeholder.com/150", "JosephRobert9@gmail.com", "Joseph", "Robert", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JosephRobert9" },
                    { new Guid("62d890ce-3afc-47fd-86ad-e4808e3b51d3"), "https://via.placeholder.com/150", "JohnCharles19@gmail.com", "John", "Charles", "$2a$11$Hx.1.HZkvkfw7T52BbdhLuJQAhdvR5Y.1nSvwCxJ1sK9paLLtqi5S", "JohnCharles19" }
                });

            migrationBuilder.InsertData(
                table: "Tournament",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Place", "StartingDate", "Title", "TournamentPrize" },
                values: new object[,]
                {
                    { new Guid("d2bea1cd-0754-4cb8-831a-fb621f8fc34c"), new DateTime(2021, 4, 28, 15, 42, 57, 36, DateTimeKind.Local).AddTicks(820), new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed"), "Sample description for A1 Grand Prix", "Los Angeles", new DateTime(2021, 5, 3, 15, 42, 57, 34, DateTimeKind.Local).AddTicks(7186), "A1 Grand Prix", 29628888f },
                    { new Guid("416e23f6-0aa1-4e15-af12-2afde162d6a5"), new DateTime(2021, 4, 28, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(5846), new Guid("d0ead67c-717f-4df1-816c-844652df604f"), "Sample description for Formula One World Championship", "Los Angeles", new DateTime(2021, 4, 28, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(5804), "Formula One World Championship", 52812552f },
                    { new Guid("cbfb02a9-7ea4-4c27-bd99-f726127e6af3"), new DateTime(2021, 4, 28, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(6565), new Guid("a6bcdd93-d29e-402a-b866-c765817a2461"), "Sample description for FIA World Endurance Championship", "Los Angeles", new DateTime(2021, 5, 6, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(6559), "FIA World Endurance Championship", 5298869f },
                    { new Guid("32a8201b-939c-46c2-bd90-38660021836a"), new DateTime(2021, 4, 28, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(6908), new Guid("24485364-9105-4ccd-b5c2-171b691f185d"), "Sample description for FIA GT1 World Championship", "Los Angeles", new DateTime(2021, 5, 2, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(6903), "FIA GT1 World Championship", 46675196f },
                    { new Guid("b1c5b2e6-ad5f-416f-b66c-eeb0b1444b79"), new DateTime(2021, 4, 28, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(7247), new Guid("594a8031-bbbe-4a93-b63b-848d83c57144"), "Sample description for World Gliding Championships", "Los Angeles", new DateTime(2021, 5, 7, 15, 42, 57, 37, DateTimeKind.Local).AddTicks(7242), "World Gliding Championships", 10156761f }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "BiddingRestrictedTos", "Description", "Title", "Total", "TournamentId", "Won" },
                values: new object[,]
                {
                    { new Guid("5db63212-9e2f-4200-8e58-93b05c25e8c7"), 0f, "Sample description for A1 Grand Prix Team 1", "A1 Grand Prix Team 1", 0f, new Guid("d2bea1cd-0754-4cb8-831a-fb621f8fc34c"), true },
                    { new Guid("0fd4f642-20a5-4076-8e30-cdecf6fee415"), 0f, "Sample description for A1 Grand Prix Team 2", "A1 Grand Prix Team 2", 0f, new Guid("d2bea1cd-0754-4cb8-831a-fb621f8fc34c"), false },
                    { new Guid("c08374e7-a236-482d-878a-6db6c7b4e573"), 0f, "Sample description for Formula One World Championship Team 1", "Formula One World Championship Team 1", 0f, new Guid("416e23f6-0aa1-4e15-af12-2afde162d6a5"), true },
                    { new Guid("73c7be01-268a-4d31-921e-d3fa860a0768"), 0f, "Sample description for Formula One World Championship Team 2", "Formula One World Championship Team 2", 0f, new Guid("416e23f6-0aa1-4e15-af12-2afde162d6a5"), false },
                    { new Guid("ee7ba12c-ef9d-405e-b45d-3acb8fb3394d"), 0f, "Sample description for FIA World Endurance Championship Team 1", "FIA World Endurance Championship Team 1", 0f, new Guid("cbfb02a9-7ea4-4c27-bd99-f726127e6af3"), true },
                    { new Guid("b2a8bff2-dfd9-4ca2-bde3-bf217b592554"), 0f, "Sample description for FIA World Endurance Championship Team 2", "FIA World Endurance Championship Team 2", 0f, new Guid("cbfb02a9-7ea4-4c27-bd99-f726127e6af3"), false },
                    { new Guid("eb2bee40-6b9d-4422-b7c7-f1a4a54c01ff"), 0f, "Sample description for FIA GT1 World Championship Team 1", "FIA GT1 World Championship Team 1", 0f, new Guid("32a8201b-939c-46c2-bd90-38660021836a"), true },
                    { new Guid("b4715dd4-cb27-43b8-bd8b-172da55c983a"), 0f, "Sample description for FIA GT1 World Championship Team 2", "FIA GT1 World Championship Team 2", 0f, new Guid("32a8201b-939c-46c2-bd90-38660021836a"), false },
                    { new Guid("ec477169-6883-49c0-9d0e-0ed966fd7e14"), 0f, "Sample description for World Gliding Championships Team 1", "World Gliding Championships Team 1", 0f, new Guid("b1c5b2e6-ad5f-416f-b66c-eeb0b1444b79"), true },
                    { new Guid("1a9ddbe8-ba40-4735-9022-25333119f96e"), 0f, "Sample description for World Gliding Championships Team 2", "World Gliding Championships Team 2", 0f, new Guid("b1c5b2e6-ad5f-416f-b66c-eeb0b1444b79"), false }
                });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "Id", "TeamId", "UserId" },
                values: new object[,]
                {
                    { new Guid("73443d29-1337-4119-9139-6ebb54b2ca64"), new Guid("5db63212-9e2f-4200-8e58-93b05c25e8c7"), new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed") },
                    { new Guid("76c1f6bd-9280-4111-ad5c-151d5140a824"), new Guid("ec477169-6883-49c0-9d0e-0ed966fd7e14"), new Guid("594a8031-bbbe-4a93-b63b-848d83c57144") },
                    { new Guid("ad868821-302f-4f31-89e3-b4e82c338572"), new Guid("ec477169-6883-49c0-9d0e-0ed966fd7e14"), new Guid("594a8031-bbbe-4a93-b63b-848d83c57144") },
                    { new Guid("8ef2c523-5d0d-481a-9b09-9c02c53453fd"), new Guid("b4715dd4-cb27-43b8-bd8b-172da55c983a"), new Guid("24485364-9105-4ccd-b5c2-171b691f185d") },
                    { new Guid("27852c66-bac6-49a4-964c-6b8635993e59"), new Guid("b4715dd4-cb27-43b8-bd8b-172da55c983a"), new Guid("24485364-9105-4ccd-b5c2-171b691f185d") },
                    { new Guid("4d57e93f-ce8b-41da-a685-7b03661f4535"), new Guid("eb2bee40-6b9d-4422-b7c7-f1a4a54c01ff"), new Guid("24485364-9105-4ccd-b5c2-171b691f185d") },
                    { new Guid("091a2d02-fd04-4a38-a7b3-13da3cda8802"), new Guid("eb2bee40-6b9d-4422-b7c7-f1a4a54c01ff"), new Guid("24485364-9105-4ccd-b5c2-171b691f185d") },
                    { new Guid("e698c7c0-6796-4ebb-9e0d-fcbcd7b0242b"), new Guid("b2a8bff2-dfd9-4ca2-bde3-bf217b592554"), new Guid("a6bcdd93-d29e-402a-b866-c765817a2461") },
                    { new Guid("89933ebb-8f12-45a8-9601-8c472e4ed913"), new Guid("b2a8bff2-dfd9-4ca2-bde3-bf217b592554"), new Guid("a6bcdd93-d29e-402a-b866-c765817a2461") },
                    { new Guid("a41ecf7d-5eb9-4b4b-944c-a6abc107261d"), new Guid("ee7ba12c-ef9d-405e-b45d-3acb8fb3394d"), new Guid("a6bcdd93-d29e-402a-b866-c765817a2461") },
                    { new Guid("981b1857-0158-4f67-aa29-d561e4007191"), new Guid("ee7ba12c-ef9d-405e-b45d-3acb8fb3394d"), new Guid("a6bcdd93-d29e-402a-b866-c765817a2461") },
                    { new Guid("3b8b92a2-65e6-48bb-96c5-f2412bd90d45"), new Guid("73c7be01-268a-4d31-921e-d3fa860a0768"), new Guid("d0ead67c-717f-4df1-816c-844652df604f") },
                    { new Guid("6d237c92-a109-439c-aa1f-a552656adcd5"), new Guid("73c7be01-268a-4d31-921e-d3fa860a0768"), new Guid("d0ead67c-717f-4df1-816c-844652df604f") },
                    { new Guid("f7adc539-d33c-4e08-823c-c460bbc2d255"), new Guid("c08374e7-a236-482d-878a-6db6c7b4e573"), new Guid("d0ead67c-717f-4df1-816c-844652df604f") },
                    { new Guid("b90e5ff3-644c-47b8-b9fd-307f1b20557b"), new Guid("c08374e7-a236-482d-878a-6db6c7b4e573"), new Guid("d0ead67c-717f-4df1-816c-844652df604f") },
                    { new Guid("0400f394-be0a-4603-a543-ab9d422cc17b"), new Guid("0fd4f642-20a5-4076-8e30-cdecf6fee415"), new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed") },
                    { new Guid("f852819b-2411-44be-8ebc-b8302cb0bf16"), new Guid("0fd4f642-20a5-4076-8e30-cdecf6fee415"), new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed") },
                    { new Guid("e0989077-21ad-415c-ae2a-ea1723a93b72"), new Guid("5db63212-9e2f-4200-8e58-93b05c25e8c7"), new Guid("6c78ad50-8a96-4a1b-a9ee-2fbeb63aa6ed") },
                    { new Guid("612fc868-6ac0-4c38-8ec1-9245f804e0d3"), new Guid("1a9ddbe8-ba40-4735-9022-25333119f96e"), new Guid("594a8031-bbbe-4a93-b63b-848d83c57144") },
                    { new Guid("f438c7db-1556-4535-8382-7f83d229bcd8"), new Guid("1a9ddbe8-ba40-4735-9022-25333119f96e"), new Guid("594a8031-bbbe-4a93-b63b-848d83c57144") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bidding_TeamId",
                table: "Bidding",
                column: "TeamId");

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
                name: "IX_TeamMember_UserId",
                table: "TeamMember",
                column: "UserId");

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
