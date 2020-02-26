using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Domain.RepositoryInterfaces
{
    public interface ITransactionRepository : IRepository<Transaction.Transaction>
    {
        Task<List<Transaction.Transaction>> GetByFilter(DateTime? initialDate, DateTime? finalDate);
    }
}
