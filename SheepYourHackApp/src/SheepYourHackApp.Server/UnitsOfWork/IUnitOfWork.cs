using SheepYourHackApp.Server.Repositories.Interfaces;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.UnitsOfWork;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
    IGroupRepository Groups { get; }
    IFeedRepository Feeds { get; }
    IEventRepository Events { get; }
    IPollRepository Polls { get; }
    IOptionRepository Options { get; }
    Task CompleteAsync();
    IFeedGroupRepository FeedGroups { get; }
}
