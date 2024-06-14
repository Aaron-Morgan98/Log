using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class MadeDateStartedOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameEntities",
                table: "GameEntities");

            migrationBuilder.RenameTable(
                name: "GameEntities",
                newName: "GameLogs");

            migrationBuilder.AlterColumn<string>(
                name: "DateStarted",
                table: "GameLogs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameLogs",
                table: "GameLogs",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameLogs",
                table: "GameLogs");

            migrationBuilder.RenameTable(
                name: "GameLogs",
                newName: "GameEntities");

            migrationBuilder.AlterColumn<string>(
                name: "DateStarted",
                table: "GameEntities",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameEntities",
                table: "GameEntities",
                column: "GameId");
        }
    }
}
