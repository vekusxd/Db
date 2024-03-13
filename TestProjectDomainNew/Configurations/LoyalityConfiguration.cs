using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class LoyalityConfiguration : IEntityTypeConfiguration<Loyality>
{
    public void Configure(EntityTypeBuilder<Loyality> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(l => l.Client)
            .WithOne(c => c.Loyality);
    }
}