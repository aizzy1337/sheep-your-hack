﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;
using SheepYourHackApp.Server.UnitsOfWork;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Handlers
{
    public class CreateFeedCommandRequest : IRequest<Feed>
    {
        public FeedDto feedDto { get; }

        public CreateFeedCommandRequest(FeedDto feedDto)
        {
            this.feedDto = feedDto;
        }

    }

    public class CreateFeedCommandHandler : IRequestHandler<CreateFeedCommandRequest, Feed>
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CreateFeedCommandRequest> _logger;

        public CreateFeedCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateFeedCommandRequest> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<Feed> Handle(CreateFeedCommandRequest request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Feed>(request.feedDto);
            result.User = await _unitOfWork.Users.GetById(request.feedDto.UserId);
            var group = await _unitOfWork.Groups.GetById(1);
            result.Groups = new List<Group> { group };

            await _unitOfWork.Feeds.Add(result);
            var feedgroup = new FeedGroup { Feed = result, Group = group };
            await _unitOfWork.FeedGroups.Add(feedgroup);
            await _unitOfWork.CompleteAsync();
            return result;
        }
    }
}
