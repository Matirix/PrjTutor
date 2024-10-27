using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserCs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c5d58dd-0572-49c4-9143-277d7139384d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80421b56-da05-43e8-a06a-9a472962b50e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aeafa71b-025c-4fc7-8c95-0f7acb536ed1", null, "tutor", "TUTOR" },
                    { "e108610b-7532-45a7-b7d6-13cfa5e36335", null, "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "7c5d58dd-0572-49c4-9143-277d7139384d", null, "admin", "tutor" },
                    { "80421b56-da05-43e8-a06a-9a472962b50e", null, "tutor", null }
                });
        }
    }
}
