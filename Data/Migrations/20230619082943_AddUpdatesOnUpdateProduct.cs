using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakyFashion.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatesOnUpdateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5622705-097d-44c1-8af4-4abdd2a32469");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a25f9cdc-4da2-4d8b-bbac-5a76b5817417", null, "Admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25f9cdc-4da2-4d8b-bbac-5a76b5817417");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c5622705-097d-44c1-8af4-4abdd2a32469", null, "Admin", null });
        }
    }
}
