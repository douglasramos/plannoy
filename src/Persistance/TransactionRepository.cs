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
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        public TransactionRepository(PlannoyDbContext dbContext) : base(dbContext)
        {
        }
    }
}
