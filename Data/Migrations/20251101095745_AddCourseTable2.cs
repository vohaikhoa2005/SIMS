using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIMS.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_LecturerId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Subject_SubjectId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameColumn(
                name: "LecturerId",
                table: "Courses",
                newName: "LectureId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_LecturerId",
                table: "Courses",
                newName: "IX_Courses_LectureId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_LectureId",
                table: "Courses",
                column: "LectureId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_AspNetUsers_LectureId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Subjects_SubjectId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "LectureId",
                table: "Courses",
                newName: "LecturerId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_LectureId",
                table: "Courses",
                newName: "IX_Courses_LecturerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_AspNetUsers_LecturerId",
                table: "Courses",
                column: "LecturerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Subject_SubjectId",
                table: "Courses",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
