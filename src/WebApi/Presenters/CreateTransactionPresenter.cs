using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateTransaction;
using Plannoy.Domain;
using Plannoy.WebApi.ApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Presenters
{
    public class CreateTransactionPresenter : ICreateTransactionOutputPort
    {
        public ActionResult Response { get; set; } = null!;

        private readonly IMapper _mapper;

        public CreateTransactionPresenter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Error(Exception exception)
        {
            Response = new BadRequestObjectResult(new { ErrorMessage = exception.Message } );
        }

        public void Success(Transaction response)
        {
            var transaction = _mapper.Map<TransactionApiModel>(response);

            Response = new CreatedAtActionResult("GetById", "Transactions", new { id = response.Id } , transaction);
        }
    }
}