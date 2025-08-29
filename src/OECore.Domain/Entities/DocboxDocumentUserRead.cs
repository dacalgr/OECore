namespace OECore.Domain.Entities;

public class DocboxDocumentUserRead
{
    public int DocumentId { get; set; }
    public long UserId { get; set; }
    
    public DateTime? VersionDate { get; set; }
    public DateTime? ReadDate { get; set; }
    
    // Navigation properties
    public DocboxDocument? Document { get; set; }
    public User? User { get; set; }
}
