using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class SurveyTemplateConfiguration : IEntityTypeConfiguration<SurveyTemplate>
{
    public void Configure(EntityTypeBuilder<SurveyTemplate> builder)
    {
        builder.ToTable("tbl_FORMS_SurveyTemplates");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasMany(e => e.Surveys)
            .WithOne(e => e.SurveyTemplate)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.SurveyTemplateCompanies)
            .WithOne(e => e.SurveyTemplate)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.HasMany(e => e.SurveyTemplateSections)
            .WithOne(e => e.SurveyTemplate)
            .HasForeignKey(e => e.SurveyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
