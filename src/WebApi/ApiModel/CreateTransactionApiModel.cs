using Plannoy.Domain;
using Plannoy.WebApi.Properties.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi
{
    public class CreateTransactionApiModel
    {
        /// <summary>
        /// Reference Date
        /// </summary>
        [Required]
        [NotFutureDate]
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Payment Method
        /// </summary>
        [Required]
        public TransactionPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Value of the transaction
        /// </summary>
        [Required]
        public decimal Value { get; set; }

        /// <summary>
        /// Currency use in the transaction
        /// </summary>
        [Required]
        public Currency Currency { get; set; }

        /// <summary>
        /// Name of the establishment where the transaction occured
        /// </summary>
        [Required]
        public string Establishment { get; set; } = null!;
    }
}
