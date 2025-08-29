using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class FirstName
{
    public int Id { get; set; }
    
    [StringLength(16)]
    public string? Gender { get; set; }
    
    [Required(AllowEmptyStrings = true)]
    [StringLength(32)]
    public string Name { get; set; } = string.Empty;
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
