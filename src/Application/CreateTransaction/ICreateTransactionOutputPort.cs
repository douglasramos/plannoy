using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.CreateTransaction
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface ICreateTransactionOutputPort : IOutputPortError, IOutputPortSuccess<Transaction>
    {
    }
}
