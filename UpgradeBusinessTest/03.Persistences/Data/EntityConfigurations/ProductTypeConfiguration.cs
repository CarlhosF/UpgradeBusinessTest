using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UpgradeBusinessTest._01.Domain.Entities;

namespace UpgradeBusinessTest._03.Persistences.Data.EntityConfigurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ItemCode);
            builder.ToTable("Products");
        }
    }
}
