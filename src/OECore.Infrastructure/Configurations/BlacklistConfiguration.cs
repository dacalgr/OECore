using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BlacklistConfiguration : IEntityTypeConfiguration<Blacklist>
{
    public void Configure(EntityTypeBuilder<Blacklist> builder)
    {
        builder.ToTable("tblBlacklist");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(100);
        
        builder.Property(e => e.Vorname)
            .HasColumnName("vorname")
            .HasMaxLength(100);
        
        builder.Property(e => e.Blacklisted)
            .HasColumnName("blacklisted");
        
        builder.Property(e => e.CommentsDe)
            .HasColumnName("comments_de")
            .HasMaxLength(1024);
        
        builder.Property(e => e.CommentsFr)
            .HasColumnName("comments_fr")
            .HasMaxLength(1024);
        
        builder.Property(e => e.CommentsIt)
            .HasColumnName("comments_it")
            .HasMaxLength(1024);
        
        builder.Property(e => e.Birthdate)
            .HasColumnName("birthdate");
        
        builder.Property(e => e.Created)
            .HasColumnName("created");
        
        builder.Property(e => e.ExpirationDate)
            .HasColumnName("expirationDate")
            .HasColumnType("date");
        
        builder.Property(e => e.Comments)
            .HasColumnName("comments")
            .HasMaxLength(1014);
        
        builder.Property(e => e.FileId)
            .HasColumnName("fileId");
        
        builder.Property(e => e.CreatedAt)
            .HasColumnName("createdAt")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.UpdatedAt)
            .HasColumnName("updatedAt")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DeletetAt)
            .HasColumnName("deletetAt")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.LastImport)
            .HasColumnName("lastImport")
            .HasColumnType("timestamp");
    }
}
