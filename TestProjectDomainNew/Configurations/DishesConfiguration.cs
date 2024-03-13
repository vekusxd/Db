using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class DishesConfiguration : IEntityTypeConfiguration<Dishes>
{
    public void Configure(EntityTypeBuilder<Dishes> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(d => d.ListOfOrders)
            .WithMany(l => l.Dishes)
            .HasForeignKey(d => d.Id);

        builder
            .HasMany(d => d.CategoryDishes)
            .WithOne(c => c.Dishes)
            .HasForeignKey(f => f.Id);

        builder
            .HasMany(c => c.Ingredients)
            .WithOne(f => f.Dishes)
            .HasForeignKey(f => f.Id);
    }
}