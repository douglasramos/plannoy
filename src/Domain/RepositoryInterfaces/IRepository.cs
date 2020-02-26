using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Domain.RepositoryInterfaces
{
    public interface IRepository<TEntity> where TEntity: class, IEntity
    {
        IQueryable<TEntity> GetQueryable();

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(long id);

        Task<TEntity> AddAsync(TEntity entity);

        Task RemoveAsync(TEntity entity);
    }
}
