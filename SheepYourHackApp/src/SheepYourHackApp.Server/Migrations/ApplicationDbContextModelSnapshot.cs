﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SheepYourHackApp.Server.Data;

#nullable disable

namespace SheepYourHackApp.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            EndDate = new DateTime(2023, 12, 19, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9507),
                            FeedId = 1,
                            Name = "Paintball po pracy wieczorem",
                            Organizator = "ShootYourSelf",
                            StartDate = new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9510),
                            Type = 1
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2023, 12, 18, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9513),
                            FeedId = 2,
                            Name = "Jak zrobić pyszny obiad w 15 min, smaczniejszy niż od Gesslerowej",
                            Organizator = "Jummi mniam mniam",
                            StartDate = new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9515),
                            Type = 0
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2023, 12, 20, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9517),
                            FeedId = 3,
                            Name = "Jak zmarnować 5 min swojego życia, czyli oglądanie 5mincraft",
                            Organizator = "5minCraft",
                            StartDate = new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9519),
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
                            CreationDate = new DateTime(2023, 12, 16, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9394),
                            Message = "Przygotowanie zdrowego lunchu w pracy w krótkim czasie wymaga planowania i wykorzystania prostych przepisów. Pamiętaj, że kluczem do szybkiego lunchu jest wcześniejsze przygotowanie składników w domu lub korzystanie z gotowych, zdrowych produktów.",
                            Type = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2023, 12, 15, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9446),
                            Message = "Organizacja ogniska ze współpracownikami to doskonały sposób na zbudowanie atmosfery wspólnoty, zacieśnienie relacji i umożliwienie pracownikom spędzenia czasu poza środowiskiem biurowym.",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2023, 12, 4, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9451),
                            Message = "Medytacja w pracy to praktyka, która staje się coraz bardziej popularna w środowisku korporacyjnym, pomagając pracownikom zredukować stres, poprawić koncentrację i zwiększyć ogólne samopoczucie. Podczas tych krótkich przerw w ciągu dnia nasi pracownicy mają szansę na zresetowanie umysłu i redukcję napięcia.",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2023, 11, 25, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9454),
                            Message = "Bieganie nie tylko zdrowa forma aktywności, ale również doskonały sposób na wspólne spędzanie czasu. W trakcie biegu wymieniamy się pomysłami, planami na przyszłość oraz wspieramy się nawzajem w dążeniu do zdrowszego trybu życia. Bez względu na poziom zaawansowania, wszyscy są mile widziani, a atmosfera jest zawsze pełna pozytywnej energii.",
                            Type = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2023, 12, 13, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9456),
                            Message = "Warto dbać nie tylko o ciało, ale również o umysł. Rozwijajmy się razem! Każdy miesiąc możemy wyznaczyć na naukę nowego hobby. Proponujemy podzielenie się zeszytami pomysłów i doświadczeń. Kto wie, może odkryjemy nową pasję?",
                            Type = 0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2023, 12, 13, 16, 44, 46, 283, DateTimeKind.Local).AddTicks(9459),
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
