using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class EmailTextConfiguration : IEntityTypeConfiguration<EmailText>
{
    public void Configure(EntityTypeBuilder<EmailText> builder)
    {
        builder.ToTable("tbl_CONFIG_EmailTexts");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.DestinationId)
            .HasColumnName("destinationId");
            
        builder.Property(e => e.Subject)
            .HasColumnName("subject")
            .HasMaxLength(4000);
            
        builder.Property(e => e.Body)
            .HasColumnName("body")
            .HasMaxLength(4000);
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        // Relationship
        builder.HasOne(e => e.Destination)
            .WithMany()
            .HasForeignKey(e => e.DestinationId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
