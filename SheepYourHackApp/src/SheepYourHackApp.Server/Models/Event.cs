using System;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Organizator { get; set; }
        public EventType Type { get; set; }

        public int? FeedId { get; set; }
        public Feed? Feed { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}
