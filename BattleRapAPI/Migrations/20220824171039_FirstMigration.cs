using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BattleRapAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Participant1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Participant2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Winner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BattleRounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoundNumber = table.Column<byte>(type: "tinyint", nullable: false),
                    Winner = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BattleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BattleRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BattleRounds_Battles_BattleId",
                        column: x => x.BattleId,
                        principalTable: "Battles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BattleRounds_BattleId",
                table: "BattleRounds",
                column: "BattleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BattleRounds");

            migrationBuilder.DropTable(
                name: "Battles");
        }
    }
}
