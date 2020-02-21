using AutoMapper;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CreateTransaction;
using Plannoy.Domain;
using Plannoy.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Mappings
{
    public class TransactionProfile : Profile
    {
        public TransactionProfile()
        {
            // API -> App
            CreateMap<TransactionApiModel, CreateTransactionCommand>()
                .ForMember(d => d.Money, opt => opt.MapFrom(s => new Money(s.Value, s.Currency)));
        }
    }
}
