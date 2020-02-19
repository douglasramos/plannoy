using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;

namespace Plannoy.Application.CreateEstablishment
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface ICreateEstablishmentOutputPort : IOutputPortError, IOutputPortSuccess<CreateEstablishmentResponse>
    {
    }
}
