using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.HasKey(d => d.Id);

        builder
            .HasOne(f => f.ProductCategories)
            .WithOne(s => s.Products);

        builder
            .HasOne(f => f.Invoices)
            .WithMany(s => s.Products)
            .HasForeignKey(k => k.Id);

        builder
            .HasOne(f => f.Storage)
            .WithOne(s => s.Products);
    }
}