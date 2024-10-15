using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class DescriptionEValuationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Evaluation",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Evaluation");
        }
    }
}
