namespace OECore.Domain.Entities;

public class DocboxFavorite
{
    public long UserId { get; set; }
    public int DocumentId { get; set; }
    
    // Navigation properties
    public User? User { get; set; }
    public DocboxDocument? Document { get; set; }
}
