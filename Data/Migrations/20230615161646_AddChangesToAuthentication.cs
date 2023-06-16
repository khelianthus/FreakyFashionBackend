using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakyFashion.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddChangesToAuthentication : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b96a51-5baf-42c5-9256-39cb09284f95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58cff5bb-9fd2-4d1b-a6be-d0c3acdf9aa5", null, "Admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58cff5bb-9fd2-4d1b-a6be-d0c3acdf9aa5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45b96a51-5baf-42c5-9256-39cb09284f95", null, "Admin", null });
        }
    }
}
