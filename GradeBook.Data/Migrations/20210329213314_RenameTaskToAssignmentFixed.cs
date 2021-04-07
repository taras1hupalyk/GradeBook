using Microsoft.EntityFrameworkCore.Migrations;

namespace GradeBook.Data.Migrations
{
    public partial class RenameTaskToAssignmentFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Grades_Id",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Subjects_SubjectId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Assignments");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_SubjectId",
                table: "Assignments",
                newName: "IX_Assignments_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Grades_Id",
                table: "Assignments",
                column: "Id",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Subjects_SubjectId",
                table: "Assignments",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Grades_Id",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Subjects_SubjectId",
                table: "Assignments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assignments",
                table: "Assignments");

            migrationBuilder.RenameTable(
                name: "Assignments",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_Assignments_SubjectId",
                table: "Tasks",
                newName: "IX_Tasks_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Grades_Id",
                table: "Tasks",
                column: "Id",
                principalTable: "Grades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Subjects_SubjectId",
                table: "Tasks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
