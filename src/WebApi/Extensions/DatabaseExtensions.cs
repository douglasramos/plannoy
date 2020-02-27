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
                //services.AddDbContext<PlannoyDbContext>(options => options.UseSqlite(@"Data Source=C:\Users\Douglas\Desktop\dbplannoy\plannoy.db"));

                //services.AddDbContext<PlannoyDbContext>(options => options.UseNpgsql(@"postgres://txmsrsoy:jWTXBP7JbqNXFKjp370t5C0tcRQhw24K@tuffi.db.elephantsql.com:5432/txmsrsoy"));

                services.AddDbContext<PlannoyDbContext>(options => 
                    options.UseSqlServer(@"Server=tcp:plannoydb.database.windows.net,1433;Initial Catalog=plannoy;Persist Security Info=False;User ID=douglas;Password=database*123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"));

                services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();

                services.AddScoped<ITransactionRepository, TransactionRepository>();

                return services;
            }
        }
    }

}
