using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Presenters
{
    public class CreateEstablishmentPresenter : ICreateEstablishmentOutputPort
    {
        public ActionResult Response { get; set; } = null!;

        public void Error(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Success(Establishment response)
        {
            Response = new CreatedResult("", response);
        }
    }
}
