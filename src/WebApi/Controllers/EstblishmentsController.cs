using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plannoy.Application.CreateEstablishment;
using Plannoy.WebApi;
using Plannoy.WebApi.Presenters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstablishmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CreateEstablishmentPresenter _presenter;
        private readonly IMapper _mapper;

        public EstablishmentsController(IMediator mediator, IMapper mapper, CreateEstablishmentPresenter presenter)
        {
            _mediator = mediator;
            _mapper = mapper;
            _presenter = presenter;
        }

        /// <summary>
        /// API de estabelecimentos - Endpoint used to register new establishments
        /// </summary>
        /// <param name="request">Establishment information</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Create([FromBody] EstablishmentApiModel request)
        {
            var command = _mapper.Map<CreateEstablishmentCommand>(request);

            await _mediator.Send(command);

            return _presenter.Response;
        }

        /// <summary>
        /// Endpoint used to Get by id a registered establishment
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] long id)
        {
            // Not implemented
            return Ok();
        }
    }
}
