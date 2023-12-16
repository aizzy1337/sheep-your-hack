using System;

namespace SheepYourHackApp.Server.Models.DTO
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Organizator { get; set; }
        public EventType Type { get; set; }
    }
}
