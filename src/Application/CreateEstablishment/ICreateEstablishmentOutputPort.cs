﻿using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.CreateEstablishment
{
    /// <summary>
    /// Error Output Port.
    /// </summary>
    public interface ICreateEstablishmentOutputPort : IOutputPortError, IOutputPortSuccess<Establishment>
    {
    }
}
