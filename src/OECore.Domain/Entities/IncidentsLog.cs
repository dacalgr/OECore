using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class IncidentsLog
{
    public int Id { get; set; }
    
    [StringLength(4000)]
    public string? IncidentFields { get; set; }
    
    [StringLength(10)]
    public string? Operation { get; set; }
    
    public Guid? IncidentId { get; set; }
    
    [StringLength(50)]
    public string? IncidentQuitNo { get; set; }
    
    public int? ImagesCount { get; set; }
    
    [StringLength(10)]
    public string? AppVersion { get; set; }
    
    [StringLength(400)]
    public string? DeviceId { get; set; }
    
    [StringLength(50)]
    public string? SqliteVersion { get; set; }
    
    public DateTime Date { get; set; }
    
    [StringLength(50)]
    public string? SqliteLastUpdate { get; set; }
    
    [StringLength(400)]
    public string? Imei { get; set; }

    // Navigation property
    public Incident? Incident { get; set; }
}
