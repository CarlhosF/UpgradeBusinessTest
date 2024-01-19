using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UpgradeBusinessTest._01.Domain.Entities;

namespace UpgradeBusinessTest._03.Persistences.Data.EntityConfigurations
{
    public class ClientTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(p => p.CardCode);
            builder.ToTable("Clients");
        }
    }
}
