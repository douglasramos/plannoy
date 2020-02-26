using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.GetTransactionsByFilter;
using Plannoy.Domain.Transaction;
using Plannoy.WebApi.ApiModel;
using System;
using System.Collections.Generic;

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