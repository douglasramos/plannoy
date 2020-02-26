using Microsoft.EntityFrameworkCore;
using Plannoy.Domain.Establishment;
using Plannoy.Domain.Transaction;
using System.Diagnostics.CodeAnalysis;

namespace Plannoy.Persistance
{
    public class PlannoyDbContext: DbContext
    {
        public DbSet<Establishment> Establishments { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        public PlannoyDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(PlannoyDbContext).Assembly);
        }
    }
}
