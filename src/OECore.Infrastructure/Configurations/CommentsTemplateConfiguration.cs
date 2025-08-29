using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class CommentsTemplateConfiguration : IEntityTypeConfiguration<CommentsTemplate>
{
    public void Configure(EntityTypeBuilder<CommentsTemplate> builder)
    {
        builder.ToTable("tbl_CONFIG_CommentsTemplates");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Code)
            .HasColumnName("code")
            .HasMaxLength(8);
            
        builder.Property(e => e.Text)
            .HasColumnName("text")
            .HasMaxLength(256);
            
        builder.Property(e => e.Rank)
            .HasColumnName("rank");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
