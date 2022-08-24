using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BattleRapAPI.Migrations
{
    public partial class ColumnofBattleVideoThumbnailnamechangedtoVideoThumbnailUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoThumbnail",
                table: "Battles",
                newName: "VideoThumbnailUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VideoThumbnailUrl",
                table: "Battles",
                newName: "VideoThumbnail");
        }
    }
}
