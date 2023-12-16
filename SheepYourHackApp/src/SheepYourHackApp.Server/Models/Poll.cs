using System.Collections;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Option> Options { get; } = new List<Option>();

        public int? FeedId { get; set; }
        public Feed? Feed { get; set; }
    }
}
