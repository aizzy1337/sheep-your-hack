using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Models;
using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(ApplicationDbContext context, ILogger logger)
            : base(context, logger) { }
}
