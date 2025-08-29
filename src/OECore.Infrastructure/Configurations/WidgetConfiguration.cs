using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class WidgetConfiguration : IEntityTypeConfiguration<Widget>
{
    public void Configure(EntityTypeBuilder<Widget> builder)
    {
        builder.ToTable("tbl_CONFIG_Widgets");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.ApplicationId)
            .HasColumnName("applicationId");
            
        builder.Property(e => e.WidgetId)
            .HasColumnName("widgetId")
            .HasMaxLength(50);
            
        builder.Property(e => e.Title)
            .HasColumnName("title")
            .HasMaxLength(50);
            
        builder.Property(e => e.NameEn)
            .HasColumnName("nameEN")
            .HasMaxLength(50);
            
        builder.Property(e => e.NameDe)
            .HasColumnName("nameDE")
            .HasMaxLength(50);
            
        builder.Property(e => e.NameFr)
            .HasColumnName("nameFR")
            .HasMaxLength(50);
            
        builder.Property(e => e.NameIt)
            .HasColumnName("nameIT")
            .HasMaxLength(50);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        // Relationships
        builder.HasOne(e => e.Application)
            .WithMany()
            .HasForeignKey(e => e.ApplicationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
