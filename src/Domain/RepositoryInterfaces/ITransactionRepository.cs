using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Domain
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        Task<List<Transaction>> GetByFilter(DateTime? initialDate, DateTime? finalDate);
    }
}
