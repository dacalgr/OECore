using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ControlTypeConfiguration : IEntityTypeConfiguration<ControlType>
{
    public void Configure(EntityTypeBuilder<ControlType> builder)
    {
        builder.ToTable("tblControlType");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.NameDe)
            .HasColumnName("nameDE")
            .HasMaxLength(4000);
            
        builder.Property(e => e.NameFr)
            .HasColumnName("nameFR")
            .HasMaxLength(4000);
            
        builder.Property(e => e.NameIt)
            .HasColumnName("nameIT")
            .HasMaxLength(4000);
            
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
    }
}
