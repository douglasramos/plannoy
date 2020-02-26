using AutoMapper;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CreateTransaction;
using Plannoy.Application.GetTransactionsByFilter;
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
            // API request -> App
            CreateMap<CreateTransactionApiModel, CreateTransactionCommand>()
                .ForMember(d => d.Money, opt => opt.MapFrom(s => new Money(s.Value, s.Currency)));

            // App/Domain -> API response
            CreateMap<Transaction, TransactionApiModel>()
                .ForMember(d => d.Currency, opt => opt.MapFrom(s => s.Money.Currency))
                .ForMember(d => d.Value, opt => opt.MapFrom(s => s.Money.Value))
                .ForMember(d => d.EstablishmentSector, opt => opt.MapFrom(s => s.Establishment.Sector));

            // API request -> App
            CreateMap<GetTransactionsByFilterApiModel, GetTransactionsByFilterQuery>()
                .ForMember(d => d.InitialDate, opt => opt.MapFrom(s => s.InitialDate == null ? s.InitialDate : s.InitialDate.Value.ToUniversalTime()))
                .ForMember(d => d.FinalDate, opt => opt.MapFrom(s => s.FinalDate == null ? s.FinalDate : s.FinalDate.Value.ToUniversalTime()));
        }
    }
}
