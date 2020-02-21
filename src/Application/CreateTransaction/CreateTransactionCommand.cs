using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.CreateTransaction
{
    public class CreateTransactionCommand : ICommand
    {
        public CreateTransactionCommand()
        {
        }

        /// <summary>
        /// Reference Date
        /// </summary>
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Payment Method
        /// </summary>
        public TransactionPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Value of the transaction + Currency use in the transaction
        /// </summary>
        public Money Money { get; set; }

        /// <summary>
        /// Name of the establishment where the transaction occured
        /// </summary>
        public string Establishment { get; set; } = null!;
    }
}
