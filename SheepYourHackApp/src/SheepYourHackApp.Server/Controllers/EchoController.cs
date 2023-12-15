using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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

        public EchoController(IMapper mapper)
        {
            _mapper = mapper;
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

            var testDto = _mapper.Map<TestModelDto>(test);


            return Ok(testDto);
        }
    }

}
