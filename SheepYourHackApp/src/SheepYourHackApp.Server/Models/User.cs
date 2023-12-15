using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public List<UserOption> UserOptions { get; } = new();
        public List<UserEvent> UserEvents { get; } = new();

        public ICollection<Feed> Feeds { get; } = new List<Feed>();

    }

    public class UserOption
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OptionId { get; set; }
        public User User { get; set; } = null!;
        public Option Option { get; set; } = null!;
    }

    public class UserEvent
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int EventId { get; set; }
        public User User { get; set; } = null!;
        public Event Event { get; set; } = null!;
    }
}
