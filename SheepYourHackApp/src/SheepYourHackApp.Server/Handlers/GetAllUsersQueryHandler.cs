using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Handlers
{
    public record GetAllUsersQueryRequest : IRequest<List<User>> { }

    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQueryRequest, List<User>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<GetAllUsersQueryHandler> _logger;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, ILogger<GetAllUsersQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<List<User>> Handle(GetAllUsersQueryRequest request, CancellationToken ct)
        {
            var result = await _unitOfWork.Users.GetAll();

            return result.ToList();
        }
    }

}
