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
                            EndDate = new DateTime(2023, 12, 19, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4893),
                            FeedId = 1,
                            Name = "EventA",
                            Organizator = "Google",
                            StartDate = new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4895),
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2023, 12, 18, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4897),
                            FeedId = 2,
                            Name = "EventB",
                            Organizator = "Google",
                            StartDate = new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4898),
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2023, 12, 20, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4900),
                            FeedId = 3,
                            Name = "EventC",
                            Organizator = "Google",
                            StartDate = new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4901),
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
                            CreationDate = new DateTime(2023, 12, 16, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4813),
                            Message = "Free webinar about something",
                            Type = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2023, 12, 15, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4853),
                            Message = "Free webinar about something",
                            Type = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2023, 12, 4, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4858),
                            Message = "Free webinar about something",
                            Type = 1,
                            UserId = 5
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2023, 11, 25, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4859),
                            Message = "Free webinar about something",
                            Type = 2,
                            UserId = 5
                        },
                        new
                        {
                            Id = 5,
                            CreationDate = new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4861),
                            Message = "Free webinar about something",
                            Type = 2,
                            UserId = 5
                        },
                        new
                        {
                            Id = 6,
                            CreationDate = new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4863),
                            Message = "Free webinar about something",
                            Type = 0,
                            UserId = 5
                        },
                        new
                        {
                            Id = 7,
                            CreationDate = new DateTime(2023, 12, 13, 9, 19, 21, 951, DateTimeKind.Local).AddTicks(4865),
                            Message = "Free webinar about something",
                            Type = 0,
                            UserId = 5
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
                            Id = 2,
                            FeedId = 1,
                            GroupId = 2
                        },
                        new
                        {
                            Id = 3,
                            FeedId = 1,
                            GroupId = 3
                        },
                        new
                        {
                            Id = 4,
                            FeedId = 2,
                            GroupId = 2
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
                            Role = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Grupa B",
                            Role = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Grupa C",
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
                            Name = "Bardzo kocham boga",
                            PollId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bardzo nienawidzę boga",
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

                    b.HasKey("Id");

                    b.HasIndex("FeedId")
                        .IsUnique();

                    b.ToTable("Polls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FeedId = 4
                        },
                        new
                        {
                            Id = 2,
                            FeedId = 5
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
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Paul",
                            GroupId = 1,
                            LastName = "Smith",
                            Nickname = "JSmith2"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Mark",
                            GroupId = 2,
                            LastName = "Smith",
                            Nickname = "JSmith3"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Oink",
                            GroupId = 2,
                            LastName = "Smith",
                            Nickname = "JSmith4"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "Ihuano",
                            GroupId = 3,
                            LastName = "Smith",
                            Nickname = "JSmith5"
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
