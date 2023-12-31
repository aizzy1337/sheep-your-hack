﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using SheepYourHackApp.Server.Models;
using System;
using System.Reflection.Metadata;

namespace SheepYourHackApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feed>()
                .HasOne(e => e.Poll)
                .WithOne(e => e.Feed)
                .HasForeignKey<Poll>(e => e.FeedId)
                .IsRequired(false);

            modelBuilder.Entity<Feed>()
                .HasOne(e => e.Event)
                .WithOne(e => e.Feed)
                .HasForeignKey<Event>(e => e.FeedId)
            .IsRequired(false);

            var demoGroupA = new Group { Id = 1, Name = "Grupa A", Role = GroupRole.Leader};

            modelBuilder.Entity<Group>().HasData(demoGroupA);

            var demoUser1 = new User { Id = 1, FirstName = "John", LastName = "Smith", Nickname = "JSmith1", GroupId = demoGroupA.Id };

            modelBuilder.Entity<User>().HasData(demoUser1);

            var demoFeed1 = new Feed { Id = 1, CreationDate = DateTime.Now, Message = "Przygotowanie zdrowego lunchu w pracy w krótkim czasie wymaga planowania i wykorzystania prostych przepisów. Pamiętaj, że kluczem do szybkiego lunchu jest wcześniejsze przygotowanie składników w domu lub korzystanie z gotowych, zdrowych produktów.", Type = FeedType.Plain, UserId = demoUser1.Id };
            var demoFeed2 = new Feed { Id = 2, CreationDate = DateTime.Now.AddDays(-1), Message = "Organizacja ogniska ze współpracownikami to doskonały sposób na zbudowanie atmosfery wspólnoty, zacieśnienie relacji i umożliwienie pracownikom spędzenia czasu poza środowiskiem biurowym.", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed3 = new Feed { Id = 3, CreationDate = DateTime.Now.AddDays(-12), Message = "Medytacja w pracy to praktyka, która staje się coraz bardziej popularna w środowisku korporacyjnym, pomagając pracownikom zredukować stres, poprawić koncentrację i zwiększyć ogólne samopoczucie. Podczas tych krótkich przerw w ciągu dnia nasi pracownicy mają szansę na zresetowanie umysłu i redukcję napięcia.", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed4 = new Feed { Id = 4, CreationDate = DateTime.Now.AddDays(-21), Message = "Bieganie nie tylko zdrowa forma aktywności, ale również doskonały sposób na wspólne spędzanie czasu. W trakcie biegu wymieniamy się pomysłami, planami na przyszłość oraz wspieramy się nawzajem w dążeniu do zdrowszego trybu życia. Bez względu na poziom zaawansowania, wszyscy są mile widziani, a atmosfera jest zawsze pełna pozytywnej energii.", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed5 = new Feed { Id = 5, CreationDate = DateTime.Now.AddDays(-3), Message = "Warto dbać nie tylko o ciało, ale również o umysł. Rozwijajmy się razem! Każdy miesiąc możemy wyznaczyć na naukę nowego hobby. Proponujemy podzielenie się zeszytami pomysłów i doświadczeń. Kto wie, może odkryjemy nową pasję?", Type = FeedType.Plain, UserId = demoUser1.Id };
            var demoFeed6 = new Feed { Id = 6, CreationDate = DateTime.Now.AddDays(-3), Message = "Czy macie ochotę gdzieś się przejść zamówić coś razem? Jakieś giereczki po obiadku?", Type = FeedType.Plain, UserId = demoUser1.Id };

            modelBuilder.Entity<Feed>().HasData(demoFeed1, demoFeed2, demoFeed3, demoFeed4, demoFeed5, demoFeed6);

            var demoFeedGroup1 = new FeedGroup { Id = 1,  FeedId = demoFeed1.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup4 = new FeedGroup { Id = 2, FeedId = demoFeed2.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup2 = new FeedGroup { Id = 4, FeedId = demoFeed3.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup5 = new FeedGroup { Id = 5, FeedId = demoFeed4.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup6 = new FeedGroup { Id = 6, FeedId = demoFeed5.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup7 = new FeedGroup { Id = 7, FeedId = demoFeed6.Id, GroupId = demoGroupA.Id };

            modelBuilder.Entity<FeedGroup>().HasData(demoFeedGroup1, demoFeedGroup2, demoFeedGroup4, demoFeedGroup5, demoFeedGroup6, demoFeedGroup7);

            var demoEvent1 = new Event { Id = 1, Name = "Paintball po pracy wieczorem", Organizator="ShootYourSelf", Type = EventType.AfterWork, EndDate = DateTime.Now.AddDays(3), FeedId = demoFeed1.Id, StartDate = DateTime.Now }; 
            var demoEvent2 = new Event { Id = 2, Name = "Jak zrobić pyszny obiad w 15 min, smaczniejszy niż od Gesslerowej", Organizator = "Jummi mniam mniam", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(2), FeedId = demoFeed2.Id, StartDate = DateTime.Now };
            var demoEvent3 = new Event { Id = 3, Name = "Jak zmarnować 5 min swojego życia, czyli oglądanie 5mincraft", Organizator = "5minCraft", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(4), FeedId = demoFeed3.Id, StartDate = DateTime.Now };

            modelBuilder.Entity<Event>().HasData(demoEvent1, demoEvent2, demoEvent3);

            var demoPoll1 = new Poll { Id = 1, FeedId = demoFeed4.Id, Name="Co na obiad?"};

            modelBuilder.Entity<Poll>().HasData(demoPoll1);

            var demoOption1 = new Option { Id = 1, Name = "Pizza", PollId = demoPoll1.Id};
            var demoOption2 = new Option { Id = 2, Name = "Makaron", PollId = demoPoll1.Id };
            var demoOption3 = new Option { Id = 3, Name = "Sushi", PollId = demoPoll1.Id };

            modelBuilder.Entity<Option>().HasData(demoOption1, demoOption2, demoOption3);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<Feed> Feeds { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Option> Options { get; set; }
        DbSet<Poll> Polls { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<User> Users { get; set; }
    }
}
