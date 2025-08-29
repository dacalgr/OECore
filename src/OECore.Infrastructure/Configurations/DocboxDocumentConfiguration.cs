using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DocboxDocumentConfiguration : IEntityTypeConfiguration<DocboxDocument>
{
    public void Configure(EntityTypeBuilder<DocboxDocument> builder)
    {
        builder.ToTable("tbl_DOCBOX_Documents");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.FolderId)
            .HasColumnName("folderID");
        
        builder.Property(e => e.LangId)
            .HasColumnName("langID");
        
        builder.Property(e => e.Identifier)
            .HasColumnName("identifier")
            .HasMaxLength(4000);
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(1000);
        
        builder.Property(e => e.FileName)
            .HasColumnName("fileName")
            .HasMaxLength(1000);
        
        builder.Property(e => e.UrlDownload)
            .HasColumnName("urlDownload")
            .HasMaxLength(4000);
        
        builder.Property(e => e.Type)
            .HasColumnName("type")
            .HasMaxLength(10);
        
        builder.Property(e => e.Description)
            .HasColumnName("description")
            .HasMaxLength(4000);
        
        builder.Property(e => e.RequestReading)
            .HasColumnName("requestReading");
        
        builder.Property(e => e.Size)
            .HasColumnName("size");
        
        builder.Property(e => e.FlagOffline)
            .HasColumnName("flagOffline");
        
        builder.Property(e => e.FlagWasOffline)
            .HasColumnName("flagWasOffline");
        
        builder.Property(e => e.FlagWasOnline)
            .HasColumnName("flagWasOnline");
        
        builder.Property(e => e.ValidFrom)
            .HasColumnName("validFrom")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.ValidTo)
            .HasColumnName("validTo")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.HiddenInList)
            .HasColumnName("hiddenInList");
        
        builder.Property(e => e.CpnsMessage)
            .HasColumnName("cpns_message");
        
        builder.Property(e => e.DateCreated)
            .HasColumnName("dateCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DateModified)
            .HasColumnName("dateModified")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DateDeleted)
            .HasColumnName("dateDeleted")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.UserModified)
            .HasColumnName("userModified")
            .HasMaxLength(50);
        
        builder.Property(e => e.Priority)
            .HasColumnName("priority");
        
        // Relationships
        builder.HasOne(e => e.Folder)
            .WithMany(e => e.Documents)
            .HasForeignKey(e => e.FolderId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Language)
            .WithMany()
            .HasForeignKey(e => e.LangId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.DocumentUserReads)
            .WithOne(e => e.Document)
            .HasForeignKey(e => e.DocumentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Favorites)
            .WithOne(e => e.Document)
            .HasForeignKey(e => e.DocumentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
