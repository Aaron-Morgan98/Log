using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class MadeIdRequiredAndAddedStory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Story",
                table: "GameLogs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Difficulty", "Story" },
                values: new object[] { 8, 9 });

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 2,
                column: "Story",
                value: 9);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Story",
                table: "GameLogs");

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Difficulty",
                value: 9);
        }
    }
}
