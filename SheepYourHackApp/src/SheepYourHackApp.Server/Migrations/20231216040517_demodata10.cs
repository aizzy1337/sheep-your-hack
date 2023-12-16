using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4445), 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 5, 5, 17, 544, DateTimeKind.Local).AddTicks(4451));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(649), 2 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 53, 16, 713, DateTimeKind.Local).AddTicks(655));
        }
    }
}
