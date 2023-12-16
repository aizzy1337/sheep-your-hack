using Castle.Core.Logging;
using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Handlers;


public record GetAllFeedQueruRequest() : IRequest<List<Feed>> { }
public class GetAllFeedQuaryHandler : IRequestHandler<GetAllFeedQueruRequest, List<Feed>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<GetAllFeedQuaryHandler> _logger;

    public GetAllFeedQuaryHandler(IUnitOfWork unitOfWork, ILogger<GetAllFeedQuaryHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<List<Feed>> Handle(GetAllFeedQueruRequest request, CancellationToken cancellationToken)
    {
        var result = await _unitOfWork.Feeds.GetAll();

        var users = await _unitOfWork.Users.GetAll();

        var events = await _unitOfWork.Events.GetAll();

        var polls = await _unitOfWork.Polls.GetAll();

        var options = await _unitOfWork.Options.GetAll();

        foreach (var feed in result)
        {
            feed.User = users.FirstOrDefault(x => x.Id == feed.UserId);
            feed.Event = events.FirstOrDefault(x => x.FeedId == feed.Id);
            feed.Poll = polls.FirstOrDefault(x => x.FeedId == feed.Id);
            
            if (feed.Poll != null)
            {
                var opt = options.Where(x => x.PollId == feed.Poll.Id).ToList();
                foreach (var o in opt)
                {
                    feed.Poll.Options.Add(o);
                }
            }
            
        }

        return result.ToList();
    }
}
