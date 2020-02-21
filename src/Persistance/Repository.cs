using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plannoy.Domain;

namespace Plannoy.Persistance
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected readonly PlannoyDbContext _dbContext;

        public Repository(PlannoyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<long> AddAsync(TEntity entity)
        {
            var entityEntry = await _dbContext.Set<TEntity>().AddAsync(entity);

            await _dbContext.SaveChangesAsync();
            return entityEntry.Entity.Id!.Value;
        }

        public virtual Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<TEntity> GetByIdAsync(long id)
        {
            throw new System.NotImplementedException();
        }

        public virtual Task<IQueryable<TEntity>> GetQueryableAsync()
        {
            throw new System.NotImplementedException();
        }

        public virtual Task RemoveAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}