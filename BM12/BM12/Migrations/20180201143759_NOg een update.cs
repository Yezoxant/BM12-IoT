using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class NOgeenupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassCourseID",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Activities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ClassCourseID",
                table: "Activities",
                column: "ClassCourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_ClassCourse_ClassCourseID",
                table: "Activities",
                column: "ClassCourseID",
                principalTable: "ClassCourse",
                principalColumn: "ClassCourseID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_ClassCourse_ClassCourseID",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_ClassCourseID",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ClassCourseID",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Activities");
        }
    }
}
