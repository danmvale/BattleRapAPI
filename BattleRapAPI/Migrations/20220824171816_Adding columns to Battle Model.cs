using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BattleRapAPI.Migrations
{
    public partial class AddingcolumnstoBattleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoThumbnail",
                table: "Battles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoTitle",
                table: "Battles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VideoUrl",
                table: "Battles",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoThumbnail",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "VideoTitle",
                table: "Battles");

            migrationBuilder.DropColumn(
                name: "VideoUrl",
                table: "Battles");
        }
    }
}
