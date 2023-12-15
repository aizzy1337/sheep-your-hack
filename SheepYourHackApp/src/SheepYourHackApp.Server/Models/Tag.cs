using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public List<TagEvent> TagEvents { get; } = new();
    }

    public class TagEvent
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int EventId { get; set; }
        public Tag Tag { get; set; }
        public Event Event { get; set; }
    }

}
