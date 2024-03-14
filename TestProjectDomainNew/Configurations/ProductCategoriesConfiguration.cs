using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class ProductCategoriesConfiguration : IEntityTypeConfiguration<ProductCategories>
{
    public void Configure(EntityTypeBuilder<ProductCategories> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(f => f.Products)
            .WithOne(d => d.ProductCategories);
    }
}