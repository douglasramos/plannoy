using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateTransaction;
using Plannoy.Application.GetTransactionsByFilter;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Presenters
{
    public class GetTransactionByFilterPresenter : IGetTransactionsByFilterOutputPort
    {
        private readonly IMapper _mapper;

        public ActionResult<List<TransactionApiModel>> Response { get; set; } = null!;

        public GetTransactionByFilterPresenter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Error(Exception exception)
        {
            Response = new NotFoundObjectResult(new { ErrorMessage = exception.Message } );
        }

        public void Success(List<Transaction> response)
        {
            Response = new OkObjectResult(_mapper.Map<List<TransactionApiModel>>(response));
        }
    }
}