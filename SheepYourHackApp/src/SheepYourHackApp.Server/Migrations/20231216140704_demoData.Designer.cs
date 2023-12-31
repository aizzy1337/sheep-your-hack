﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SheepYourHackApp.Server.Data;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231216140704_demoData")]
    partial class demoData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FeedId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Organizator")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FeedId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2023, 12, 19, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1869),
                            FeedId = 1,
                            Name = "Paintball po pracy wieczorem",
                            Organizator = "ShootYourSelf",
                            StartDate = new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1873),
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2023, 12, 18, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1875),
                            FeedId = 2,
                            Name = "Jak zrobić pyszny obiad w 15 min, smaczniejszy niż od Gesslerowej",
                            Organizator = "Jummi mniam mniam",
                            StartDate = new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1877),
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2023, 12, 20, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1879),
                            FeedId = 3,
                            Name = "Jak zmarnować 5 min swojego życia, czyli oglądanie 5mincraft",
                            Organizator = "5minCraft",
                            StartDate = new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1881),
                            Type = 0
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Feed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Feeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2023, 12, 16, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1766),
                            Message = "Zachęcamy do aktywności fizycznej po pracy! Wspólna aktywność może pomóc w zwiększeniu energii i poprawie nastroju. Proponujemy wspólne spacery w okolicy biura albo udział w zajęciach fitness online. Zaczynamy już jutro!",
                            Type = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2023, 12, 15, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1814),
                            Message = "Zapraszamy do praktyki medytacji jako narzędzia relaksacyjnego. Wspólnie możemy znaleźć chwilę w ciągu dnia na kilka głębokich oddechów i chwilę spokoju. Wskazówki dotyczące medytacji znajdziesz w materiałach, które udostępniamy online",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2023, 12, 4, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1818),
                            Message = "Świadome jedzenie to klucz do zdrowego stylu życia. Raz w tygodniu proponujemy organizację wspólnego lunchu, gdzie każdy przynosi jedno danie. To doskonała okazja do dzielenia się przepisami i zdrowymi posiłkami!",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2023, 11, 25, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1821),
                            Message = "Wspieramy was w podejmowaniu aktywności fizycznej! Zaczynamy klub biegowy dla chętnych. Raz w tygodniu po pracy spotykamy się, aby wspólnie przebiec trasę w okolicy. Nie musisz być biegaczem - wszyscy są mile widziani",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1823),
                            Message = "Warto dbać nie tylko o ciało, ale również o umysł. Rozwijajmy się razem! Każdy miesiąc możemy wyznaczyć na naukę nowego hobby. Proponujemy podzielenie się zeszytami pomysłów i doświadczeń. Kto wie, może odkryjemy nową pasję?",
                            Type = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2023, 12, 13, 15, 7, 4, 238, DateTimeKind.Local).AddTicks(1825),
                            Message = "Czy macie ochotę gdzieś się przejść zamówić coś razem? Jakieś giereczki po obiadku?",
                            Type = 0,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.FeedGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("FeedId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FeedId");

                    b.HasIndex("GroupId");

                    b.ToTable("FeedGroup");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FeedId = 1,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 4,
                            FeedId = 3,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 2,
                            FeedId = 2,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 5,
                            FeedId = 4,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 6,
                            FeedId = 5,
                            GroupId = 1
                        },
                        new
                        {
                            Id = 7,
                            FeedId = 6,
                            GroupId = 1
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FeedId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FeedId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Grupa A",
                            Role = 1
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PollId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pizza",
                            PollId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Makaron",
                            PollId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sushi",
                            PollId = 1
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FeedId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FeedId")
                        .IsUnique();

                    b.ToTable("Polls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FeedId = 4,
                            Name = "Co na obiad?"
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            GroupId = 1,
                            LastName = "Smith",
                            Nickname = "JSmith1"
                        });
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Event", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Feed", "Feed")
                        .WithOne("Event")
                        .HasForeignKey("SheepYourHackApp.Server.Models.Event", "FeedId");

                    b.HasOne("SheepYourHackApp.Server.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId");

                    b.Navigation("Feed");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Feed", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.User", "User")
                        .WithMany("Feeds")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.FeedGroup", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Feed", "Feed")
                        .WithMany("FeedGroups")
                        .HasForeignKey("FeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SheepYourHackApp.Server.Models.Group", "Group")
                        .WithMany("FeedGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feed");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Group", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Feed", null)
                        .WithMany("Groups")
                        .HasForeignKey("FeedId");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Option", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Poll", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Feed", "Feed")
                        .WithOne("Poll")
                        .HasForeignKey("SheepYourHackApp.Server.Models.Poll", "FeedId");

                    b.Navigation("Feed");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.User", b =>
                {
                    b.HasOne("SheepYourHackApp.Server.Models.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Feed", b =>
                {
                    b.Navigation("Event");

                    b.Navigation("FeedGroups");

                    b.Navigation("Groups");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Group", b =>
                {
                    b.Navigation("FeedGroups");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.Poll", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("SheepYourHackApp.Server.Models.User", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Feeds");
                });
#pragma warning restore 612, 618
        }
    }
}
