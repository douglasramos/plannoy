using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.GetTransactionById
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IGetTransactionByIdOutputPort : IOutputPortError, IOutputPortSuccess<Transaction>
    {
    }
}
