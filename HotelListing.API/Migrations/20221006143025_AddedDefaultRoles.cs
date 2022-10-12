using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cb3ef4ce-4d83-428a-8a96-30d31ac2231c", "2e167fe6-4ef0-4d8f-8fed-9bf261b3dea5", "User", "USER" },
                    { "ffd7fa54-80ef-4584-b32c-dbd5ecbb6a37", "b9e1a500-accd-46b4-8c61-b517a353a999", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb3ef4ce-4d83-428a-8a96-30d31ac2231c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ffd7fa54-80ef-4584-b32c-dbd5ecbb6a37");
        }
    }
}
