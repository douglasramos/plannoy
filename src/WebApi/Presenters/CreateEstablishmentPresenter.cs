using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using Plannoy.Domain.Establishment;
using Plannoy.WebApi.ApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Presenters
{
    public class CreateEstablishmentPresenter : ICreateEstablishmentOutputPort
    {
        private readonly IMapper _mapper; 

        public ActionResult<EstablishmentApiModel> Response { get; set; } = null!;

        public CreateEstablishmentPresenter(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void Error(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Success(Establishment response)
        {
            Response = new CreatedResult("", _mapper.Map<EstablishmentApiModel>(response));
        }
    }
}
