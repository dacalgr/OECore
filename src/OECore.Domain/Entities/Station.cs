using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Station
{
    public int Id { get; set; }
    
    public float Didok { get; set; }
    
    public int? DidokLong { get; set; }
    
    [StringLength(512)]
    public string? Name { get; set; }
    
    [StringLength(512)]
    public string? Ort { get; set; }
    
    [StringLength(50)]
    public string? SystemName { get; set; }
    
    public float? Lat { get; set; }
    
    public float? Lng { get; set; }
    
    public decimal? StraaId { get; set; }
    
    [StringLength(512)]
    public string? Zone { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
    
    [StringLength(50)]
    public string? KantonsKurzel { get; set; }
    
    [StringLength(100)]
    public string? Bemerkung { get; set; }
    
    [StringLength(200)]
    public string? Update { get; set; }
    
    public DateTime? DtSharepointImport { get; set; }
}
