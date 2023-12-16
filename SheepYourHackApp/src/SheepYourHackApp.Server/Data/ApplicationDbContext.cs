using Microsoft.EntityFrameworkCore;
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

            var demoGroupA = new Group { Id = 1, Name = "Grupa A", Role = GroupRole.Employee};
            var demoGroupB = new Group { Id = 2, Name = "Grupa B", Role = GroupRole.Employee };
            var demoGroupC = new Group { Id = 3, Name = "Grupa C", Role = GroupRole.Leader };

            modelBuilder.Entity<Group>().HasData(demoGroupA, demoGroupB, demoGroupC);

            var demoUser1 = new User { Id = 1, FirstName = "John", LastName = "Smith", Nickname = "JSmith1", GroupId = demoGroupA.Id };
            var demoUser2 = new User { Id = 2, FirstName = "Paul", LastName = "Smith", Nickname = "JSmith2", GroupId = demoGroupA.Id };
            var demoUser3 = new User { Id = 3, FirstName = "Mark", LastName = "Smith", Nickname = "JSmith3", GroupId = demoGroupB.Id };
            var demoUser4 = new User { Id = 4, FirstName = "Oink", LastName = "Smith", Nickname = "JSmith4", GroupId = demoGroupB.Id };
            var demoUser5 = new User { Id = 5, FirstName = "Ihuano", LastName = "Smith", Nickname = "JSmith5", GroupId = demoGroupC.Id };

            modelBuilder.Entity<User>().HasData(demoUser1, demoUser2, demoUser3, demoUser4, demoUser5);

            var demoFeed1 = new Feed { Id = 1, CreationDate = DateTime.Now, Message = "Free webinar about something", Type = FeedType.Event, UserId = demoUser5.Id };
            var demoFeed2 = new Feed { Id = 2, CreationDate = DateTime.Now.AddDays(-1), Message = "Free webinar about something", Type = FeedType.Event, UserId = demoUser5.Id };
            var demoFeed3 = new Feed { Id = 3, CreationDate = DateTime.Now.AddDays(-12), Message = "Free webinar about something", Type = FeedType.Event, UserId = demoUser5.Id };
            var demoFeed4 = new Feed { Id = 4, CreationDate = DateTime.Now.AddDays(-21), Message = "Free webinar about something", Type = FeedType.Poll, UserId = demoUser5.Id };
            var demoFeed5 = new Feed { Id = 5, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Poll, UserId = demoUser5.Id };
            var demoFeed6 = new Feed { Id = 6, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Plain, UserId = demoUser5.Id };
            var demoFeed7 = new Feed { Id = 7, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Plain, UserId = demoUser5.Id };


            modelBuilder.Entity<Feed>().HasData(demoFeed1, demoFeed2, demoFeed3, demoFeed4, demoFeed5, demoFeed6, demoFeed7);

            var demoFeedGroup1 = new FeedGroup { Id = 1,  FeedId = demoFeed1.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup2 = new FeedGroup { Id = 2, FeedId = demoFeed1.Id, GroupId = demoGroupB.Id };
            var demoFeedGroup3 = new FeedGroup { Id = 3, FeedId = demoFeed1.Id, GroupId = demoGroupC.Id };
            var demoFeedGroup4 = new FeedGroup { Id = 4, FeedId = demoFeed2.Id, GroupId = demoGroupB.Id };
            var demoFeedGroup5 = new FeedGroup { Id = 5, FeedId = demoFeed4.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup6 = new FeedGroup { Id = 6, FeedId = demoFeed5.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup7 = new FeedGroup { Id = 7, FeedId = demoFeed6.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup8 = new FeedGroup { Id = 8, FeedId = demoFeed7.Id, GroupId = demoGroupA.Id };

            modelBuilder.Entity<FeedGroup>().HasData(demoFeedGroup1, demoFeedGroup2, demoFeedGroup3, demoFeedGroup4, demoFeedGroup5, demoFeedGroup6, demoFeedGroup7, demoFeedGroup8);


            var demoEvent1 = new Event { Id = 1, Name = "EventA", Organizator="Google", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(3), FeedId = demoFeed1.Id, StartDate = DateTime.Now }; 
            var demoEvent2 = new Event { Id = 2, Name = "EventB", Organizator = "Google", Type = EventType.AfterWork, EndDate = DateTime.Now.AddDays(2), FeedId = demoFeed2.Id, StartDate = DateTime.Now };
            var demoEvent3 = new Event { Id = 3, Name = "EventC", Organizator = "Google", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(4), FeedId = demoFeed3.Id, StartDate = DateTime.Now };

            modelBuilder.Entity<Event>().HasData(demoEvent1, demoEvent2, demoEvent3);

            var demoPoll1 = new Poll { Id = 1, FeedId = demoFeed4.Id};
            var demoPoll2 = new Poll { Id = 2, FeedId = demoFeed5.Id };

            modelBuilder.Entity<Poll>().HasData(demoPoll1, demoPoll2);

            var demoOption1 = new Option { Id = 1, Name = "Bardzo kocham boga", PollId = demoPoll1.Id};
            var demoOption2 = new Option { Id = 2, Name = "Bardzo nienawidzę boga", PollId = demoPoll1.Id };

            modelBuilder.Entity<Option>().HasData(demoOption1, demoOption2);

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
