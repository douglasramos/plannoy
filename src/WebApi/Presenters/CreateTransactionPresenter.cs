using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Presenters
{
    public class CreateTransactionPresenter : ICreateTransactionOutputPort
    {
        public ActionResult Response { get; set; } = null!;

        public void Error(Exception exception)
        {
            Response = new BadRequestObjectResult(new { ErrorMessage = exception.Message } );
        }

        public void Success(CreateTransactionResponse response)
        {
            Response = new CreatedAtActionResult("GetById", "Transaction", new { id = response.Id } , null);
        }
    }
}