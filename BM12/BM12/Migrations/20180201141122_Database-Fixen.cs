using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace BM12Webapplication.Migrations
{
    public partial class DatabaseFixen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_User_UserId",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Classes_ClassId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Feedbackanswers");

            migrationBuilder.DropTable(
                name: "Userpresence");

            migrationBuilder.DropTable(
                name: "FeedbackQuestions");

            migrationBuilder.DropIndex(
                name: "IX_User_ClassId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "User",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PictureData",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PictureData",
                newName: "PictureDataID");

            migrationBuilder.RenameIndex(
                name: "IX_PictureData_UserId",
                table: "PictureData",
                newName: "IX_PictureData_UserID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Classes",
                newName: "ClassID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "PictureData",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserActivityID",
                table: "PictureData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserActivityID1",
                table: "PictureData",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Blocknumber = table.Column<int>(nullable: false),
                    CourseName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "UserClass",
                columns: table => new
                {
                    UserClassID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClass", x => x.UserClassID);
                    table.ForeignKey(
                        name: "FK_UserClass_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserClass_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserActivity",
                columns: table => new
                {
                    UserActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityID = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    PictureDataID = table.Column<int>(nullable: false),
                    Presence = table.Column<bool>(nullable: false),
                    PresenceDatetime = table.Column<DateTime>(nullable: false),
                    Stars = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActivity", x => x.UserActivityID);
                    table.ForeignKey(
                        name: "FK_UserActivity_Activities_ActivityID",
                        column: x => x.ActivityID,
                        principalTable: "Activities",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserActivity_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassCourse",
                columns: table => new
                {
                    ClassCourseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassID = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCourse", x => x.ClassCourseID);
                    table.ForeignKey(
                        name: "FK_ClassCourse_Classes_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Classes",
                        principalColumn: "ClassID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassCourse_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PictureData_UserActivityID1",
                table: "PictureData",
                column: "UserActivityID1");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse_ClassID",
                table: "ClassCourse",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCourse_CourseID",
                table: "ClassCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_ActivityID",
                table: "UserActivity",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_UserActivity_UserID",
                table: "UserActivity",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_ClassID",
                table: "UserClass",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_UserClass_UserID",
                table: "UserClass",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_UserActivity_UserActivityID1",
                table: "PictureData");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureData_User_UserID",
                table: "PictureData");

            migrationBuilder.DropTable(
                name: "ClassCourse");

            migrationBuilder.DropTable(
                name: "UserActivity");

            migrationBuilder.DropTable(
                name: "UserClass");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_PictureData_UserActivityID1",
                table: "PictureData");

            migrationBuilder.DropColumn(
                name: "UserActivityID",
                table: "PictureData");

            migrationBuilder.DropColumn(
                name: "UserActivityID1",
                table: "PictureData");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "User",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "PictureData",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "PictureDataID",
                table: "PictureData",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_PictureData_UserID",
                table: "PictureData",
                newName: "IX_PictureData_UserId");

            migrationBuilder.RenameColumn(
                name: "ClassID",
                table: "Classes",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "PictureData",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "FeedbackQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Userpresence",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Course = table.Column<string>(maxLength: 50, nullable: false),
                    CourseActivity = table.Column<string>(maxLength: 50, nullable: false),
                    Datetime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Week = table.Column<int>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userpresence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Userpresence_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbackanswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FeedbackQuestionId = table.Column<int>(nullable: false),
                    Note = table.Column<string>(maxLength: 50, nullable: false),
                    Stars = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbackanswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbackanswers_FeedbackQuestions_FeedbackQuestionId",
                        column: x => x.FeedbackQuestionId,
                        principalTable: "FeedbackQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbackanswers_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_ClassId",
                table: "User",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbackanswers_FeedbackQuestionId",
                table: "Feedbackanswers",
                column: "FeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbackanswers_UserId",
                table: "Feedbackanswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Userpresence_UserId",
                table: "Userpresence",
                column: "UserId");

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
        }
    }
}
