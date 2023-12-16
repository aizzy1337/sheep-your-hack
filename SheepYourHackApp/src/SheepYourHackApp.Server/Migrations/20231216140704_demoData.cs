using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class demoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FeedGroup",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1869), "Paintball po pracy wieczorem", new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1875), "Jak zrobić pyszny obiad w 15 min, smaczniejszy niż od Gesslerowej", new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1879), "Jak zmarnować 5 min swojego życia, czyli oglądanie 5mincraft", new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1766), "Zachęcamy do aktywności fizycznej po pracy! Wspólna aktywność może pomóc w zwiększeniu energii i poprawie nastroju. Proponujemy wspólne spacery w okolicy biura albo udział w zajęciach fitness online. Zaczynamy już jutro!", 0 });

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
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 11, 25, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1821), "Wspieramy was w podejmowaniu aktywności fizycznej! Zaczynamy klub biegowy dla chętnych. Raz w tygodniu po pracy spotykamy się, aby wspólnie przebiec trasę w okolicy. Nie musisz być biegaczem - wszyscy są mile widziani", 1 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1823), "Warto dbać nie tylko o ciało, ale również o umysł. Rozwijajmy się razem! Każdy miesiąc możemy wyznaczyć na naukę nowego hobby. Proponujemy podzielenie się zeszytami pomysłów i doświadczeń. Kto wie, może odkryjemy nową pasję?", 0 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1825), "Czy macie ochotę gdzieś się przejść zamówić coś razem? Jakieś giereczki po obiadku?" });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Makaron");

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "PollId" },
                values: new object[] { 3, "Sushi", 1 });

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Co na obiad?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 19, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9006), "Paintball after work", new DateTime(2023, 12, 16, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 18, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9013), "How to make lanch in 15 min.", new DateTime(2023, 12, 16, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "Name", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 20, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9017), "Best way to make life easier", new DateTime(2023, 12, 16, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 12, 16, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8891), "Free webinar about something good for you", 1 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 15, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8941), "Free webinar about something" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 4, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8946), "Free webinar about something" });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 11, 25, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8949), "Free webinar about something", 2 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreationDate", "Message", "Type" },
                values: new object[] { new DateTime(2023, 12, 13, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8952), "Free webinar about something", 2 });

            migrationBuilder.UpdateData(
                table: "Feeds",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationDate", "Message" },
                values: new object[] { new DateTime(2023, 12, 13, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8954), "Free webinar about something" });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "CreationDate", "Message", "Type", "UserId" },
                values: new object[] { 7, new DateTime(2023, 12, 13, 9, 54, 45, 171, DateTimeKind.Local).AddTicks(8957), "Free webinar about something", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Pasta");

            migrationBuilder.UpdateData(
                table: "Polls",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "What for lunch?");

            migrationBuilder.InsertData(
                table: "FeedGroup",
                columns: new[] { "Id", "FeedId", "GroupId" },
                values: new object[] { 8, 7, 1 });
        }
    }
}
