using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Domain
{
    public interface IRepository<TEntity> where TEntity: class, IEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<IQueryable<TEntity>> GetQueryableAsync();

        Task<TEntity> GetAsync(long id);

        Task<long> AddAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);
    }
}
