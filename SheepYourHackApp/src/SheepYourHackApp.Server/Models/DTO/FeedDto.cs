using System;
using System.Collections.Generic;

namespace SheepYourHackApp.Server.Models.DTO;

public class FeedDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string UserNickName { get; set; }
    public int UserId { get; set; }
    public DateTime CreationDate { get; set; }
    public FeedType Type { get; set; }
    public PollDto? Poll { get; set; }
    public EventDto? Event { get; set; }
    public List<Group> Groups { get; set; }
}
