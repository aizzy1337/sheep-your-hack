using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4897), new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4865));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2615), new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2619), new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2622), new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2624) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 12, 15, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2023, 12, 4, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2586));
        }
    }
}
