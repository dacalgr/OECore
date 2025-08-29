using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ControlType
{
    public int Id { get; set; }
    
    public string? TextIt { get; set; }
    
    public string? TextDe { get; set; }
    
    public string? TextFr { get; set; }
    
    public int ControlTypeId { get; set; }
    
    public int? Rank { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
