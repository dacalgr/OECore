using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.ToTable("tbl_CONFIG_Applications");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.ParentId)
            .HasColumnName("parentId");
            
        builder.Property(e => e.AppId)
            .HasColumnName("appId")
            .HasMaxLength(50);
            
        builder.Property(e => e.Prefix)
            .HasColumnName("prefix")
            .HasMaxLength(100);
            
        builder.Property(e => e.Accessory)
            .HasColumnName("accessory")
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
            
        builder.Property(e => e.DescriptionEn)
            .HasColumnName("descriptionEN")
            .HasMaxLength(100);
            
        builder.Property(e => e.DescriptionDe)
            .HasColumnName("descriptionDE")
            .HasMaxLength(100);
            
        builder.Property(e => e.DescriptionFr)
            .HasColumnName("descriptionFR")
            .HasMaxLength(100);
            
        builder.Property(e => e.DescriptionIt)
            .HasColumnName("descriptionIT")
            .HasMaxLength(100);
            
        builder.Property(e => e.IconEn)
            .HasColumnName("iconEN")
            .HasMaxLength(500);
            
        builder.Property(e => e.IconDe)
            .HasColumnName("iconDE")
            .HasMaxLength(500);
            
        builder.Property(e => e.IconFr)
            .HasColumnName("iconFR")
            .HasMaxLength(500);
            
        builder.Property(e => e.IconIt)
            .HasColumnName("iconIT")
            .HasMaxLength(500);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        // Self-referencing relationship
        builder.HasOne(e => e.Parent)
            .WithMany(e => e.Children)
            .HasForeignKey(e => e.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
