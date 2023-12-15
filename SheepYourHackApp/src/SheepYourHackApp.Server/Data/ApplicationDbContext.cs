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
        }

        DbSet<Feed> Feeds { get; set; }
        DbSet<Group> Groups { get; set; }
        DbSet<Option> Options { get; set; }
        DbSet<Poll> Polls { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<User> Users { get; set; }
    }
}
