using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Repositories
{
    public class FeedGroupRepository : Repository<FeedGroup>, IFeedGroupRepository
    {
        private readonly ApplicationDbContext _context;

        public FeedGroupRepository(ApplicationDbContext context, ILogger logger)
            : base(context, logger)
        {
            _context = context;
        }
    }
}
