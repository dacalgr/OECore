using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class EmailText
{
    public int Id { get; set; }
    
    public int DestinationId { get; set; }
    
    [StringLength(4000)]
    public string? Subject { get; set; }
    
    [StringLength(4000)]
    public string? Body { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation property
    public virtual EmailTextDestination? Destination { get; set; }
}
