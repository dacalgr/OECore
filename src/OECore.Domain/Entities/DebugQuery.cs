using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DebugQuery
{
    [Key]
    [StringLength(64)]
    public string Name { get; set; } = string.Empty;
    
    public string? Query { get; set; }
}
