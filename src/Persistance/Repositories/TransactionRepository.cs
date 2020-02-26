using Microsoft.EntityFrameworkCore;
using Plannoy.Application.GetTransactionsByFilter;
using Plannoy.Domain;
using Plannoy.Domain.RepositoryInterfaces;
using Plannoy.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Persistance.Repositories
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(PlannoyDbContext dbContext) : base(dbContext)
        {
        }

        public async override Task<Transaction> GetByIdAsync(long id)
        {
            return await _dbContext.Transactions
                .Include( m => m.Establishment)
                .Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Transaction>> GetByFilter(DateTime? initialDate, DateTime? finalDate)
        {
            var query = base.GetQueryable();

            if (initialDate != null)
            {
                query = query.Where(t => t.ReferenceDate >= initialDate.Value);
            }
            if (finalDate != null)
            {
                query = query.Where(t => t.ReferenceDate <= finalDate.Value);
            }

            return await query.ToListAsync();
        }
    }
}
