using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Plannoy.Domain;
using Plannoy.Persistance;
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
        public static class DatabaseExtensions
        {

            public static IServiceCollection AddDatabase(this IServiceCollection services)
            {
                services.AddDbContext<PlannoyDbContext>(options => options.UseSqlite(@"Data Source=C:\Users\Douglas\Desktop\dbplannoy\plannoy.db"));

                services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();

                services.AddScoped<ITransactionRepository, TransactionRepository>();

                return services;
            }
        }
    }

}
