using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreakyFashion.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUrlSlugToCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "795c1f99-eb36-47b8-b64b-2d150ee92f75");

            migrationBuilder.AddColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45b96a51-5baf-42c5-9256-39cb09284f95", null, "Admin", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45b96a51-5baf-42c5-9256-39cb09284f95");

            migrationBuilder.DropColumn(
                name: "UrlSlug",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "795c1f99-eb36-47b8-b64b-2d150ee92f75", null, "Admin", null });
        }
    }
}
