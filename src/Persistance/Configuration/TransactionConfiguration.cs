﻿using Microsoft.EntityFrameworkCore;
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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        /// <summary>
        /// Configure Transaction.
        /// </summary>
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            // TODO centralize this behavior on a base class
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.OwnsOne(t => t.Money, m =>
            {
                m.Property(m => m.Value)
                .HasColumnName("MoneyValue")
                .IsRequired();

                m.Property(m => m.Currency)
                .HasColumnName("MoneyCurrency")
                .IsRequired()
                .HasMaxLength(3);
            });

            builder
                .HasOne(t => t.Establishment)
                .WithMany(e => e.Transactions)
                .IsRequired();
        }
    }
}
