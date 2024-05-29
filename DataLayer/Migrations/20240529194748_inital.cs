using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameEntities",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    DateReleased = table.Column<string>(type: "TEXT", nullable: true),
                    DateStarted = table.Column<string>(type: "TEXT", nullable: true),
                    DateCompleted = table.Column<string>(type: "TEXT", nullable: true),
                    Review = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameEntities", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "GameEntities",
                columns: new[] { "GameId", "DateCompleted", "DateReleased", "DateStarted", "Rating", "Review", "Title" },
                values: new object[] { 1, "11/05/2024", "22/09/2011", "01/03/2024", 8, "Amazing difficulty. Bit confusing at times.", "Dark Souls 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameEntities");
        }
    }
}
