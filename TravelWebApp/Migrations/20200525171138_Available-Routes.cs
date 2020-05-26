using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelWebApp.Migrations
{
    public partial class AvailableRoutes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Cities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CityId",
                table: "Cities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Cities_CityId",
                table: "Cities",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Cities_CityId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_CityId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Cities");
        }
    }
}
