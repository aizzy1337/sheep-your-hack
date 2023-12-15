using SheepYourHackApp.Server.Data;
using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.UnitsOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public IUserRepository Users { get; private set; }

    public UnitOfWork(ApplicationDbContext context, IUserRepository users)
    {
        _context = context;
        Users = users;
    }
}
