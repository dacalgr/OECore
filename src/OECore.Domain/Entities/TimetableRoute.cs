using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TimetableRoute
{
    [Key]
    public string RouteId { get; set; } = string.Empty;
    
    public string? AgencyId { get; set; }
    
    public string? RouteShortName { get; set; }
    
    public string? RouteLongName { get; set; }
    
    public string? RouteDesc { get; set; }
    
    public string? RouteType { get; set; }
    
    public string? RouteUrl { get; set; }
    
    public string? RouteColor { get; set; }
    
    public string? RouteTextColor { get; set; }
    
    // Navigation properties
    public virtual TimetableAgency? Agency { get; set; }
    public virtual ICollection<TimetableTrip> Trips { get; set; } = new List<TimetableTrip>();
}
