using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.GetTransactionsByFilter
{
    public class GetTransactionsByFilterQuery : IQuery
    {
        /// <summary>
        /// Initial Date.
        /// </summary>
        public DateTime? InitialDate { get; set; }

        /// <summary>
        /// Final Date.
        /// </summary>
        public DateTime? FinalDate { get; set; }
    }
}

