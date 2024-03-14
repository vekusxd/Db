using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectDomainNew.Entities;

namespace TestProjectDomainNew.Configurations;

public class RoleEmployeesConfiguration : IEntityTypeConfiguration<RoleEmployees>
{
    public void Configure(EntityTypeBuilder<RoleEmployees> builder)
    {
        builder.HasKey(c => c.Id);

        builder
            .HasOne(r => r.Employee)
            .WithOne(f => f.Role);
        
    }
}







