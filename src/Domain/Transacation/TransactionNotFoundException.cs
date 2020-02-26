using System;
using System.Collections.Generic;
using System.Text;

namespace Plannoy.Domain.Transaction
{
    public class TransactionNotFoundException : Exception
    {
        public TransactionNotFoundException() : base("Transaction Not found")
        {
        }
    }
}
