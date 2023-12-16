using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 25, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1200), 2 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 4, 49, 12, 941, DateTimeKind.Local).AddTicks(1206), 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 12, 16, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5092), new DateTime(2023, 12, 16, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5103), new DateTime(2023, 12, 16, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 11, 25, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5010), 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5014), 0 });
        }
    }
}
