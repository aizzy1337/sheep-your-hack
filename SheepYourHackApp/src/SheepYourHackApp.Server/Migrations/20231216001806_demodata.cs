using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Grupa A" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
