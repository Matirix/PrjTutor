using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class EvaluationUserID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17e80b63-ea65-4c69-9252-783c1e69ff1a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b82bef27-c307-4942-9bb5-87068661b636");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Evaluation",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84a87648-ef35-4f3b-89be-83526c0576e5", null, "admin", "ADMIN" },
                    { "f302fcae-8d5e-4872-bf03-e7d9130bc891", null, "tutor", "TUTOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evaluation_UserId",
                table: "Evaluation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluation_AspNetUsers_UserId",
                table: "Evaluation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluation_AspNetUsers_UserId",
                table: "Evaluation");

            migrationBuilder.DropIndex(
                name: "IX_Evaluation_UserId",
                table: "Evaluation");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84a87648-ef35-4f3b-89be-83526c0576e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f302fcae-8d5e-4872-bf03-e7d9130bc891");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Evaluation");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17e80b63-ea65-4c69-9252-783c1e69ff1a", null, "admin", "ADMIN" },
                    { "b82bef27-c307-4942-9bb5-87068661b636", null, "tutor", "TUTOR" }
                });
        }
    }
}
