using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ControlType
{
    public int Id { get; set; }
    
    [StringLength(4000)]
    public string? NameDe { get; set; }
    
    [StringLength(4000)]
    public string? NameFr { get; set; }
    
    [StringLength(4000)]
    public string? NameIt { get; set; }
    
    public DateTime? DtCreated { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtDeleted { get; set; }
}
