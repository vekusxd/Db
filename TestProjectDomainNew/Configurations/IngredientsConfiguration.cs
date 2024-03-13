using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class IngredientsConfiguration : IEntityTypeConfiguration<Ingredients>
{
    public void Configure(EntityTypeBuilder<Ingredients> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(i => i.Dishes)
            .WithMany(d => d.Ingredients)
            .HasForeignKey(i => i.Id);
    }
}