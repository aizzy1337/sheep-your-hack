﻿using SheepYourHackApp.Server.Repositories.Interfaces;

namespace SheepYourHackApp.Server.UnitsOfWork;

public interface IUnitOfWork
{
    IUserRepository Users { get; }
    IFeedRepository Feeds { get; }
    IEventRepository Events { get; }
}
