using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableStopTime
{
    public int Id { get; set; }
    
    public string? TripId { get; set; }
    
    public string? ArrivalTime { get; set; }
    
    public string? DepartureTime { get; set; }
    
    public string? StopId { get; set; }
    
    public string? StopSequence { get; set; }
    
    public string? StopHeadsign { get; set; }
    
    public string? PickupType { get; set; }
    
    public string? DropOffType { get; set; }
    
    public string? ShapeDistTraveled { get; set; }
    
    public string? Timepoint { get; set; }
    
    // Navigation properties
    public virtual TimetableStop? Stop { get; set; }
    public virtual TimetableTrip? Trip { get; set; }
}
