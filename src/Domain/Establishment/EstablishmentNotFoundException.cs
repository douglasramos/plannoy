using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Domain.Establishment
{
    public class EstablishmentNotFoundException : Exception
    {
        public EstablishmentNotFoundException() : base("Establishment Not found")
        {
        }
    }
}
