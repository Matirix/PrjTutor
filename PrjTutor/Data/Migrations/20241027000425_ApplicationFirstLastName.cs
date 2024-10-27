using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PrjTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationFirstLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18622be7-ccb2-4d59-b7c7-d6018bf85d78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abf5b5bb-36f7-4204-8266-a70ad4b571b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c5d58dd-0572-49c4-9143-277d7139384d", null, "admin", "tutor" },
                    { "80421b56-da05-43e8-a06a-9a472962b50e", null, "tutor", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "18622be7-ccb2-4d59-b7c7-d6018bf85d78", null, "tutor", null },
                    { "abf5b5bb-36f7-4204-8266-a70ad4b571b5", null, "admin", "tutor" }
                });
        }
    }
}
