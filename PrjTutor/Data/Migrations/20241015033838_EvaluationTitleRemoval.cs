using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class EvaluationTitleRemoval : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Evaluation");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Evaluation",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
