using System;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain.Transaction;

namespace Plannoy.Application.CreateTransaction
{
    public class CreateTransactionCommand : ICommand
    {

        public CreateTransactionCommand(DateTime referenceDate, TransactionPaymentMethod paymentMethod, string establishment)
        {
            ReferenceDate = referenceDate;
            PaymentMethod = paymentMethod;
            Establishment = establishment;
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
        public Money Money { get; set; } = null!;

        /// <summary>
        /// Name of the establishment where the transaction occured
        /// </summary>
        public string Establishment { get; set; } = null!;
    }
}
