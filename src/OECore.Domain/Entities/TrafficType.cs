using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TrafficType
{
    public int Id { get; set; }
    
    [Required(AllowEmptyStrings = true)]
    [StringLength(500)]
    public string Name { get; set; } = string.Empty;
    
    public DateTime? DtCreated { get; set; }
    
    public DateTime? DtModified { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
