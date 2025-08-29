using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DocboxFavoriteConfiguration : IEntityTypeConfiguration<DocboxFavorite>
{
    public void Configure(EntityTypeBuilder<DocboxFavorite> builder)
    {
        builder.ToTable("tbl_DOCBOX_Favorites");
        builder.HasKey(e => new { e.UserId, e.DocumentId });
        
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
        
        builder.Property(e => e.DocumentId)
            .HasColumnName("documentId");
        
        // Relationships
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Document)
            .WithMany(e => e.Favorites)
            .HasForeignKey(e => e.DocumentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
