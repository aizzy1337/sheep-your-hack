using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "FeedId", "Name", "Organizator", "StartDate", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3811), 1, "EventA", "Google", new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3817), 0 },
                    { 2, new DateTime(2023, 12, 18, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3821), 2, "EventB", "Google", new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3830), 1 },
                    { 3, new DateTime(2023, 12, 20, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3833), 3, "EventC", "Google", new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3836), 0 }
                });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3741));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(559));
        }
    }
}
