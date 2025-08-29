using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class CardType
{
    public int Id { get; set; }
    public string? TextIt { get; set; }
    
    [StringLength(8)]
    public string? Code { get; set; }
    
    public string? TextFr { get; set; }
    public string? TextDe { get; set; }
    public string? TextEn { get; set; }
    
    public int ParentId { get; set; }
    public int? CardTypeId { get; set; }
    public bool Zemis { get; set; }
    public string? CompanyId { get; set; }
    public int? Rank { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtLastSqliteImport { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtCreated { get; set; }
}
