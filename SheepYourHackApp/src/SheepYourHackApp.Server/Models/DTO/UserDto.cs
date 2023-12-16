using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public int GroupRole { get; set; }
    }
}
