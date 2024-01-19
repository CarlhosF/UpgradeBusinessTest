using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using UpgradeBusinessTest._01.Domain.Entities;

namespace UpgradeBusinessTest._03.Persistences.Data.EntityConfigurations
{
    public class InvoiceDetailsTypeConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("InvoiceDetails");
        }
    }
}
