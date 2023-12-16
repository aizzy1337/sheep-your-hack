using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9914), new DateTime(2023, 12, 16, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9932), new DateTime(2023, 12, 16, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9938) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9946), new DateTime(2023, 12, 16, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 17, 33, 586, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "PollId" },
                values: new object[,]
                {
                    { 1, "Bardzo kocham boga", 1 },
                    { 2, "Bardzo nienawidzę boga", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1608), new DateTime(2023, 12, 16, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1614), new DateTime(2023, 12, 16, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1619), new DateTime(2023, 12, 16, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 8, 23, 496, DateTimeKind.Local).AddTicks(1548));
        }
    }
}
