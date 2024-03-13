using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class OrdersConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(o => o.Client)
            .WithOne(c => c.Order);

        builder
            .HasOne(o => o.Employee)
            .WithOne(e => e.Order);

        builder
            .HasOne(o => o.ListOfOrders)
            .WithOne(c => c.Order);
    }
}