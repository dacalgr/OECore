using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Turn
{
    public Guid Id { get; set; }
    public DateTime? StartTime { get; set; }
    public long? UserId { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? StopTime { get; set; }
    public DateTime? ExportTime { get; set; }
    
    [StringLength(4000)]
    public string? Notes { get; set; }
    
    public DateTime? OldStartTime { get; set; }
    public DateTime? OldStopTime { get; set; }
    public DateTime? Balanced { get; set; }
    public DateTime? StopTime_ { get; set; }
    public DateTime? TurnStopOrig { get; set; }
    public DateTime? TurnStartOrig { get; set; }
    public bool? IsDisabled { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }

    // Navigation properties
    public User? User { get; set; }
    public ICollection<IncidentTask> IncidentTasks { get; set; } = new List<IncidentTask>();
    public ICollection<Incident> Incidents { get; set; } = new List<Incident>();
}
