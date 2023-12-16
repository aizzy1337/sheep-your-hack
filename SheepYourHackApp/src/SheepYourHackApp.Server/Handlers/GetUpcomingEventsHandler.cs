using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Linq;

namespace SheepYourHackApp.Server.Handlers
{
    public record GetUpcomingEventsByUserIdRequest(int UserId) : IRequest<List<Event>> { }

    public class GetUpcomingEventsByUserIdHandler : IRequestHandler<GetUpcomingEventsByUserIdRequest, List<Event>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetGroupByIdQueryRequest> _logger;

        public GetUpcomingEventsByUserIdHandler(IUnitOfWork unitOfWork, ILogger<GetGroupByIdQueryRequest> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<List<Event>> Handle(GetUpcomingEventsByUserIdRequest request, CancellationToken ct)
        {
            var events = await _unitOfWork.Events.GetAll();
            var feeds = await _unitOfWork.Feeds.GetAll();
            var groups = await _unitOfWork.Groups.GetAll();
            DateTime yesterday = DateTime.Now.AddDays(-1);
            var upcomingEvents = events.Where(x => x.StartDate > yesterday);
            return null;
        }
    }
}
