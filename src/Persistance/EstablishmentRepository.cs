using Microsoft.EntityFrameworkCore;
using Plannoy.Domain;
using Plannoy.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Persistance
{
    public class EstablishmentRepository : Repository<Establishment>, IEstablishmentRepository
    {
        public EstablishmentRepository(PlannoyDbContext dbContext) : base(dbContext)
        {
        }

        /// <summary>
        /// Get a establishment domain object by its name. If the establishment not found on the db,
        /// throws the EstablishmentNotfoundExcepetion
        /// </summary>
        public async Task<Establishment> GetByNameAsync(string name)
        {
            var establishment = await _dbContext.Establishments
                .Where(e => e.Name == name)
                .FirstOrDefaultAsync();

            if (establishment is null)
            {
                throw new EstablishmentNotFoundException();
            }

            return establishment;

        }
    }
}
