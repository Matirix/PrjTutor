using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAssignmentRemoveWeightGrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Assignment");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Assignment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Grade",
                table: "Assignment",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Assignment",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
