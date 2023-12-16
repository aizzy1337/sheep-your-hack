using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Organizator", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3310), "ShootYourSelf", new DateTime(2023, 12, 16, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3319), new DateTime(2023, 12, 16, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3325), new DateTime(2023, 12, 16, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 1, 8, 207, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "What for lunch?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Organizator", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2590), "Google", new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2596), new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2601), new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "What for lunch");
        }
    }
}
