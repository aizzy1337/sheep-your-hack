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

            var demoGroupA = new Group { Id = 1, Name = "Grupa A", Role = GroupRole.Leader};

            modelBuilder.Entity<Group>().HasData(demoGroupA);

            var demoUser1 = new User { Id = 1, FirstName = "John", LastName = "Smith", Nickname = "JSmith1", GroupId = demoGroupA.Id };

            modelBuilder.Entity<User>().HasData(demoUser1);

            var demoFeed1 = new Feed { Id = 1, CreationDate = DateTime.Now, Message = "Free webinar about something good for you", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed2 = new Feed { Id = 2, CreationDate = DateTime.Now.AddDays(-1), Message = "Free webinar about something", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed3 = new Feed { Id = 3, CreationDate = DateTime.Now.AddDays(-12), Message = "Free webinar about something", Type = FeedType.Event, UserId = demoUser1.Id };
            var demoFeed4 = new Feed { Id = 4, CreationDate = DateTime.Now.AddDays(-21), Message = "Free webinar about something", Type = FeedType.Poll, UserId = demoUser1.Id };
            var demoFeed5 = new Feed { Id = 5, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Poll, UserId = demoUser1.Id };
            var demoFeed6 = new Feed { Id = 6, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Plain, UserId = demoUser1.Id };
            var demoFeed7 = new Feed { Id = 7, CreationDate = DateTime.Now.AddDays(-3), Message = "Free webinar about something", Type = FeedType.Plain, UserId = demoUser1.Id };


            modelBuilder.Entity<Feed>().HasData(demoFeed1, demoFeed2, demoFeed3, demoFeed4, demoFeed5, demoFeed6, demoFeed7);

            var demoFeedGroup1 = new FeedGroup { Id = 1,  FeedId = demoFeed1.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup4 = new FeedGroup { Id = 2, FeedId = demoFeed2.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup2 = new FeedGroup { Id = 4, FeedId = demoFeed3.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup5 = new FeedGroup { Id = 5, FeedId = demoFeed4.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup6 = new FeedGroup { Id = 6, FeedId = demoFeed5.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup7 = new FeedGroup { Id = 7, FeedId = demoFeed6.Id, GroupId = demoGroupA.Id };
            var demoFeedGroup8 = new FeedGroup { Id = 8, FeedId = demoFeed7.Id, GroupId = demoGroupA.Id };

            modelBuilder.Entity<FeedGroup>().HasData(demoFeedGroup1, demoFeedGroup2, demoFeedGroup4, demoFeedGroup5, demoFeedGroup6, demoFeedGroup7, demoFeedGroup8);

            var demoEvent1 = new Event { Id = 1, Name = "Paintball after work", Organizator="ShootYourSelf", Type = EventType.AfterWork, EndDate = DateTime.Now.AddDays(3), FeedId = demoFeed1.Id, StartDate = DateTime.Now }; 
            var demoEvent2 = new Event { Id = 2, Name = "How to make lanch in 15 min.", Organizator = "Jummi mniam mniam", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(2), FeedId = demoFeed2.Id, StartDate = DateTime.Now };
            var demoEvent3 = new Event { Id = 3, Name = "Best way to make life easier", Organizator = "5minCraft", Type = EventType.InWork, EndDate = DateTime.Now.AddDays(4), FeedId = demoFeed3.Id, StartDate = DateTime.Now };

            modelBuilder.Entity<Event>().HasData(demoEvent1, demoEvent2, demoEvent3);

            var demoPoll1 = new Poll { Id = 1, FeedId = demoFeed4.Id, Name="What for lunch?"};

            modelBuilder.Entity<Poll>().HasData(demoPoll1);

            var demoOption1 = new Option { Id = 1, Name = "Pizza", PollId = demoPoll1.Id};
            var demoOption2 = new Option { Id = 2, Name = "Pasta", PollId = demoPoll1.Id };

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
