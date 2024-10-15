using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAssignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignment_Student_StudentId",
                table: "Assignment");

            migrationBuilder.DropIndex(
                name: "IX_Assignment_StudentId",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Assignment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Assignment",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_StudentId",
                table: "Assignment",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignment_Student_StudentId",
                table: "Assignment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
