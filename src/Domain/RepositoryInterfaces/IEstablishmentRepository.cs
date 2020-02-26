using System.Threading.Tasks;

namespace Plannoy.Domain.RepositoryInterfaces
{
    public interface IEstablishmentRepository : IRepository<Establishment.Establishment>
    {
        Task<Establishment.Establishment> GetByNameAsync(string name);
    }
}
