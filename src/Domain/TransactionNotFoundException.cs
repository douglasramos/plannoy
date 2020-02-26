using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Domain
{
    public class TransactionNotFoundException : Exception
    {
        public TransactionNotFoundException() : base("Transaction Not found")
        {
        }
    }
}
