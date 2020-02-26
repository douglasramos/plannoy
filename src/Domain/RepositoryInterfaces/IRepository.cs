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

        IQueryable<TEntity> GetQueryable();

        Task<TEntity> GetByIdAsync(long id);

        Task<TEntity> AddAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);
    }
}
