using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DeviceContact
{
    public int Id { get; set; }
    
    [StringLength(4000)]
    public string? Name { get; set; }
    
    [StringLength(4000)]
    public string? LastName { get; set; }
    
    [StringLength(4000)]
    public string? EmailList { get; set; }
    
    [StringLength(4000)]
    public string? Phone { get; set; }
    
    [StringLength(50)]
    public string? Phone2 { get; set; }
    
    public DateTime? DtCreated { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtDeleted { get; set; }
    
    [StringLength(500)]
    public string? Website { get; set; }
    
    [StringLength(500)]
    public string? Street { get; set; }
    
    [StringLength(50)]
    public string? Plz { get; set; }
    
    [StringLength(50)]
    public string? HouseNumber { get; set; }
    
    [StringLength(500)]
    public string? City { get; set; }
    
    [StringLength(50)]
    public string? Country { get; set; }
    
    [StringLength(500)]
    public string? Firma { get; set; }
}
