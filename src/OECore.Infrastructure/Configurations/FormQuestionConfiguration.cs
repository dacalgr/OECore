using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class FormQuestionConfiguration : IEntityTypeConfiguration<FormQuestion>
{
    public void Configure(EntityTypeBuilder<FormQuestion> builder)
    {
        builder.ToTable("tbl_FORMS_Questions");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.SurveySectionId)
            .HasColumnName("surveySectionId");
        
        builder.Property(e => e.Rang)
            .HasColumnName("rang");
        
        builder.Property(e => e.Name)
            .HasColumnName("name")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(e => e.ExpKey)
            .HasColumnName("expKey")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(e => e.Type)
            .HasColumnName("type")
            .HasMaxLength(50)
            .IsRequired();
        
        builder.Property(e => e.Required)
            .HasColumnName("required");
        
        builder.Property(e => e.TableRef)
            .HasColumnName("tableRef")
            .HasMaxLength(100);
        
        builder.Property(e => e.TableValueColumn)
            .HasColumnName("tableValueColumn")
            .HasMaxLength(100);
        
        builder.Property(e => e.TableLabelColumn)
            .HasColumnName("tableLabelColumn")
            .HasMaxLength(100);
        
        builder.Property(e => e.Default)
            .HasColumnName("default")
            .HasMaxLength(100);
        
        builder.Property(e => e.MinValue)
            .HasColumnName("minValue")
            .HasColumnType("numeric");
        
        builder.Property(e => e.MaxValue)
            .HasColumnName("maxValue")
            .HasColumnType("numeric");
        
        builder.Property(e => e.MinChars)
            .HasColumnName("minChars");
        
        builder.Property(e => e.MaxChars)
            .HasColumnName("maxChars");
        
        builder.Property(e => e.DropDownOptions)
            .HasColumnName("dropDownOptions");
        
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
        builder.HasOne(e => e.SurveyTemplateSection)
            .WithMany(e => e.Questions)
            .HasForeignKey(e => e.SurveySectionId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasMany(e => e.Answers)
            .WithOne(e => e.Question)
            .HasForeignKey(e => e.QuestionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
