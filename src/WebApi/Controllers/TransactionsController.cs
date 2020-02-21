using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CreateTransaction;
using Plannoy.Domain;
using Plannoy.WebApi.Presenters;

namespace Plannoy.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CreateTransactionPresenter _presenter;
        private readonly IMapper _mapper;

        public TransactionsController(IMediator mediator, IMapper mapper, CreateTransactionPresenter presenter)
        {
            _mediator = mediator;
            _mapper = mapper;
            _presenter = presenter;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TransactionApiModel request)
        {
            var command = _mapper.Map<CreateTransactionCommand>(request);

            await _mediator.Send(command);

            return _presenter.Response;
        }

        /// <summary>
        /// API de Extrato. Endpoints for fetching transactions bases on date filters
        /// </summary>
        /// <param name="transaction">filter for fetching transactions</param>
        /// <returns>isso eh um retorno</returns>
        [HttpGet]
        public ActionResult<TransactionApiModel> GetByFilter([FromQuery] TransactionsFilterApiModel transaction)
        {
            return Ok(transaction);
        }

        /// <summary>
        /// API de Extrato. Endpoints for fetching transactions bases on date filters
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<TransactionApiModel> GetById(long id)
        {
            return Ok(id);
        }
    }
}
