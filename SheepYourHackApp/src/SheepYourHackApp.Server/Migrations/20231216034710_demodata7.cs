using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 4, 47, 10, 5, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.InsertData(
                table: "Polls",
                columns: new[] { "Id", "FeedId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3811), new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3821), new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3833), new DateTime(2023, 12, 16, 4, 27, 11, 846, DateTimeKind.Local).AddTicks(3836) });

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
    }
}
