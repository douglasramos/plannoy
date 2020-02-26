using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Plannoy.Domain.RepositoryInterfaces;
using Plannoy.Persistance;
using Plannoy.Persistance.Repositories;

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
