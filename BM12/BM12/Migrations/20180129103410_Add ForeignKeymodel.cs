using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class AddForeignKeymodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbackanswers_FeedbackQuestions_FeedbackQuestionId",
                table: "Feedbackanswers");

            migrationBuilder.DropForeignKey(
                name: "FK_Feedbackanswers_Users_userId",
                table: "Feedbackanswers");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_Users_UserId",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_Userpresence_Users_userId",
                table: "Userpresence");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Userpresence",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Userpresence_userId",
                table: "Userpresence",
                newName: "IX_Userpresence_UserId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Feedbackanswers",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbackanswers_userId",
                table: "Feedbackanswers",
                newName: "IX_Feedbackanswers_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Userpresence",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PictureData",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Feedbackanswers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackQuestionId",
                table: "Feedbackanswers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbackanswers_FeedbackQuestions_FeedbackQuestionId",
                table: "Feedbackanswers",
                column: "FeedbackQuestionId",
                principalTable: "FeedbackQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbackanswers_FeedbackQuestions_FeedbackQuestionId",
                table: "Feedbackanswers");

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

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Userpresence",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Userpresence_UserId",
                table: "Userpresence",
                newName: "IX_Userpresence_userId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Feedbackanswers",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Feedbackanswers_UserId",
                table: "Feedbackanswers",
                newName: "IX_Feedbackanswers_userId");

            migrationBuilder.AlterColumn<int>(
                name: "ClassId",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Userpresence",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PictureData",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "Feedbackanswers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FeedbackQuestionId",
                table: "Feedbackanswers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbackanswers_FeedbackQuestions_FeedbackQuestionId",
                table: "Feedbackanswers",
                column: "FeedbackQuestionId",
                principalTable: "FeedbackQuestions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbackanswers_Users_userId",
                table: "Feedbackanswers",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureData_Users_UserId",
                table: "PictureData",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Userpresence_Users_userId",
                table: "Userpresence",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Classes_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
