
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Repositories;
using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.UnitsOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger _logger;

    public IUserRepository Users { get; private set; }
    public IFeedRepository Feeds { get; private set; }
    public IEventRepository Events { get; private set; }

    public UnitOfWork(ApplicationDbContext context, ILoggerFactory logger)
    {
        _context = context;
        _logger = logger.CreateLogger("repositoryLogger");
        Users = new UserRepository(_context, _logger);
        Feeds = new FeedRepository(_context, _logger);
        Events = new EventRepository(_context, _logger);

    }
}
