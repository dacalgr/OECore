using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class TaskTypeConfiguration : IEntityTypeConfiguration<TaskType>
{
    public void Configure(EntityTypeBuilder<TaskType> builder)
    {
        builder.ToTable("tblTaskType");
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.TaskId).HasColumnName("taskId");
        builder.Property(e => e.Name).HasColumnName("name").HasMaxLength(50);
        builder.Property(e => e.Description).HasColumnName("description").HasMaxLength(50);
        builder.Property(e => e.IsActive).HasColumnName("isActive");
        builder.Property(e => e.CreatedDate).HasColumnName("createdDate").HasColumnType("timestamp");
        builder.Property(e => e.ModifiedDate).HasColumnName("modifiedDate").HasColumnType("timestamp");

        // Relationships
        builder.HasOne(e => e.IncidentTask).WithMany(e => e.TaskTypes).HasForeignKey(e => e.TaskId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(e => e.TaskType1).WithOne(e => e.TaskType).HasForeignKey(e => e.TaskTypeId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(e => e.TaskType3).WithOne(e => e.TaskType).HasForeignKey(e => e.TaskTypeId).OnDelete(DeleteBehavior.Cascade);
    }
}
