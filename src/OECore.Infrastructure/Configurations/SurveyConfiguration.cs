using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
{
    public void Configure(EntityTypeBuilder<Survey> builder)
    {
        builder.ToTable("tbl_FORMS_Surveys");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.TemplateId)
            .HasColumnName("templateId");
        
        builder.Property(e => e.UserId)
            .HasColumnName("userId");
        
        builder.Property(e => e.CompanyId)
            .HasColumnName("companyId");
        
        builder.Property(e => e.RegionId)
            .HasColumnName("regionId");
        
        builder.Property(e => e.DtCreated)
            .HasColumnName("dtCreated")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtClosed)
            .HasColumnName("dtClosed")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtDeleted)
            .HasColumnName("dtDeleted")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtUploaded)
            .HasColumnName("dtUploaded")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtModified)
            .HasColumnName("dtModified")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtExported)
            .HasColumnName("dtExported")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.DtBalanced)
            .HasColumnName("dtBalanced")
            .HasColumnType("timestamp");
        
        builder.Property(e => e.Sync)
            .HasColumnName("sync");
        
        // Relationships
        builder.HasOne(e => e.SurveyTemplate)
            .WithMany(e => e.Surveys)
            .HasForeignKey(e => e.TemplateId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.User)
            .WithMany()
            .HasForeignKey(e => e.UserId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Company)
            .WithMany()
            .HasForeignKey(e => e.CompanyId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Region)
            .WithMany()
            .HasForeignKey(e => e.RegionId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Answers)
            .WithOne(e => e.Survey)
            .HasForeignKey(e => e.SurveyId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
