using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain.Transaction;

namespace Plannoy.Application.CreateTransaction
{
    /// <summary>
    /// Create Transaction Output Port.
    /// </summary>
    public interface ICreateTransactionOutputPort : IOutputPortError, IOutputPortSuccess<Transaction>
    {
    }
}
