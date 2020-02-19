using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plannoy.Application.CreateEstablishment;
using Plannoy.WebApi.Presenters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstablishmentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CreateEstablishmentPresenter _presenter;

        public EstablishmentsController(IMediator mediator, CreateEstablishmentPresenter presenter)
        {
            _presenter = presenter;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateEstablishmentCommand request)
        {
            await _mediator.Send(request);

            return _presenter.Response;
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            //await _mediator.Send(request);

            return Ok();
        }
    }
}
