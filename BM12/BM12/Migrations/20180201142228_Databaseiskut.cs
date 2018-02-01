using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class Databaseiskut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_UserActivity_UserActivityID1",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_User_UserID",
                table: "PictureData");

            migrationBuilder.DropIndex(
                name: "IX_PictureData_UserActivityID1",
                table: "PictureData");

            migrationBuilder.DropIndex(
                name: "IX_PictureData_UserID",
                table: "PictureData");

            migrationBuilder.DropColumn(
                name: "UserActivityID",
                table: "PictureData");

            migrationBuilder.DropColumn(
                name: "UserActivityID1",
                table: "PictureData");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "PictureData");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_PictureDataID",
                table: "UserActivity",
                column: "PictureDataID");

            migrationBuilder.AddForeignKey(
                name: "FK_UserActivity_PictureData_PictureDataID",
                table: "UserActivity",
                column: "PictureDataID",
                principalTable: "PictureData",
                principalColumn: "PictureDataID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserActivity_PictureData_PictureDataID",
                table: "UserActivity");

            migrationBuilder.DropIndex(
                name: "IX_UserActivity_PictureDataID",
                table: "UserActivity");

            migrationBuilder.AddColumn<int>(
                name: "UserActivityID",
                table: "PictureData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserActivityID1",
                table: "PictureData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "PictureData",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PictureData_UserActivityID1",
                table: "PictureData",
                column: "UserActivityID1");

            migrationBuilder.CreateIndex(
                name: "IX_PictureData_UserID",
                table: "PictureData",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PictureData_UserActivity_UserActivityID1",
                table: "PictureData",
                column: "UserActivityID1",
                principalTable: "UserActivity",
                principalColumn: "UserActivityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureData_User_UserID",
                table: "PictureData",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
