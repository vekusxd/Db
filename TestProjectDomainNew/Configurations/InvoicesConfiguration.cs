using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class InvoicesConfiguration : IEntityTypeConfiguration<Invoices>
{
    public void Configure(EntityTypeBuilder<Invoices> builder)
    {
        builder.HasKey(k => k.Id);

        builder
            .HasMany(f => f.Products)
            .WithOne(s => s.Invoices)
            .HasForeignKey(k => k.Id);

        builder.HasMany(f => f.Deliveries)
            .WithOne(s => s.Invoices)
            .HasForeignKey(k => k.Id);
        
        
    }
}