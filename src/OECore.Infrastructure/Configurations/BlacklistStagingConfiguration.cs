using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BlacklistStagingConfiguration : IEntityTypeConfiguration<BlacklistStaging>
{
    public void Configure(EntityTypeBuilder<BlacklistStaging> builder)
    {
        builder.ToTable("tblBlacklistStaging");
        builder.HasKey(e => new { e.Id, e.Created });
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
        
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
            .HasColumnType("timestamp");
        
        builder.Property(e => e.Comments)
            .HasColumnName("comments")
            .HasMaxLength(2014);
        
        builder.Property(e => e.FileId)
            .HasColumnName("fileId");
    }
}
