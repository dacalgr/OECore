using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class EmailTextDestinationConfiguration : IEntityTypeConfiguration<EmailTextDestination>
{
    public void Configure(EntityTypeBuilder<EmailTextDestination> builder)
    {
        builder.ToTable("tbl_CONFIG_EmailTexts_Destinations");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(50);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
    }
}
