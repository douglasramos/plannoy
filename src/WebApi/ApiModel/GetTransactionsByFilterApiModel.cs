using Microsoft.AspNetCore.Mvc;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi
{
    public class GetTransactionsByFilterApiModel
    {
        /// <summary>
        /// Initial Date. If not sended, the api will use the date of the oldest transaction
        /// </summary>
        [FromQuery(Name = "initial-date")]
        public DateTime? InitialDate { get; set; }

        /// <summary>
        /// Final Date. If not sended, the api will use today as final date
        /// </summary>
        [FromQuery(Name = "final-date")]
        public DateTime? FinalDate { get; set; }
    }
}
