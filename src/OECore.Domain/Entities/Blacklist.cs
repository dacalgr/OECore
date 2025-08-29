using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Blacklist
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? Name { get; set; }
    
    [StringLength(100)]
    public string? Vorname { get; set; }
    
    public bool? Blacklisted { get; set; }
    
    [StringLength(1024)]
    public string? CommentsDe { get; set; }
    
    [StringLength(1024)]
    public string? CommentsFr { get; set; }
    
    [StringLength(1024)]
    public string? CommentsIt { get; set; }
    
    public long? Birthdate { get; set; }
    public long Created { get; set; }
    public DateTime? ExpirationDate { get; set; }
    
    [StringLength(1014)]
    public string? Comments { get; set; }
    
    public int? FileId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletetAt { get; set; }
    public DateTime? LastImport { get; set; }
}
