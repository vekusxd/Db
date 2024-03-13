using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(c => c.Order)
            .WithOne(o => o.Client);

        builder
            .HasOne(c => c.Loyality)
            .WithOne(l => l.Client);
    }
}