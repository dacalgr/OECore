using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class FormAnswerConfiguration : IEntityTypeConfiguration<FormAnswer>
{
    public void Configure(EntityTypeBuilder<FormAnswer> builder)
    {
        builder.ToTable("tbl_FORMS_Answers");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.QuestionId)
            .HasColumnName("questionId");
        
        builder.Property(e => e.SurveyId)
            .HasColumnName("surveyId");
        
        builder.Property(e => e.Group)
            .HasColumnName("group");
        
        builder.Property(e => e.Value)
            .HasColumnName("value")
            .HasMaxLength(255);
        
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
        builder.HasOne(e => e.Question)
            .WithMany(e => e.Answers)
            .HasForeignKey(e => e.QuestionId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(e => e.Survey)
            .WithMany(e => e.Answers)
            .HasForeignKey(e => e.SurveyId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
