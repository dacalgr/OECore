using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class IncidentTask
{
    public Guid Id { get; set; }
    public DateTime? StartTime { get; set; }
    public Guid? TurnId { get; set; }
    public long? FirmId { get; set; }
    public DateTime? DtModified { get; set; }
    
    [StringLength(20)]
    public string? Type { get; set; }
    
    public int? TeamId { get; set; }
    
    [StringLength(4000)]
    public string? Station { get; set; }
    
    [StringLength(4000)]
    public string? StationsList { get; set; }
    
    public int? ControlTypeId { get; set; }
    
    [StringLength(50)]
    public string? Route { get; set; }
    
    public int? Counter { get; set; }
    
    [StringLength(50)]
    public string? Zone { get; set; }
    
    [StringLength(50)]
    public string? Wagon { get; set; }
    
    public bool? Confirmedline { get; set; }
    
    [StringLength(4000)]
    public string? ConfirmedLineReason { get; set; }
    
    public long? SubcategoryId { get; set; }
    public long? Category { get; set; }
    public Guid? OldTurnId { get; set; }
    public int? Region { get; set; }
    public string? FreeText { get; set; }
    
    [StringLength(300)]
    public string? RegionName { get; set; }
    
    public DateTime? Balanced { get; set; }
    public int? FirmId_ { get; set; }
    public Guid? TurnIdOrig { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public bool? FullControl { get; set; }
    public int? FlightCount { get; set; }
    public int? Aggression { get; set; }
    public DateTime? DtProcessed { get; set; }
    public string? DeviceId { get; set; }

    // Navigation properties
    public Company? Company { get; set; }
    public Turn? Turn { get; set; }
    public ICollection<TaskType> TaskTypes { get; set; } = new List<TaskType>();
    public ICollection<Incident> Incidents { get; set; } = new List<Incident>();
}
