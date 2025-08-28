using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CompanyRegionConfiguration : IEntityTypeConfiguration<CompanyRegion>
{
    public void Configure(EntityTypeBuilder<CompanyRegion> builder)
    {
        builder.ToTable("company_region");
        builder.HasKey(x => new { x.CompanyId, x.RegionId });

        builder.HasOne(x => x.Company)
            .WithMany(x => x.CompanyRegions)
            .HasForeignKey(x => x.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.Region)
            .WithMany()
            .HasForeignKey(x => x.RegionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}


