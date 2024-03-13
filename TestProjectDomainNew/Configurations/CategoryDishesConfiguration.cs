using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class CategoryDishesConfiguration : IEntityTypeConfiguration<CategoryDishes>
{
    public void Configure(EntityTypeBuilder<CategoryDishes> builder)
    {
        builder.HasKey(c => c.Id);

        builder.HasOne(d => d.Dishes)
            .WithMany(f => f.CategoryDishes)
            .HasForeignKey(h => h.Id);
    }
}