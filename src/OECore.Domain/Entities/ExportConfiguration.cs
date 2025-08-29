using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ExportConfiguration
{
    public int Id { get; set; }
    
    [StringLength(64)]
    public string? Domain { get; set; }
    
    [StringLength(32)]
    public string? Task { get; set; }
    
    [StringLength(32)]
    public string? TaskTest { get; set; }
    
    [StringLength(32)]
    public string? Incident { get; set; }
    
    [StringLength(32)]
    public string? IncidentTest { get; set; }
    
    [StringLength(32)]
    public string? Picture { get; set; }
    
    [StringLength(32)]
    public string? PictureTest { get; set; }
    
    [StringLength(32)]
    public string? Quittung { get; set; }
    
    [StringLength(32)]
    public string? QuittungTest { get; set; }
    
    [StringLength(32)]
    public string? Ticketsales { get; set; }
    
    [StringLength(32)]
    public string? TicketsalesTest { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    [StringLength(32)]
    public string? Forms { get; set; }
    
    [StringLength(32)]
    public string? FormsTest { get; set; }
    
    [StringLength(32)]
    public string? Users { get; set; }
    
    [StringLength(32)]
    public string? UsersTest { get; set; }
    
    public bool IncidentApiEnabled { get; set; } = false;
    public bool TaskApiEnabled { get; set; } = false;
    public bool TicketApiEnabled { get; set; } = false;
    
    public DateTime? IncidentsLastExport { get; set; }
    public DateTime? IncidentsNextExport { get; set; }
    public int IncidentsMinClosedTime { get; set; }
    public DateTime IncidentsStartExport { get; set; }
    public DateTime IncidentsEndExport { get; set; }
}
