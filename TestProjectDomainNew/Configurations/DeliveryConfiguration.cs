using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
        builder.HasKey(k => k.Id);

        builder
            .HasOne(f => f.Invoices)
            .WithMany(s => s.Deliveries)
            .HasForeignKey(k => k.Id);

        builder
            .HasOne(f => f.Providers)
            .WithOne(s => s.Delivery);
        
    }
}