using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Repositories.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetById(int id);
    Task<IEnumerable<TEntity>> GetAll();
    

    Task<bool> Add(TEntity enity);
    Task<bool> Update(TEntity enity);
    Task<bool> Remove(TEntity enity);
}
