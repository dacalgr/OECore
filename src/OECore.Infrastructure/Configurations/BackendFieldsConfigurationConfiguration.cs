using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class BackendFieldsConfigurationConfiguration : IEntityTypeConfiguration<BackendFieldsConfiguration>
{
    public void Configure(EntityTypeBuilder<BackendFieldsConfiguration> builder)
    {
        builder.ToTable("tbl_BACKEND_FieldsConfiguration");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.ViewName)
            .HasColumnName("viewName")
            .HasMaxLength(100);
        
        builder.Property(e => e.JsonFields)
            .HasColumnName("jsonFields");
        
        builder.Property(e => e.JsonFieldsFr)
            .HasColumnName("jsonFields_FR");
        
        builder.Property(e => e.JsonFieldsIt)
            .HasColumnName("jsonFields_IT");
        
        builder.Property(e => e.JsonFieldsEn)
            .HasColumnName("jsonFields_EN");
    }
}
