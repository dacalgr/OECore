using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Currency
{
    public int Id { get; set; }
    
    [StringLength(8)]
    public string? Code { get; set; }
    
    [StringLength(8)]
    public string? CurrencyCode { get; set; }
    
    public float Factor { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
