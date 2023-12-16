using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(776), new DateTime(2023, 12, 16, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(785), new DateTime(2023, 12, 16, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(791), new DateTime(2023, 12, 16, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "CreationDate", "Message", "Type", "UserId" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 12, 13, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(649), "Free webinar about something", 2, 5 },
                    { 7, new DateTime(2023, 12, 13, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(655), "Free webinar about something", 0, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1355), new DateTime(2023, 12, 16, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 12, 16, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1384), new DateTime(2023, 12, 16, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1200));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1206));
        }
    }
}
