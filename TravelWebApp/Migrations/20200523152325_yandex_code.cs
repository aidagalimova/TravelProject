using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelWebApp.Migrations
{
    public partial class yandex_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YandexCode",
                table: "Cities",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YandexCode",
                table: "Cities");
        }
    }
}
