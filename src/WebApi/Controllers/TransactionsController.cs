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
using Plannoy.Application.GetTransactionById;
using Plannoy.Application.GetTransactionsByFilter;
using Plannoy.Domain;
using Plannoy.WebApi.ApiModel;
using Plannoy.WebApi.Presenters;

namespace Plannoy.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TransactionsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        /// <summary>
        /// API de lançamentos - Endpoint for creating new transactions
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="request">transaction information</param>
        /// <returns>transaction created</returns>
        [HttpPost]
        public async Task<ActionResult<TransactionApiModel>> Create([FromServices] CreateTransactionPresenter presenter,
            [FromBody] CreateTransactionApiModel request)
        {
            var command = _mapper.Map<CreateTransactionCommand>(request);

            await _mediator.Send(command);

            return presenter.Response;
        }

        /// <summary>
        /// API de Extrato. Endpoints for fetching transactions bases on date filters
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="filter">filter for fetching transactions</param>
        /// <returns>transactions list</returns>
        [HttpGet]
        public async Task<ActionResult<List<TransactionApiModel>>> GetByFilter([FromServices] GetTransactionByFilterPresenter presenter,
            [FromQuery] GetTransactionsByFilterApiModel filter)
        {
            var query = _mapper.Map<GetTransactionsByFilterQuery>(filter);

            await _mediator.Send(query);

            return presenter.Response;
        }

        /// <summary>
        /// Get a transaction given its id
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="id"> transaction's id</param>
        /// <returns>transaction</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TransactionApiModel>> GetById([FromServices] GetTransactionByIdPresenter presenter, 
            [FromRoute] long id)
        {
            var query = new GetTransactionByIdQuery { Id = id };

            await _mediator.Send(query);

            return presenter.Response;
        }
    }
}
