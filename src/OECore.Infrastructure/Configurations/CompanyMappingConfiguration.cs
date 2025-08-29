using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CompanyMappingConfiguration : IEntityTypeConfiguration<CompanyMapping>
{
    public void Configure(EntityTypeBuilder<CompanyMapping> builder)
    {
        builder.ToTable("tblCompanyMapping");
        builder.HasKey(e => new { e.CompanyId, e.CompanyCode });
        
        builder.Property(e => e.CompanyId)
            .HasColumnName("companyId");
        
        builder.Property(e => e.CompanyCode)
            .HasColumnName("companyCode")
            .HasMaxLength(50);
        
        builder.Property(e => e.NewCompanyId)
            .HasColumnName("newCompanyId");
    }
}
