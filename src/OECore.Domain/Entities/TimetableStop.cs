using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableStop
{
    [Key]
    public string StopId { get; set; } = string.Empty;
    
    public string? StopCode { get; set; }
    
    public string? StopName { get; set; }
    
    public string? StopDesc { get; set; }
    
    public string? StopLat { get; set; }
    
    public string? StopLon { get; set; }
    
    public string? ZoneId { get; set; }
    
    public string? StopUrl { get; set; }
    
    public string? LocationType { get; set; }
    
    public string? ParentStation { get; set; }
    
    public string? StopTimezone { get; set; }
    
    public string? WheelchairBoarding { get; set; }
    
    public string? LevelId { get; set; }
    
    public string? PlatformCode { get; set; }
    
    // Navigation property
    public virtual ICollection<TimetableStopTime> StopTimes { get; set; } = new List<TimetableStopTime>();
}
