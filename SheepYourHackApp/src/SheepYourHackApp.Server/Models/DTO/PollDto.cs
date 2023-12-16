using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models.DTO
{
    public class PollDto
    {
        public int Id { get; set; }
        public List<OptionDto> Options { get; set;}
    }
}
