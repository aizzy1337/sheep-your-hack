using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SheepYourHackApp.Server.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SheepYourHackApp.Server.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly ILogger _logger;
        internal DbSet<TEntity> _dbSet;

        public Repository(DbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            _dbSet = _context.Set<TEntity>();
        }
        public virtual async Task<TEntity?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public virtual async Task<bool> Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return true;
        }

        public virtual async Task<bool> Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
            return true;
        }
        
    }
}
