﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class ChangedDatesToStrings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DateCompleted",
                table: "GameEntities",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "GameEntities",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "DateCompleted", "DateReleased", "DateStarted" },
                values: new object[] { "15/03/2024", "22/09/2011", "01/02/2024" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateCompleted",
                table: "GameEntities",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "GameEntities",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "DateCompleted", "DateReleased", "DateStarted" },
                values: new object[] { new DateOnly(2024, 3, 15), new DateOnly(2011, 9, 22), new DateOnly(2024, 2, 1) });
        }
    }
}
