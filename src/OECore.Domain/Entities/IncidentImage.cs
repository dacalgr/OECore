using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class IncidentImage
{
    public int Id { get; set; }
    
    [StringLength(500)]
    public string? ImageName { get; set; }
    
    public string? ImageContent { get; set; }
    public Guid? IncidentId { get; set; }
    public bool IsQuittung { get; set; }

    // Navigation property
    public Incident? Incident { get; set; }
}
