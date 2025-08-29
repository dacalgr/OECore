using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DocboxFolderConfiguration : IEntityTypeConfiguration<DocboxFolder>
{
    public void Configure(EntityTypeBuilder<DocboxFolder> builder)
    {
        builder.ToTable("tbl_DOCBOX_Folders");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.ParentId)
            .HasColumnName("parentId");
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(500);
        
        builder.Property(e => e.VirtualPath)
            .HasColumnName("virtualPath")
            .HasMaxLength(1000);
        
        builder.Property(e => e.Hierarchy)
            .HasColumnName("hierarchy")
            .HasMaxLength(100);
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasOne(e => e.Parent)
            .WithMany(e => e.Children)
            .HasForeignKey(e => e.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Documents)
            .WithOne(e => e.Folder)
            .HasForeignKey(e => e.FolderId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
