using Newtonsoft.Json;
using SheepYourHackApp.Server.Models.DTO;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http;
using System;
using System.Threading.Tasks;
namespace SheepYourHackApp.Server.Extensions;
public static class TeamsWebhook
{
    public async static Task SendTeamsNotification(FeedDto feedDto)
    {
        var message = feedDto.Message.Length > 250 ? feedDto.Message.Substring(0, 100) + "...." : feedDto.Message;

        List<string> emotki = new List<string> { "😊", "💕", "✌", "🎉", "🐱‍🏍" };

        Random random = new Random();

        int rand = random.Next(0, emotki.Count);

        dynamic jsonObject = new
        {
            type = "message",
            attachments = new[]
            {
                new
                {
                    contentType = "application/vnd.microsoft.card.adaptive",
                    content = new
                    {
                        type = "AdaptiveCard",
                        body = new[]
                        {
                            new
                            {
                                type = "TextBlock",
                                text = $"New feed from user **{ feedDto.UserNickName }** {emotki[rand]}"
                            },
                            new
                            {
                                type = "TextBlock",
                                text = $"{message}"
                            },
                            new
                            {
                                type = "TextBlock",
                                text = "See more at [Easy Balance](http://localhost:5002)"
                            }
                        },
                        schema = "http://adaptivecards.io/schemas/adaptive-card.json",
                        version = "1.0"
                    }
                }
            }
        };

        // Serializujemy obiekt dynamiczny do formatu JSON
        string json = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);

        var webhookUrl = "https://aghedupl.webhook.office.com/webhookb2/d7d4cb93-0511-48ba-9efb-67885ad0ba96@80b1033f-21e0-4a82-bbc0-f05fdccd3bc8/IncomingWebhook/4344892ab2e44342a55106b48dcd4784/a1812d4c-e3b4-456d-9dd5-5fab28e9b232";

        var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        var response = await client.PostAsync(webhookUrl, content);
    }
}
