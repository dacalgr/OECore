using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DeviceLog
{
    public int Id { get; set; }
    
    [StringLength(128)]
    public string? ZipName { get; set; }
    
    public DateTime? TStamp { get; set; }
    
    public string? Tag { get; set; }
    
    public string? Timestamp { get; set; }
    
    public string? Response { get; set; }
    
    public string? DeviceId { get; set; }
    
    public string? Imei { get; set; }
    
    public string? File { get; set; }
    
    public string? VersionNumber { get; set; }
    
    public string? Version { get; set; }
    
    public string? DateTime { get; set; }
    
    public string? UserId { get; set; }
    
    public string? Mode { get; set; }
    
    public string? Request { get; set; }
    
    public string? IncidentId { get; set; }
    
    public string? StartTime { get; set; }
    
    public string? Log { get; set; }
    
    public string? Error { get; set; }
    
    public string? TaskId { get; set; }
    
    public string? Data { get; set; }
    
    public string? TurnId { get; set; }
    
    public string? StopTime { get; set; }
    
    public string? Json { get; set; }
    
    public string? TaskType { get; set; }
    
    public string? Exception { get; set; }
    
    [StringLength(32)]
    public string? Hash { get; set; }
    
    public string? UpdateBlacklist { get; set; }
    
    public string? Image { get; set; }
    
    public string? Message { get; set; }
}
