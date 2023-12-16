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
    public class GroupController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public GroupController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Groups()
        {
            var result = await _mediator.Send(new GetAllGroupsQueryRequest());

            return Ok(_mapper.Map<List<GroupDto>>(result));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetGroup(int id)
        {
            var result = await _mediator.Send(new GetGroupByIdQueryRequest(id));

            return Ok(_mapper.Map<GroupDto>(result));
        }
    }
}
