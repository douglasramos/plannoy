using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;
using Plannoy.Domain.Establishment;

namespace Plannoy.Application.CreateEstablishment
{
    /// <summary>
    /// Create Establishment Output Port
    /// </summary>
    public interface ICreateEstablishmentOutputPort : IOutputPortError, IOutputPortSuccess<Establishment>
    {
    }
}
