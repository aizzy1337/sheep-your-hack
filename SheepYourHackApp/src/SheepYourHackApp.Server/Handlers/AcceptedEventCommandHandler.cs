using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Threading.Tasks;
using System.Threading;

namespace SheepYourHackApp.Server.Handlers
{
    public class AcceptedEventCommandRequest : IRequest<Event>
    {
        public int eventId { get; }
        public int userId { get; }

        public AcceptedEventCommandRequest(int eventId, int userId)
        {
            this.eventId = eventId;
            this.userId = userId;
        }
    }

    public class AcceptedEventCommandHandler : IRequestHandler<AcceptedEventCommandRequest, Event>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateFeedCommandRequest> _logger;

        public AcceptedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateFeedCommandRequest> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Event> Handle(AcceptedEventCommandRequest request, CancellationToken cancellationToken)
        {
            var eventToAccept = await _unitOfWork.Events.GetById(request.eventId);
            var user = await _unitOfWork.Users.GetById(request.userId);
            user.Events.Add(eventToAccept);
            await _unitOfWork.CompleteAsync();
            return eventToAccept;
        }
    }
}
