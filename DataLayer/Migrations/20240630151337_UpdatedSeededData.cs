using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "DateCompleted", "DateStarted", "Review" },
                values: new object[] { null, null, "Amazing world/level design, the majority of the world is interconnected. A lot of the side quests are very hidden/confusing, you need a guide majority of the time. Combat is amazing, movement is holding it back however. Both DLCs add difficulity and the fight with Artorias is so far my favourite in the DS series." });

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Rating", "Review", "Story", "Title" },
                values: new object[] { 6, "A bit of a let down after DS 1. The level design is still great, but the combat is so slow (healing), the game was a bit of a chore to get through at the latter stages. ADP is a also an awful addition. DLCs lackluster, seemed like they were just thrown in.", 6, "Dark Souls 2" });

            migrationBuilder.InsertData(
                table: "GameLogs",
                columns: new[] { "GameId", "DateCompleted", "DateReleased", "DateStarted", "Difficulty", "Rating", "Review", "Story", "Title" },
                values: new object[] { 3, null, "13/02/2018", null, 8, 9, "A great comback after DS2, level design is top tier, every area made me want to explore. The bosses were a major improvement over the last two games. The DLC here is also on par if not better than DS1 DLC. Story and lore is also interesting", 9, "Dark Souls 3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "DateCompleted", "DateStarted", "Review" },
                values: new object[] { "15/03/2024", "01/02/2024", "Amazing difficulty and level design. Bit confusing at times." });

            migrationBuilder.UpdateData(
                table: "GameLogs",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Rating", "Review", "Story", "Title" },
                values: new object[] { 9, "Great open world and very immersive. Steep learning curve.", 9, "Kingdom Come: Deliverance" });
        }
    }
}
