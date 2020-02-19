using Plannoy.Domain;
using Plannoy.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public class EstablishmentRepository : IEstablishmentRepository
    {
        private readonly PlannoyDbContext _dbContext;
        public EstablishmentRepository(PlannoyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<long> AddAsync(Establishment entity)
        {
            var entityEntry = await _dbContext.Establishments.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entityEntry.Entity.Id!.Value;
        }

        public Task<IEnumerable<Establishment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Establishment> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Establishment>> GetQueryableAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Establishment entity)
        {
            throw new NotImplementedException();
        }
    }
}
