using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class IncidentImageConfiguration : IEntityTypeConfiguration<IncidentImage>
{
    public void Configure(EntityTypeBuilder<IncidentImage> builder)
    {
        builder.ToTable("tblIncidentImage");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.ImageName).HasColumnName("imageName").HasMaxLength(500);
        builder.Property(e => e.ImageContent).HasColumnName("imageContent");
        builder.Property(e => e.IncidentId).HasColumnName("incident");
        builder.Property(e => e.IsQuittung).HasColumnName("isQuittung");

        // Relationship
        builder.HasOne(e => e.Incident).WithMany(e => e.IncidentImages).HasForeignKey(e => e.IncidentId).OnDelete(DeleteBehavior.Restrict);
    }
}
