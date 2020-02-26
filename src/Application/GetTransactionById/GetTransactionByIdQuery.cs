using System;
using System.Collections.Generic;
using System.Text;
using Plannoy.Application.CommonInterfaces;
using Plannoy.Domain;

namespace Plannoy.Application.GetTransactionById
{
    public class GetTransactionByIdQuery : IQuery
    {
        public GetTransactionByIdQuery()
        {
        }

        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
    }
}
