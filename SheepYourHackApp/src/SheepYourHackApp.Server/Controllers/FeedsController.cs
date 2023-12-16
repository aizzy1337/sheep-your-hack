using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] FeedDto feedDto)
        {
            await _mediator.Send(new CreateFeedCommandRequest(feedDto));

            return CreatedAtRoute("Get", new { id = feedDto.Id }, feedDto);
        }
    }
}
