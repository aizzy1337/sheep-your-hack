using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demodata5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 16, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(468), 1 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 15, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(533), 1 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 4, 4, 18, 29, 571, DateTimeKind.Local).AddTicks(539), 1 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 16, 1, 36, 57, 150, DateTimeKind.Local).AddTicks(5168), 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 15, 1, 36, 57, 150, DateTimeKind.Local).AddTicks(5216), 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Type" },
                values: new object[] { new DateTime(2023, 12, 4, 1, 36, 57, 150, DateTimeKind.Local).AddTicks(5224), 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2023, 11, 25, 1, 36, 57, 150, DateTimeKind.Local).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 1, 36, 57, 150, DateTimeKind.Local).AddTicks(5229));
        }
    }
}
