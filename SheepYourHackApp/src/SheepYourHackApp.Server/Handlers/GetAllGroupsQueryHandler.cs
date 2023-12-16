using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;

namespace SheepYourHackApp.Server.Handlers
{
    public record GetAllGroupsQueryRequest : IRequest<List<Group>> { }

    public class GetAllGroupsQueryHandler : IRequestHandler<GetAllGroupsQueryRequest, List<Group>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllGroupsQueryHandler> _logger;

        public GetAllGroupsQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllGroupsQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<List<Group>> Handle(GetAllGroupsQueryRequest request, CancellationToken ct)
        {
            var result = await _unitOfWork.Groups.GetAll();

            return result.ToList();
        }
    }
}
