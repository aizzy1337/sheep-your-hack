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
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UserController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var result = await _mediator.Send(new GetAllUsersQueryRequest());

            return Ok(_mapper.Map<List<UserDto>>(result));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQueryRequest(id));

            return Ok(_mapper.Map<UserDto>(result));
        }

        [HttpGet("{userId:int}/accept/{eventId:int}")]
        public async Task<IActionResult> AcceptEvent(int userId, int eventId)
        {
            var result = await _mediator.Send(new AcceptedEventCommandRequest(eventId, userId));
            return Ok();
        }
    }
}
