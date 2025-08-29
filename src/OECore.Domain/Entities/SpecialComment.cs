using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class SpecialComment
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string? TdbCommentId { get; set; }
    
    [StringLength(1024)]
    public string? CommentDe { get; set; }
    
    [StringLength(1024)]
    public string? CommentIt { get; set; }
    
    [StringLength(1024)]
    public string? CommentFr { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtUpdated { get; set; }
    public DateTime? DtDeleted { get; set; }
}
