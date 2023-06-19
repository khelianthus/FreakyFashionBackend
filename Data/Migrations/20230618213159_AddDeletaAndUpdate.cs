using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakyFashion.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDeletaAndUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58cff5bb-9fd2-4d1b-a6be-d0c3acdf9aa5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5622705-097d-44c1-8af4-4abdd2a32469", null, "Admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5622705-097d-44c1-8af4-4abdd2a32469");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58cff5bb-9fd2-4d1b-a6be-d0c3acdf9aa5", null, "Admin", null });
        }
    }
}
