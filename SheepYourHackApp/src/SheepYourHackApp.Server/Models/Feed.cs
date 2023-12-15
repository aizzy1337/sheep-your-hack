using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Feed
    {
        public int Id { get; set; }
        public string Message { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public DateTime CreationDate { get; set; }
        public FeedType Type { get; set; }

        public Poll? Poll { get; set; }
        public Event? Event { get; set; }

        public List<FeedGroup> FeedGroups { get; set; }
    }
}
