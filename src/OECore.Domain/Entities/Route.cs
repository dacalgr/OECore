using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Route
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? Name { get; set; }
    
    [StringLength(64)]
    public string? Destination { get; set; }
    
    public int? FColor { get; set; }
    
    public int? BColor { get; set; }
    
    public int? AgencyId { get; set; }
    
    public int? Vehicle { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
    
    [StringLength(100)]
    public string? Bemerkung { get; set; }
    
    [StringLength(200)]
    public string? Update { get; set; }
    
    [StringLength(50)]
    public string? GlueName { get; set; }
    
    [StringLength(50)]
    public string? GlueDestination { get; set; }
    
    public DateTime? DtSharepointImport { get; set; }
    
    [StringLength(100)]
    public string? AgencyName { get; set; }
}
