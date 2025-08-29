using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class SpecialPassenger
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? Firstname { get; set; }
    
    [StringLength(100)]
    public string? Lastname { get; set; }
    
    public string? TdbId { get; set; }
    public DateTime BirthDate { get; set; }
    public long CompanyId { get; set; }
    
    [StringLength(1024)]
    public string? CommentDe { get; set; }
    
    [StringLength(1024)]
    public string? CommentFr { get; set; }
    
    [StringLength(1024)]
    public string? CommentIt { get; set; }
    
    public DateTime ExpirationDate { get; set; }
    public DateTime DtCreation { get; set; }
    public DateTime? DtUpdate { get; set; }
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public Company? Company { get; set; }
}
