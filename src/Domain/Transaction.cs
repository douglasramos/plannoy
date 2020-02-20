using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Plannoy.Domain
{
    public class Transaction : Entity
    {
        public Transaction()
        {
        }

        /// <summary>
        /// Name of establishment
        /// </summary>
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Establishment on which the transaction was made
        /// </summary>
        public Establishment Establishment { get; set; }

        public TransactionPaymentMethod PaymentMethod { get; set; }

        public Money Money { get; set; }
    }
}
