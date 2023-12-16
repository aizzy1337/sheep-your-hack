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
    public class DeclinedEventCommandRequest : IRequest<Event>
    {
        public int eventId { get; }
        public int userId { get; }

        public DeclinedEventCommandRequest(int eventId, int userId)
        {
            this.eventId = eventId;
            this.userId = userId;
        }
    }

    public class DeclinedEventCommandHandler : IRequestHandler<DeclinedEventCommandRequest, Event>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeclinedEventCommandRequest> _logger;

        public DeclinedEventCommandHandler(IUnitOfWork unitOfWork, ILogger<DeclinedEventCommandRequest> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Event> Handle(DeclinedEventCommandRequest request, CancellationToken cancellationToken)
        {
            var eventToDecline = await _unitOfWork.Events.GetById(request.eventId);
            var user = await _unitOfWork.Users.GetById(request.userId);
            user.Events.Remove(eventToDecline);
            await _unitOfWork.CompleteAsync();
            return eventToDecline;
        }
    }
}
