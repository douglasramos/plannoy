using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.GetTransactionsByFilter
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface IGetTransactionsByFilterOutputPort : IOutputPortError, IOutputPortSuccess<List<Transaction>>
    {
    }
}
