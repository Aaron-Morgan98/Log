using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreSeededDataForGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Review",
                value: "Amazing difficulty and level design. Bit confusing at times.");

            migrationBuilder.InsertData(
                table: "GameLogs",
                columns: new[] { "GameId", "DateCompleted", "DateReleased", "DateStarted", "Rating", "Review", "Title" },
                values: new object[] { 2, null, "13/02/2018", null, 9, "Great open world and very immersive. Steep learning curve.", "Kingdom Come: Deliverance" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                column: "Review",
                value: "Amazing difficulty. Bit confusing at times.");
        }
    }
}
