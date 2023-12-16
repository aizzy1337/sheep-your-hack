using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context, ILogger logger)
            : base(context, logger)
        {
            _context = context;
        }
    }
}
