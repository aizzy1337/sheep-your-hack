using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class newDemoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9507), new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9513), new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9517), new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9394), "Przygotowanie zdrowego lunchu w pracy w krótkim czasie wymaga planowania i wykorzystania prostych przepisów. Pamiętaj, że kluczem do szybkiego lunchu jest wcześniejsze przygotowanie składników w domu lub korzystanie z gotowych, zdrowych produktów." });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 15, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9446), "Organizacja ogniska ze współpracownikami to doskonały sposób na zbudowanie atmosfery wspólnoty, zacieśnienie relacji i umożliwienie pracownikom spędzenia czasu poza środowiskiem biurowym." });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 4, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9451), "Medytacja w pracy to praktyka, która staje się coraz bardziej popularna w środowisku korporacyjnym, pomagając pracownikom zredukować stres, poprawić koncentrację i zwiększyć ogólne samopoczucie. Podczas tych krótkich przerw w ciągu dnia nasi pracownicy mają szansę na zresetowanie umysłu i redukcję napięcia." });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 11, 25, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9454), "Bieganie nie tylko zdrowa forma aktywności, ale również doskonały sposób na wspólne spędzanie czasu. W trakcie biegu wymieniamy się pomysłami, planami na przyszłość oraz wspieramy się nawzajem w dążeniu do zdrowszego trybu życia. Bez względu na poziom zaawansowania, wszyscy są mile widziani, a atmosfera jest zawsze pełna pozytywnej energii." });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9459));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1869), new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1875), new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1879), new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1766), "Zachęcamy do aktywności fizycznej po pracy! Wspólna aktywność może pomóc w zwiększeniu energii i poprawie nastroju. Proponujemy wspólne spacery w okolicy biura albo udział w zajęciach fitness online. Zaczynamy już jutro!" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 15, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1814), "Zapraszamy do praktyki medytacji jako narzędzia relaksacyjnego. Wspólnie możemy znaleźć chwilę w ciągu dnia na kilka głębokich oddechów i chwilę spokoju. Wskazówki dotyczące medytacji znajdziesz w materiałach, które udostępniamy online" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 4, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1818), "Świadome jedzenie to klucz do zdrowego stylu życia. Raz w tygodniu proponujemy organizację wspólnego lunchu, gdzie każdy przynosi jedno danie. To doskonała okazja do dzielenia się przepisami i zdrowymi posiłkami!" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1821), "Wspieramy was w podejmowaniu aktywności fizycznej! Zaczynamy klub biegowy dla chętnych. Raz w tygodniu po pracy spotykamy się, aby wspólnie przebiec trasę w okolicy. Nie musisz być biegaczem - wszyscy są mile widziani" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1825));
        }
    }
}
