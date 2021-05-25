using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class commentsandlikesadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bidding_Team_TeamId",
                table: "Bidding");

            migrationBuilder.DropForeignKey(
                name: "FK_Bidding_AspNetUsers_UserId",
                table: "Bidding");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Tournament_TournamentId",
                table: "Team");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_Team_TeamId",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMember_AspNetUsers_UserId",
                table: "TeamMember");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournament_AspNetUsers_CreatedBy",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bidding",
                table: "Bidding");

            migrationBuilder.RenameTable(
                name: "Tournament",
                newName: "Tournaments");

            migrationBuilder.RenameTable(
                name: "TeamMember",
                newName: "TeamMembers");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "Bidding",
                newName: "Biddings");

            migrationBuilder.RenameIndex(
                name: "IX_Tournament_CreatedBy",
                table: "Tournaments",
                newName: "IX_Tournaments_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMember_UserId_TeamId",
                table: "TeamMembers",
                newName: "IX_TeamMembers_UserId_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMember_TeamId",
                table: "TeamMembers",
                newName: "IX_TeamMembers_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Team_TournamentId",
                table: "Teams",
                newName: "IX_Teams_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Bidding_UserId",
                table: "Biddings",
                newName: "IX_Biddings_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Bidding_TeamId",
                table: "Biddings",
                newName: "IX_Biddings_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Biddings",
                table: "Biddings",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TournamentId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TournamentId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    AppUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Likes_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AppUserId",
                table: "Comments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TournamentId",
                table: "Comments",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_AppUserId",
                table: "Likes",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TournamentId",
                table: "Likes",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_UserId_TournamentId",
                table: "Likes",
                columns: new[] { "UserId", "TournamentId" },
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Biddings_Teams_TeamId",
                table: "Biddings",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Biddings_AspNetUsers_UserId",
                table: "Biddings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_Teams_TeamId",
                table: "TeamMembers",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMembers_AspNetUsers_UserId",
                table: "TeamMembers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Tournaments_TournamentId",
                table: "Teams",
                column: "TournamentId",
                principalTable: "Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournaments_AspNetUsers_CreatedBy",
                table: "Tournaments",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Biddings_Teams_TeamId",
                table: "Biddings");

            migrationBuilder.DropForeignKey(
                name: "FK_Biddings_AspNetUsers_UserId",
                table: "Biddings");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_Teams_TeamId",
                table: "TeamMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMembers_AspNetUsers_UserId",
                table: "TeamMembers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Tournaments_TournamentId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournaments_AspNetUsers_CreatedBy",
                table: "Tournaments");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tournaments",
                table: "Tournaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMembers",
                table: "TeamMembers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Biddings",
                table: "Biddings");

            migrationBuilder.RenameTable(
                name: "Tournaments",
                newName: "Tournament");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "TeamMembers",
                newName: "TeamMember");

            migrationBuilder.RenameTable(
                name: "Biddings",
                newName: "Bidding");

            migrationBuilder.RenameIndex(
                name: "IX_Tournaments_CreatedBy",
                table: "Tournament",
                newName: "IX_Tournament_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_TournamentId",
                table: "Team",
                newName: "IX_Team_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMembers_UserId_TeamId",
                table: "TeamMember",
                newName: "IX_TeamMember_UserId_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMember",
                newName: "IX_TeamMember_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Biddings_UserId",
                table: "Bidding",
                newName: "IX_Bidding_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Biddings_TeamId",
                table: "Bidding",
                newName: "IX_Bidding_TeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tournament",
                table: "Tournament",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bidding",
                table: "Bidding",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bidding_Team_TeamId",
                table: "Bidding",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bidding_AspNetUsers_UserId",
                table: "Bidding",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Tournament_TournamentId",
                table: "Team",
                column: "TournamentId",
                principalTable: "Tournament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_Team_TeamId",
                table: "TeamMember",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMember_AspNetUsers_UserId",
                table: "TeamMember",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournament_AspNetUsers_CreatedBy",
                table: "Tournament",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
