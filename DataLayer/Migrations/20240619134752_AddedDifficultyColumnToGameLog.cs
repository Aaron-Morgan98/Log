using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedDifficultyColumnToGameLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "GameLogs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Difficulty",
                value: 9);

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Difficulty",
                value: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "GameLogs");
        }
    }
}
