using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SheepYourHackApp.Server.Migrations
{
    /// <inheritdoc />
<<<<<<<< HEAD:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216080405_initial.cs
    public partial class initial : Migration
========
    public partial class demodata22 : Migration
>>>>>>>> master:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216075929_demodata22.cs
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
<<<<<<<< HEAD:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216080405_initial.cs
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Organizator = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.Id);
                });

========
>>>>>>>> master:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216075929_demodata22.cs
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
<<<<<<<< HEAD:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216080405_initial.cs
                    Role = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: true)
========
                    Role = table.Column<int>(type: "INTEGER", nullable: false)
>>>>>>>> master:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216075929_demodata22.cs
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polls_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Nickname = table.Column<string>(type: "TEXT", nullable: true),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216080405_initial.cs
========
                name: "Feeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feeds_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Organizator = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FeedGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: false),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedGroup_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedGroup_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    FeedId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polls_Feeds_FeedId",
                        column: x => x.FeedId,
                        principalTable: "Feeds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Value = table.Column<string>(type: "TEXT", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tag_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEvent_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvent_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
>>>>>>>> master:SheepYourHackApp/src/SheepYourHackApp.Server/Migrations/20231216075929_demodata22.cs
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PollId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "FeedId", "Name", "Role" },
                values: new object[,]
                {
                    { 1, null, "Grupa A", 0 },
                    { 2, null, "Grupa B", 0 },
                    { 3, null, "Grupa C", 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName", "Nickname" },
                values: new object[,]
                {
                    { 1, "John", 1, "Smith", "JSmith1" },
                    { 2, "Paul", 1, "Smith", "JSmith2" },
                    { 3, "Mark", 2, "Smith", "JSmith3" },
                    { 4, "Oink", 2, "Smith", "JSmith4" },
                    { 5, "Ihuano", 3, "Smith", "JSmith5" }
                });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "CreationDate", "Message", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2532), "Free webinar about something", 1, 5 },
                    { 2, new DateTime(2023, 12, 15, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2574), "Free webinar about something", 1, 5 },
                    { 3, new DateTime(2023, 12, 4, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2578), "Free webinar about something", 1, 5 },
                    { 4, new DateTime(2023, 11, 25, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2580), "Free webinar about something", 2, 5 },
                    { 5, new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2582), "Free webinar about something", 2, 5 },
                    { 6, new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2584), "Free webinar about something", 0, 5 },
                    { 7, new DateTime(2023, 12, 13, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2586), "Free webinar about something", 0, 5 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "FeedId", "Name", "Organizator", "StartDate", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2615), 1, "EventA", "Google", new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2617), 0, null },
                    { 2, new DateTime(2023, 12, 18, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2619), 2, "EventB", "Google", new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2621), 1, null },
                    { 3, new DateTime(2023, 12, 20, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2622), 3, "EventC", "Google", new DateTime(2023, 12, 16, 9, 4, 5, 768, DateTimeKind.Local).AddTicks(2624), 0, null }
                });

            migrationBuilder.InsertData(
                table: "FeedGroup",
                columns: new[] { "Id", "FeedId", "GroupId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 2, 2 },
                    { 5, 4, 1 },
                    { 6, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Polls",
                columns: new[] { "Id", "FeedId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "PollId" },
                values: new object[,]
                {
                    { 1, "Bardzo kocham boga", 1 },
                    { 2, "Bardzo nienawidzę boga", 1 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "Role" },
                values: new object[] { 1, "Grupa A", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName", "Nickname" },
                values: new object[] { 1, "John", 1, "Smith", "JSmith1" });

            migrationBuilder.InsertData(
                table: "Feeds",
                columns: new[] { "Id", "CreationDate", "Message", "Type", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2465), "Free webinar about something good for you", 1, 1 },
                    { 2, new DateTime(2023, 12, 15, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2521), "Free webinar about something", 1, 1 },
                    { 3, new DateTime(2023, 12, 4, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2526), "Free webinar about something", 1, 1 },
                    { 4, new DateTime(2023, 11, 25, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2528), "Free webinar about something", 2, 1 },
                    { 5, new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2530), "Free webinar about something", 2, 1 },
                    { 6, new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2532), "Free webinar about something", 0, 1 },
                    { 7, new DateTime(2023, 12, 13, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2537), "Free webinar about something", 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "EndDate", "FeedId", "Name", "Organizator", "StartDate", "Type" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2590), 1, "Paintball after work", "Google", new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2594), 1 },
                    { 2, new DateTime(2023, 12, 18, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2596), 2, "How to make lanch in 15 min.", "Jummi mniam mniam", new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2598), 0 },
                    { 3, new DateTime(2023, 12, 20, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2601), 3, "Best way to make life easier", "5minCraft", new DateTime(2023, 12, 16, 8, 59, 29, 304, DateTimeKind.Local).AddTicks(2603), 0 }
                });

            migrationBuilder.InsertData(
                table: "FeedGroup",
                columns: new[] { "Id", "FeedId", "GroupId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 4, 3, 1 },
                    { 5, 4, 1 },
                    { 6, 5, 1 },
                    { 7, 6, 1 },
                    { 8, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "Polls",
                columns: new[] { "Id", "FeedId", "Name" },
                values: new object[] { 1, 4, "What for lunch" });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "Name", "PollId" },
                values: new object[,]
                {
                    { 1, "Pizza", 1 },
                    { 2, "Pasta", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_FeedId",
                table: "Events",
                column: "FeedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedGroup_FeedId",
                table: "FeedGroup",
                column: "FeedId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedGroup_GroupId",
                table: "FeedGroup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Feeds_UserId",
                table: "Feeds",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_FeedId",
                table: "Groups",
                column: "FeedId");

            migrationBuilder.CreateIndex(
                name: "IX_Options_PollId",
                table: "Options",
                column: "PollId");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_FeedId",
                table: "Polls",
                column: "FeedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_GroupId",
                table: "Users",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Feeds_FeedId",
                table: "Events",
                column: "FeedId",
                principalTable: "Feeds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_UserId",
                table: "Events",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedGroup_Feeds_FeedId",
                table: "FeedGroup",
                column: "FeedId",
                principalTable: "Feeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedGroup_Groups_GroupId",
                table: "FeedGroup",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feeds_Users_UserId",
                table: "Feeds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Feeds_FeedId",
                table: "Groups");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "FeedGroup");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "Polls");

            migrationBuilder.DropTable(
                name: "Feeds");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
