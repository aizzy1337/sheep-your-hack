using System;

namespace SheepYourHackApp.Server.Models.DTO;

public class FeedDto
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string UserNickName { get; set; }
    public DateTime CreationDate { get; set; }
    public FeedType Type { get; set; }
    public Poll? Poll { get; set; }
    public int EventId { get; set; }
}
