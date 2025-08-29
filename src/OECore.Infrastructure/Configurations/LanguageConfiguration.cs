using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("tblLanguage");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(10);
            
        builder.Property(e => e.ShortName)
            .HasColumnName("shortName")
            .HasMaxLength(10);
            
        // Relationships
        builder.HasMany(e => e.Users)
            .WithOne()
            .HasForeignKey("language")
            .OnDelete(DeleteBehavior.Restrict);
    }
}
