using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserWipedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aeafa71b-025c-4fc7-8c95-0f7acb536ed1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e108610b-7532-45a7-b7d6-13cfa5e36335");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a74449a-1337-4135-a455-1221e95f1070", null, "tutor", "TUTOR" },
                    { "56ce8b42-f85e-4abc-a288-391e4cc9b30d", null, "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a74449a-1337-4135-a455-1221e95f1070");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56ce8b42-f85e-4abc-a288-391e4cc9b30d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aeafa71b-025c-4fc7-8c95-0f7acb536ed1", null, "tutor", "TUTOR" },
                    { "e108610b-7532-45a7-b7d6-13cfa5e36335", null, "admin", "ADMIN" }
                });
        }
    }
}
