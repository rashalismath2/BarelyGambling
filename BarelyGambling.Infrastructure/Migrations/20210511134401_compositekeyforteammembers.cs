using Microsoft.EntityFrameworkCore.Migrations;

namespace BarelyGambling.Infrastructure.Migrations
{
    public partial class compositekeyforteammembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_UserId_TeamId",
                table: "TeamMember",
                columns: new[] { "UserId", "TeamId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember");

            migrationBuilder.DropIndex(
                name: "IX_TeamMember_UserId_TeamId",
                table: "TeamMember");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamMember",
                table: "TeamMember",
                columns: new[] { "UserId", "TeamId" });
        }
    }
}
