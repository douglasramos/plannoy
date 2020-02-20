using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using Plannoy.WebApi.Presenters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CreateTransactionPresenter _presenter;

        public TransactionsController(IMediator mediator, CreateTransactionPresenter presenter)
        {
            _presenter = presenter;
            _mediator = mediator;
        }

        //[HttpPost]
        //public async Task<ActionResult> Create([FromBody] CreateEstablishmentCommand request)
        //{
        //    await _mediator.Send(request);

        //    return _presenter.Response;
        //}

        /// <summary>
        /// opa opa opa
        /// </summary>
        /// <param name="transaction">Modelo de entrada</param>
        /// <returns>isso eh um retorno</returns>
        [HttpPost]
        public ActionResult<TransactionApiModel> GetById([FromBody] TransactionApiModel transaction)
        {
            return Ok(transaction);
        }
    }
}
