using AutoMapper;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using Plannoy.Domain.Establishment;
using Plannoy.WebApi.ApiModel;
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
            // API request -> App
            CreateMap<CreateEstablishmentApiModel, CreateEstablishmentCommand>();

            // App -> Domain
            CreateMap<CreateEstablishmentCommand, Establishment>();

            // App/Domain -> API response
            CreateMap<Establishment, EstablishmentApiModel>();
        }
    }
}
