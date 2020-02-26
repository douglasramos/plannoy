using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Domain
{
    public class EstablishmentNotFoundException : Exception
    {
        public EstablishmentNotFoundException() : base("Establishment Not found")
        {
        }
    }
}
