using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UpgradeBusinessTest._01.Domain.Entities;

namespace UpgradeBusinessTest._03.Persistences.Data.EntityConfigurations
{
    public class InvoiceHeaderTypeConfiguration : IEntityTypeConfiguration<InvoiceHeader>
    {
        public void Configure(EntityTypeBuilder<InvoiceHeader> builder)
        {
            builder.HasKey(p => p.Id);
            builder.ToTable("InvoiceHeaders");
        }
    }
}
