using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableTrip
{
    [Key]
    public string TripId { get; set; } = string.Empty;
    
    public string? RouteId { get; set; }
    
    public string? ServiceId { get; set; }
    
    public string? TripHeadsign { get; set; }
    
    public string? TripShortName { get; set; }
    
    public string? DirectionId { get; set; }
    
    public string? BlockId { get; set; }
    
    public string? ShapeId { get; set; }
    
    public string? WheelchairAccessible { get; set; }
    
    public string? BikesAllowed { get; set; }
    
    // Navigation properties
    public virtual TimetableRoute? Route { get; set; }
    public virtual TimetableCalendar? Service { get; set; }
    public virtual ICollection<TimetableStopTime> StopTimes { get; set; } = new List<TimetableStopTime>();
}
