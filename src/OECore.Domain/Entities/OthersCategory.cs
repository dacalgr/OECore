using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class OthersCategory
{
    public int Id { get; set; }
    
    public string? TextIt { get; set; }
    
    public string? TextFr { get; set; }
    
    public string? TextDe { get; set; }
    
    public int ParentId { get; set; }
    
    public int CategoryId { get; set; }
    
    public int? Rank { get; set; }
    
    public string? LangRef { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
