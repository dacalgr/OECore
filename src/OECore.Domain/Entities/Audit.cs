using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Audit
{
    public long Id { get; set; }
    public string? Message { get; set; }
    
    [StringLength(50)]
    public string? Method { get; set; }
    
    [StringLength(50)]
    public string? Category { get; set; }
    
    [StringLength(15)]
    public string? SqliteVersion { get; set; }
    
    [StringLength(100)]
    public string? FreeField1 { get; set; }
    
    public DateTime? CreatedAt { get; set; }
}
