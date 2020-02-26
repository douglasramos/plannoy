using Plannoy.Domain;
using Plannoy.WebApi.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.ApiModel
{
    public class TransactionApiModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Reference Date
        /// </summary>
        public DateTime ReferenceDate { get; set; }

        /// <summary>
        /// Payment Method
        /// </summary>
        public TransactionPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Value of the transaction
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Currency use in the transaction
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Sector of the establishment where the transaction occured
        /// </summary>
        public string EstablishmentSector { get; set; } = null!;
    }
}
