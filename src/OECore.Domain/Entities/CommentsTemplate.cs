using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class CommentsTemplate
{
    public int Id { get; set; }
    
    [StringLength(8)]
    public string? Code { get; set; }
    
    [StringLength(256)]
    public string? Text { get; set; }
    
    public int? Rank { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
