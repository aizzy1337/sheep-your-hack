using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Threading.Tasks;
using System.Threading;

namespace SheepYourHackApp.Server.Handlers
{
    public record GetGroupByIdQueryRequest(int GroupId) : IRequest<Group> { }

    public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQueryRequest, Group>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetGroupByIdQueryRequest> _logger;

        public GetGroupByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetGroupByIdQueryRequest> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Group> Handle(GetGroupByIdQueryRequest request, CancellationToken ct)
        {
            var result = await _unitOfWork.Groups.GetById(request.GroupId);

            return result;
        }
    }
}
