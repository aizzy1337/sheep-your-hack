using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.Repositories
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationDbContext context, ILogger logger)
            : base(context, logger) { }
    }
}
