using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SheepYourHackApp.Server.Handlers;
using SheepYourHackApp.Server.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class FeedsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public FeedsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("{groupId}")]
        public async Task<IActionResult> Get([FromRoute] int groupId)
        {
            var result = await _mediator.Send(new GetAllFeedQueruRequest(groupId));

            return Ok(_mapper.Map<List<FeedDto>>(result));
        }
    }
}
