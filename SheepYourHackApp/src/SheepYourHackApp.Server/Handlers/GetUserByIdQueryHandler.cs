using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace SheepYourHackApp.Server.Handlers
{
    public record GetUserByIdQueryRequest(int UserId) : IRequest<User> { }

    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQueryRequest, User>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetUserByIdQueryRequest> _logger;

        public GetUserByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetUserByIdQueryRequest> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<User> Handle(GetUserByIdQueryRequest request, CancellationToken ct)
        {
            var result = await _unitOfWork.Users.GetById(request.UserId);

            return result;
        }
    }
}
