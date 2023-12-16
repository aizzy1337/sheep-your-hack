using SheepYourHackApp.Server.Models.DTO;
using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Extensions;

public static class SlackNotification
{
    public static void SendSlackNotification(FeedDto feedDto)
    {
        var slackClient = new SlackClient("https://hooks.slack.com/services/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");

        var feed = new { UserNickName = feedDto.UserNickName };
        var message = feedDto.Message.Length > 100 ? feedDto.Message.Substring(0, 100) + "...." : feedDto.Message;
        var emotki = new[] { ":smile:", ":heart:", ":thumbsup:", ":+1:", ":rocket:" };
        Random random = new Random();

        int rand = random.Next(0, 5);

        // Tworzenie wiadomości w formacie Slack
        var slackMessage = new SlackMessage
        {
            Channel = "#notification",
            IconEmoji = Emoji.Boom,
            Username = "EasyBalance"
        };

        var slackAttachment = new SlackAttachment
        {
            Text = $"New feed from user *{feed.UserNickName }* {emotki[rand]}",
            Color = "#D00000",
            Fields = new List<SlackField>
            {
                new SlackField
                {
                    Title = message,
                    Value = $"See more at <http://localhost:5002|Easy Balance>"
                }
            }
        };
        slackMessage.Attachments = new List<SlackAttachment> { slackAttachment };

        slackClient.Post(slackMessage);
    }
}
