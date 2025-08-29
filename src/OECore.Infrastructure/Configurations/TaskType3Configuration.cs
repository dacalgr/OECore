using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TaskType3Configuration : IEntityTypeConfiguration<TaskType3>
{
    public void Configure(EntityTypeBuilder<TaskType3> builder)
    {
        builder.ToTable("tblTaskType3");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.TaskTypeId).HasColumnName("taskTypeId");
        builder.Property(e => e.Name).HasColumnName("name").HasMaxLength(100);
        builder.Property(e => e.Description).HasColumnName("description").HasMaxLength(500);
        builder.Property(e => e.IsActive).HasColumnName("isActive");
        builder.Property(e => e.CreatedDate).HasColumnName("createdDate").HasColumnType("timestamp");
        builder.Property(e => e.ModifiedDate).HasColumnName("modifiedDate").HasColumnType("timestamp");

        // Relationship
        builder.HasOne(e => e.TaskType).WithMany(e => e.TaskType3).HasForeignKey(e => e.TaskTypeId).OnDelete(DeleteBehavior.Restrict);
    }
}
