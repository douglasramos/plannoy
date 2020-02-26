using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain.Transaction;

namespace Plannoy.Application.GetTransactionById
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IGetTransactionByIdOutputPort : IOutputPortError, IOutputPortSuccess<Transaction>
    {
    }
}
