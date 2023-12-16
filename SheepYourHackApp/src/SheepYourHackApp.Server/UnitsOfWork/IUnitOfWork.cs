using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.UnitsOfWork;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
    IGroupRepository Groups { get; }
    IFeedRepository Feeds { get; }
    IEventRepository Events { get; }
    IPollRepository Polls { get; }
    IOptionRepository Options { get; }
}
