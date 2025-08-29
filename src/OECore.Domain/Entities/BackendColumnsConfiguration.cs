using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BackendColumnsConfiguration
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? UserId { get; set; }
    
    [StringLength(100)]
    public string? TableName { get; set; }
    
    [StringLength(4000)]
    public string? VisibleColumns { get; set; }
}
