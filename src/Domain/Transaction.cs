using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Plannoy.Domain
{
    public class Transaction : Entity
    {
        private Transaction() { }

        public Transaction(DateTime referenceDate, Establishment establishment, TransactionPaymentMethod paymentMethod, Money money)
        {
            ReferenceDate = referenceDate;
            Establishment = establishment;
            PaymentMethod = paymentMethod;
            Money = money;
        }

        /// <summary>
        /// Name of establishment
        /// </summary>
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Establishment on which the transaction was made
        /// </summary>
        public Establishment Establishment { get; set; } = null!;

        public TransactionPaymentMethod PaymentMethod { get; set; }

        public Money Money { get; set; } = null!;
    }
}
