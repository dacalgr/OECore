using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ConfirmationOfPersonalDetailsOption
{
    public int Id { get; set; }
    
    public string? TextIt { get; set; }
    
    public string? TextDe { get; set; }
    
    public string? TextFr { get; set; }
    
    public int? Rank { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtCreated { get; set; }
    
    public DateTime? DtModified { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
