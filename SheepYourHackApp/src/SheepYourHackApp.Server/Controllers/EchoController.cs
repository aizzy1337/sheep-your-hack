using Microsoft.AspNetCore.Mvc;

namespace SheepYourHackApp.Server.Controllers
{
    [ApiController]
    [Route("/api")]
    public class EchoController : Controller
    {
        [Route("/echo")]
        [HttpGet]
        public string Echo()
        {
            return "Hello world";
        }
    }
}
