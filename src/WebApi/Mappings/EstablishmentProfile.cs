using AutoMapper;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Mappings
{
    public class EstablishmentProfile: Profile
    {
        public EstablishmentProfile()
        {
            // App -> Domain
            CreateMap<CreateEstablishmentCommand, Establishment>();
        }
    }
}
