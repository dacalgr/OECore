using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class StationRoute
{
    public int Id { get; set; }
    
    public int StationId { get; set; }
    
    public int RouteId { get; set; }
    
    [StringLength(50)]
    public string? Station { get; set; }
    
    [StringLength(8)]
    public string? Route { get; set; }
}
