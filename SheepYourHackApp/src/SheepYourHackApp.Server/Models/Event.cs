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
        public List<Tag> Tags { get; set; }

        public int? FeedId { get; set; }
        public Feed? Feed { get; set; }

        public List<TagEvent> TagEvents { get; } = new();
        public List<UserEvent> UserEvents { get; } = new();
    }
}
