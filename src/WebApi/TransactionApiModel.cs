using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
{
    public class TransactionApiModel
    {
        /// <summary>
        /// Name of establishment
        /// </summary>
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Establishment on which the transaction was made
        /// </summary>
        public Establishment? Establishment { get; set; }

        public TransactionPaymentMethod PaymentMethod { get; set; }

        public decimal Value { get; set; }

        public Currency Currency { get; set; }
    }
}
