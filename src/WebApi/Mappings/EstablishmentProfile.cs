﻿using AutoMapper;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using Plannoy.WebApi;
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
            // API -> App
            CreateMap<EstablishmentApiModel, CreateEstablishmentCommand>();

            // App -> Domain
            CreateMap<CreateEstablishmentCommand, Establishment>();
        }
    }
}
