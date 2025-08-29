using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OECore.Domain.Entities;

namespace OECore.Infrastructure.Configurations;

public class DeviceLogConfiguration : IEntityTypeConfiguration<DeviceLog>
{
    public void Configure(EntityTypeBuilder<DeviceLog> builder)
    {
        builder.ToTable("tbl_DEVICE_LOGS_DeviceLogs");
        
        builder.HasKey(e => e.Id);
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
            
        builder.Property(e => e.ZipName)
            .HasColumnName("zipName")
            .HasMaxLength(128);
            
        builder.Property(e => e.TStamp)
            .HasColumnName("tStamp");
            
        builder.Property(e => e.Tag)
            .HasColumnName("tag");
            
        builder.Property(e => e.Timestamp)
            .HasColumnName("timestamp");
            
        builder.Property(e => e.Response)
            .HasColumnName("response");
            
        builder.Property(e => e.DeviceId)
            .HasColumnName("deviceid");
            
        builder.Property(e => e.Imei)
            .HasColumnName("imei");
            
        builder.Property(e => e.File)
            .HasColumnName("file");
            
        builder.Property(e => e.VersionNumber)
            .HasColumnName("versionnumber");
            
        builder.Property(e => e.Version)
            .HasColumnName("version");
            
        builder.Property(e => e.DateTime)
            .HasColumnName("datetime");
            
        builder.Property(e => e.UserId)
            .HasColumnName("userid");
            
        builder.Property(e => e.Mode)
            .HasColumnName("mode");
            
        builder.Property(e => e.Request)
            .HasColumnName("request");
            
        builder.Property(e => e.IncidentId)
            .HasColumnName("incidentid");
            
        builder.Property(e => e.StartTime)
            .HasColumnName("starttime");
            
        builder.Property(e => e.Log)
            .HasColumnName("log");
            
        builder.Property(e => e.Error)
            .HasColumnName("error");
            
        builder.Property(e => e.TaskId)
            .HasColumnName("taskid");
            
        builder.Property(e => e.Data)
            .HasColumnName("data");
            
        builder.Property(e => e.TurnId)
            .HasColumnName("turnid");
            
        builder.Property(e => e.StopTime)
            .HasColumnName("stoptime");
            
        builder.Property(e => e.Json)
            .HasColumnName("json");
            
        builder.Property(e => e.TaskType)
            .HasColumnName("tasktype");
            
        builder.Property(e => e.Exception)
            .HasColumnName("exception");
            
        builder.Property(e => e.Hash)
            .HasColumnName("hash")
            .HasMaxLength(32);
            
        builder.Property(e => e.UpdateBlacklist)
            .HasColumnName("updateblacklist");
            
        builder.Property(e => e.Image)
            .HasColumnName("image");
            
        builder.Property(e => e.Message)
            .HasColumnName("message");
    }
}
