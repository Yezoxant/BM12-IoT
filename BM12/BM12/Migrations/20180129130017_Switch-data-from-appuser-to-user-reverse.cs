using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class Switchdatafromappusertouserreverse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbackanswers_Users_UserId",
                table: "Feedbackanswers");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_Users_UserId",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_Userpresence_Users_UserId",
                table: "Userpresence");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_AspNetUsers_IdentityId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_IdentityId",
                table: "User",
                newName: "IX_User_IdentityId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ClassId",
                table: "User",
                newName: "IX_User_ClassId");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbackanswers_User_UserId",
                table: "Feedbackanswers",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureData_User_UserId",
                table: "PictureData",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Classes_ClassId",
                table: "User",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_IdentityId",
                table: "User",
                column: "IdentityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Userpresence_User_UserId",
                table: "Userpresence",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbackanswers_User_UserId",
                table: "Feedbackanswers");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_User_UserId",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Classes_ClassId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_IdentityId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Userpresence_User_UserId",
                table: "Userpresence");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_IdentityId",
                table: "Users",
                newName: "IX_Users_IdentityId");

            migrationBuilder.RenameIndex(
                name: "IX_User_ClassId",
                table: "Users",
                newName: "IX_Users_ClassId");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Users",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Users",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbackanswers_Users_UserId",
                table: "Feedbackanswers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureData_Users_UserId",
                table: "PictureData",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Userpresence_Users_UserId",
                table: "Userpresence",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_AspNetUsers_IdentityId",
                table: "Users",
                column: "IdentityId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
