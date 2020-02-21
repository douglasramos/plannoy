using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plannoy.Domain
{
    public interface IEstablishmentRepository : IRepository<Establishment>
    {
        Task<Establishment> GetByNameAsync(string name);
    }
}
