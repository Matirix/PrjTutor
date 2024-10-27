using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43ae8775-92b4-4fc5-b56d-fa28f5819c1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8e2ea80-0070-4f4a-bffb-5fe3d3aa24fa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7758b6ca-13e3-4a3b-9a06-980032d26435", null, "tutor", null },
                    { "afb9a9f5-2db3-4cc2-ba6f-b1215c38b878", null, "admin", "tutor" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7758b6ca-13e3-4a3b-9a06-980032d26435");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afb9a9f5-2db3-4cc2-ba6f-b1215c38b878");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43ae8775-92b4-4fc5-b56d-fa28f5819c1d", null, "tutor", null },
                    { "c8e2ea80-0070-4f4a-bffb-5fe3d3aa24fa", null, "admin", "tutor" }
                });
        }
    }
}
