using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.GetTransactionById;
using Plannoy.Domain.Transaction;
using Plannoy.WebApi.ApiModel;
using System;

namespace Plannoy.WebApi.Presenters
{
    public class GetTransactionByIdPresenter : IGetTransactionByIdOutputPort
    {
        private readonly IMapper _mapper;

        public ActionResult<TransactionApiModel> Response { get; set; } = null!;

        public GetTransactionByIdPresenter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Error(Exception exception)
        {
            Response = new NotFoundObjectResult(new { ErrorMessage = exception.Message } );
        }

        public void Success(Transaction response)
        {
            Response = new OkObjectResult(_mapper.Map<TransactionApiModel>(response));
        }
    }
}