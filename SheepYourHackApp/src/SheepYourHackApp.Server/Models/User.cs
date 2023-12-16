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

        public ICollection<Feed> Feeds { get; } = new List<Feed>();
        public ICollection<Event> Events { get; } = new List<Event>();
    }

}
