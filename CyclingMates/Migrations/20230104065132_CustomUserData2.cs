using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CyclingMates.Migrations
{
    /// <inheritdoc />
    public partial class CustomUserData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Activity",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Activity",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Activity",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place",
                table: "Activity",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDateTime",
                table: "Activity",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "Place",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "PublishedDateTime",
                table: "Activity");
        }
    }
}
