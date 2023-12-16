using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata3w : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Grupa B" },
                    { 3, "Grupa C" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nickname",
                value: "JSmith1");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 2, "Paul", 1, "Smith", "JSmith2" },
                    { 3, "Mark", 2, "Smith", "JSmith3" },
                    { 4, "Oink", 2, "Smith", "JSmith4" },
                    { 5, "Ihuano", 3, "Smith", "JSmith5" }
                });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "CreationDate", "Message", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 1, 31, 53, 633, DateTimeKind.Local).AddTicks(1445), "Free webinar about something", 0, 5 },
                    { 2, new DateTime(2023, 12, 15, 1, 31, 53, 633, DateTimeKind.Local).AddTicks(1487), "Free webinar about something", 0, 5 },
                    { 3, new DateTime(2023, 12, 4, 1, 31, 53, 633, DateTimeKind.Local).AddTicks(1494), "Free webinar about something", 0, 5 },
                    { 4, new DateTime(2023, 11, 25, 1, 31, 53, 633, DateTimeKind.Local).AddTicks(1496), "Free webinar about something", 0, 5 },
                    { 5, new DateTime(2023, 12, 13, 1, 31, 53, 633, DateTimeKind.Local).AddTicks(1499), "Free webinar about something", 0, 5 }
                });

            migrationBuilder.InsertData(
                table: "FeedGroup",
                columns: new[] { "Id", "FeedId", "GroupId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FeedGroup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedGroup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedGroup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nickname",
                value: "JSmith");
        }
    }
}
