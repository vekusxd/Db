using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class ProviderConfiguration : IEntityTypeConfiguration<Providers>
{
    public void Configure(EntityTypeBuilder<Providers> builder)
    {
        builder.HasKey(b => b.Id);

        builder
            .HasOne(f => f.Delivery)
            .WithOne(d => d.Providers);
    }
}