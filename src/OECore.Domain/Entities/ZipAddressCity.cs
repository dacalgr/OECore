using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class ZipAddressCity
{
    public int Id { get; set; }
    
    [StringLength(1000)]
    public string? Address { get; set; }
    
    [StringLength(20)]
    public string? Zip { get; set; }
    
    [StringLength(200)]
    public string? City { get; set; }
    
    [StringLength(20)]
    public string? CountryCode { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    public DateTime? DtLastSqliteImport { get; set; }
}
