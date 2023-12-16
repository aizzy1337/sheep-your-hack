using System.Collections;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GroupRole Role { get; set; }

        public List<FeedGroup> FeedGroups { get; } = new();
        public ICollection<User> Users { get; } = new List<User>();
    }

    public class FeedGroup
    {
        public int Id { get; set; }
        public int FeedId { get; set; }
        public int GroupId { get; set; }
        public Feed Feed { get; set; } = null!;
        public Group Group { get; set; } = null!;
    }
}
