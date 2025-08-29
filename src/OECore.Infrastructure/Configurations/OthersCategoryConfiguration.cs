using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class OthersCategoryConfiguration : IEntityTypeConfiguration<OthersCategory>
{
    public void Configure(EntityTypeBuilder<OthersCategory> builder)
    {
        builder.ToTable("tbl_CONFIG_OthersCategories");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TextIt)
            .HasColumnName("text_it");
            
        builder.Property(e => e.TextFr)
            .HasColumnName("text_fr");
            
        builder.Property(e => e.TextDe)
            .HasColumnName("text_de");
            
        builder.Property(e => e.ParentId)
            .HasColumnName("parentId");
            
        builder.Property(e => e.CategoryId)
            .HasColumnName("categoryId");
            
        builder.Property(e => e.Rank)
            .HasColumnName("rank");
            
        builder.Property(e => e.LangRef)
            .HasColumnName("langRef");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
