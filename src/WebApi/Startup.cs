using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistance;
using Plannoy.Application.CreateEstablishment;
using Plannoy.Domain;
using Plannoy.Persistance;
using Plannoy.WebApi.Presenters;

namespace Plannoy.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();

            services.AddMediatR(typeof(CreateEstablishmentCommandHandler).Assembly);

            services.AddDbContext<PlannoyDbContext>(options => options.UseSqlite(@"Data Source=C:\Users\Douglas\Desktop\dbplannoy\plannoy.db"));

            services.AddScoped<IEstablishmentRepository, EstablishmentRepository>();

            services.AddScoped<CreateEstablishmentPresenter>();
            services.AddScoped<ICreateEstablishmentOutputPort>(c =>
                c.GetRequiredService<CreateEstablishmentPresenter>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsProduction())
            {
                app.UseHttpsRedirection();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
