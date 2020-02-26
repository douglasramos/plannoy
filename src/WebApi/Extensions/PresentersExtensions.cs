using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Application.CreateTransaction;
using Plannoy.Application.GetTransactionById;
using Plannoy.Application.GetTransactionsByFilter;
using Plannoy.Domain;
using Plannoy.Persistance;
using Plannoy.WebApi.Presenters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Plannoy.WebApi.Extensions
{
    namespace WebApi.DependencyInjection
    {
        public static class PresentersExtensions
        {

            public static IServiceCollection AddPresenters(this IServiceCollection services)
            {
                services.AddScoped<CreateEstablishmentPresenter>();
                services.AddScoped<ICreateEstablishmentOutputPort>(c =>
                    c.GetRequiredService<CreateEstablishmentPresenter>());

                services.AddScoped<CreateTransactionPresenter>();
                services.AddScoped<ICreateTransactionOutputPort>(c =>
                    c.GetRequiredService<CreateTransactionPresenter>());

                services.AddScoped<GetTransactionByIdPresenter>();
                services.AddScoped<IGetTransactionByIdOutputPort>(c =>
                    c.GetRequiredService<GetTransactionByIdPresenter>());

                services.AddScoped<GetTransactionByFilterPresenter>();
                services.AddScoped<IGetTransactionsByFilterOutputPort>(c =>
                    c.GetRequiredService<GetTransactionByFilterPresenter>());

                return services;
            }
        }
    }

}
