using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ReasonCategory
{
    public int Id { get; set; }
    
    [Required(AllowEmptyStrings = true)]
    public string TextIt { get; set; } = string.Empty;
    
    [Required(AllowEmptyStrings = true)]
    public string TextDe { get; set; } = string.Empty;
    
    [Required(AllowEmptyStrings = true)]
    public string TextFr { get; set; } = string.Empty;
    
    [Required(AllowEmptyStrings = true)]
    public string TextEn { get; set; } = string.Empty;
    
    public int CategoryId { get; set; }
    
    public int? CompanyId { get; set; }
    
    public int? Rank { get; set; }
    
    public bool IsAbuse { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
