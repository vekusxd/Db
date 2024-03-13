using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class ListOfOrderConfiguration : IEntityTypeConfiguration<ListOfOrders>
{
    public void Configure(EntityTypeBuilder<ListOfOrders> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .HasOne(l => l.Order)
            .WithOne(f => f.ListOfOrders);

        builder
            .HasMany(l => l.Dishes)
            .WithOne(d => d.ListOfOrders)
            .HasForeignKey(l => l.Id);
        
        
    }
}