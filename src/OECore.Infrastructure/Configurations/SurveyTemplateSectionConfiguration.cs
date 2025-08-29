using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class SurveyTemplateSectionConfiguration : IEntityTypeConfiguration<SurveyTemplateSection>
{
    public void Configure(EntityTypeBuilder<SurveyTemplateSection> builder)
    {
        builder.ToTable("tbl_FORMS_SurveyTemplates_Sections");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.SurveyId)
            .HasColumnName("surveyId");
        
        builder.Property(e => e.SectionId)
            .HasColumnName("sectionId");
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasOne(e => e.SurveyTemplate)
            .WithMany(e => e.SurveyTemplateSections)
            .HasForeignKey(e => e.SurveyId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.FormSection)
            .WithMany(e => e.SurveyTemplateSections)
            .HasForeignKey(e => e.SectionId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Questions)
            .WithOne(e => e.SurveyTemplateSection)
            .HasForeignKey(e => e.SurveySectionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
