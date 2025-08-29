using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DocboxDocumentUserReadConfiguration : IEntityTypeConfiguration<DocboxDocumentUserRead>
{
    public void Configure(EntityTypeBuilder<DocboxDocumentUserRead> builder)
    {
        builder.ToTable("tbl_DOCBOX_DocumentsUsersRead");
        builder.HasKey(e => new { e.DocumentId, e.UserId });
        
        builder.Property(e => e.DocumentId)
            .HasColumnName("documentId");
        
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
        
        builder.Property(e => e.VersionDate)
            .HasColumnName("versionDate")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.ReadDate)
            .HasColumnName("readDate")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasOne(e => e.Document)
            .WithMany(e => e.DocumentUserReads)
            .HasForeignKey(e => e.DocumentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
