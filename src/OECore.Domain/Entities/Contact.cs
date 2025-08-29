using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Contact
{
    public int Id { get; set; }
    
    [StringLength(4000)]
    public string? Name { get; set; }
    
    [StringLength(4000)]
    public string? LastName { get; set; }
    
    public DateTime? BirthDate { get; set; }
    public DateTime? ActiveFrom { get; set; }
    public DateTime? ActiveTo { get; set; }
    public int? Language { get; set; }
    
    [StringLength(4000)]
    public string? Email { get; set; }
    
    [StringLength(4000)]
    public string? Phone { get; set; }
    
    public DateTime? DtCreated { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtDeleted { get; set; }
    
    [StringLength(500)]
    public string? Department { get; set; }
    
    [StringLength(500)]
    public string? Direction { get; set; }
    
    [StringLength(50)]
    public string? PrivatePhone { get; set; }
    
    [StringLength(50)]
    public string? Fax { get; set; }
    
    [StringLength(100)]
    public string? Section { get; set; }
    
    [StringLength(100)]
    public string? Address { get; set; }
    
    [StringLength(50)]
    public string? Plz { get; set; }
    
    [StringLength(50)]
    public string? City { get; set; }
    
    [StringLength(50)]
    public string? Country { get; set; }
}
