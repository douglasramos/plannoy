using Microsoft.AspNetCore.Mvc;
using Plannoy.Application.CreateEstablishment;
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

        public void Success(CreateEstablishmentResponse response)
        {
            Response = new CreatedAtActionResult("Get", "Establishments", new { id = response.Id }, null);
        }
    }
}
