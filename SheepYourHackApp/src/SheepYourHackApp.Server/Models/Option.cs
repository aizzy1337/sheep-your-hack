using System.Collections;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models
{
    public class Option
    {
        public int Id { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }

        public List<UserOption> UserOptions { get; } = new();
    }
}
