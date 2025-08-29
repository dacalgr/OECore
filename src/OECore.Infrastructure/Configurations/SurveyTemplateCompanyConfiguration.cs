using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class SurveyTemplateCompanyConfiguration : IEntityTypeConfiguration<SurveyTemplateCompany>
{
    public void Configure(EntityTypeBuilder<SurveyTemplateCompany> builder)
    {
        builder.ToTable("tbl_FORMS_SurveyTemplates_Companies");
        builder.HasKey(e => new { e.TemplateId, e.CompanyId });
        
        builder.Property(e => e.TemplateId)
            .HasColumnName("templateId");
        
        builder.Property(e => e.CompanyId)
            .HasColumnName("companyId");
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        // Relationships
        builder.HasOne(e => e.SurveyTemplate)
            .WithMany(e => e.SurveyTemplateCompanies)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Company)
            .WithMany()
            .HasForeignKey(e => e.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
