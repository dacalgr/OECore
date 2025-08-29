using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class RefundReason
{
    public int Id { get; set; }
    
    [StringLength(512)]
    public string? TextDe { get; set; }
    
    [StringLength(512)]
    public string? TextFr { get; set; }
    
    [StringLength(512)]
    public string? TextIt { get; set; }
    
    [StringLength(512)]
    public string? LangRef { get; set; }
    
    public int? Rank { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
