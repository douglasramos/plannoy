using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Plannoy.Domain;
using Plannoy.Domain.RepositoryInterfaces;

namespace Plannoy.Persistance
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly PlannoyDbContext _dbContext;

        public Repository(PlannoyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            var entityEntry = await _dbContext.Set<TEntity>().AddAsync(entity);

            await _dbContext.SaveChangesAsync();
            return entityEntry.Entity;
        }

        public virtual async Task<TEntity> GetByIdAsync(long id)
        {
            return await _dbContext.Set<TEntity>().Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public virtual IQueryable<TEntity> GetQueryable()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public virtual Task RemoveAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}