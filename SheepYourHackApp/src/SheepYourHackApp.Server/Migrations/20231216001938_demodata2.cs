using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName", "Nickname" },
                values: new object[] { 1, "John", 1, "Smith", "JSmith" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
