using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class ReasonCategoryConfiguration : IEntityTypeConfiguration<ReasonCategory>
{
    public void Configure(EntityTypeBuilder<ReasonCategory> builder)
    {
        builder.ToTable("tbl_CONFIG_ReasonsCategories");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.TextIt)
            .HasColumnName("text_it")
            .IsRequired();
            
        builder.Property(e => e.TextDe)
            .HasColumnName("text_de")
            .IsRequired();
            
        builder.Property(e => e.TextFr)
            .HasColumnName("text_fr")
            .IsRequired();
            
        builder.Property(e => e.TextEn)
            .HasColumnName("text_en")
            .IsRequired();
            
        builder.Property(e => e.CategoryId)
            .HasColumnName("categoryId");
            
        builder.Property(e => e.CompanyId)
            .HasColumnName("companyId");
            
        builder.Property(e => e.Rank)
            .HasColumnName("rank");
            
        builder.Property(e => e.IsAbuse)
            .HasColumnName("isAbuse");
            
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
            
        builder.Property(e => e.DtLastSqliteImport)
            .HasColumnName("dtLastSQLIteImport")
            .HasColumnType("timestamp");
    }
}
