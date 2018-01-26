using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class Changepicturetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Userpresence");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "PictureData");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Userpresence",
                newName: "Datetime");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "PictureData",
                newName: "DateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Datetime",
                table: "Userpresence",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "PictureData",
                newName: "Time");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Userpresence",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "PictureData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
