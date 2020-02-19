using Microsoft.EntityFrameworkCore;
using Plannoy.Domain;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Plannoy.Persistance
{
    public class PlannoyDbContext: DbContext
    {
        public PlannoyDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Establishment> Establishments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(PlannoyDbContext).Assembly);
            //SeedData.Seed(builder);
        }
    }
}
