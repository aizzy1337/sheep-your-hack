using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SheepYourHackApp.Server.Handlers;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Controllers
{
    [ApiController]
    [Route("/api")]
    public class EchoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public EchoController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("echo")]
        public async Task<IActionResult> Echo()
        {
            return Ok();
        }

        [HttpGet("mapper")]
        public async Task<IActionResult> AutomapperTest()
        {
            var test = new TestModel();
            test.Id = 1;
            test.Name = "test";

            var result = await _mediator.Send(new TestRequest(test));

            var testDto = _mapper.Map<TestModelDto>(result);

            return Ok(testDto);
        }
    }

}
