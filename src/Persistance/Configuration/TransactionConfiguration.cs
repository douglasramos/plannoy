using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Plannoy.Domain.Transaction;
using System;

namespace Persistance.Configuration
{
    /// <summary>
    /// Transaction Configuration.
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

            builder.Property(t => t.ReferenceDate)
                .IsRequired()
                .HasConversion(
                    v => v,
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc));

            builder.Property(t => t.PaymentMethod)
                .IsRequired()
                .HasConversion(
                    v => v.ToString(),
                    v => (TransactionPaymentMethod)Enum.Parse(typeof(TransactionPaymentMethod), v));


            builder.OwnsOne(t => t.Money, m =>
            {
                m.Property(m => m.Value)
                .HasColumnName("MoneyValue")
                .IsRequired();

                m.Property(m => m.Currency)
                .HasColumnName("MoneyCurrency")
                .HasConversion(
                    v => v.ToString(),
                    v => (Currency)Enum.Parse(typeof(Currency), v))
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
