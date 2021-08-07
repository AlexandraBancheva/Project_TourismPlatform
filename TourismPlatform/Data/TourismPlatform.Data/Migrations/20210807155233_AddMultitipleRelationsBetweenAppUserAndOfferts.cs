using Microsoft.EntityFrameworkCore.Migrations;

namespace TourismPlatform.Data.Migrations
{
    public partial class AddMultitipleRelationsBetweenAppUserAndOfferts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentUserOfferts");

            migrationBuilder.AddColumn<string>(
                name: "CreatedApplicationUserId",
                table: "Offerts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Offerts_CreatedApplicationUserId",
                table: "Offerts",
                column: "CreatedApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Offerts_AspNetUsers_CreatedApplicationUserId",
                table: "Offerts",
                column: "CreatedApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offerts_AspNetUsers_CreatedApplicationUserId",
                table: "Offerts");

            migrationBuilder.DropIndex(
                name: "IX_Offerts_CreatedApplicationUserId",
                table: "Offerts");

            migrationBuilder.DropColumn(
                name: "CreatedApplicationUserId",
                table: "Offerts");

            migrationBuilder.CreateTable(
                name: "AgentUserOfferts",
                columns: table => new
                {
                    OffertId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AgentId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentUserOfferts", x => new { x.OffertId, x.AgentId });
                    table.ForeignKey(
                        name: "FK_AgentUserOfferts_AspNetUsers_AgentId",
                        column: x => x.AgentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgentUserOfferts_Offerts_OffertId",
                        column: x => x.OffertId,
                        principalTable: "Offerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AgentUserOfferts_AgentId",
                table: "AgentUserOfferts",
                column: "AgentId");
        }
    }
}
