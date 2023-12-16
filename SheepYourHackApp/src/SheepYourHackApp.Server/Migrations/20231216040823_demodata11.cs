using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Options",
                type: "TEXT",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Options");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4514), new DateTime(2023, 12, 16, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4522), new DateTime(2023, 12, 16, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4528), new DateTime(2023, 12, 16, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4451));
        }
    }
}
