using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plannoy.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Persistance.Configuration
{
    /// <summary>
    ///     Establishment Configuration.
    /// </summary>
    public class EstablishmentConfiguration : IEntityTypeConfiguration<Establishment>
    {
        /// <summary>
        ///     Configure Establihment.
        /// </summary>
        public void Configure(EntityTypeBuilder<Establishment> builder)
        {
            builder.ToTable("Establishment");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            // TODO set max length
            builder.Property(e => e.Name).IsRequired();

            // TODO set max length
            builder.Property(e => e.Sector).IsRequired();
        }
    }
}
