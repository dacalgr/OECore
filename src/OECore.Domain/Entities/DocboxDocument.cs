using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DocboxDocument
{
    public int Id { get; set; }
    
    public int? FolderId { get; set; }
    public int? LangId { get; set; }
    
    [StringLength(4000)]
    public string? Identifier { get; set; }
    
    [StringLength(1000)]
    public string? Name { get; set; }
    
    [StringLength(1000)]
    public string? FileName { get; set; }
    
    [StringLength(4000)]
    public string? UrlDownload { get; set; }
    
    [StringLength(10)]
    public string? Type { get; set; }
    
    [StringLength(4000)]
    public string? Description { get; set; }
    
    public bool? RequestReading { get; set; }
    public long? Size { get; set; }
    public bool? FlagOffline { get; set; }
    public bool? FlagWasOffline { get; set; }
    public bool? FlagWasOnline { get; set; }
    
    public DateTime? ValidFrom { get; set; }
    public DateTime? ValidTo { get; set; }
    public bool? HiddenInList { get; set; }
    public int? CpnsMessage { get; set; }
    
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
    
    [StringLength(50)]
    public string? UserModified { get; set; }
    
    public int Priority { get; set; }
    
    // Navigation properties
    public DocboxFolder? Folder { get; set; }
    public Language? Language { get; set; }
    public ICollection<DocboxDocumentUserRead> DocumentUserReads { get; set; } = new List<DocboxDocumentUserRead>();
    public ICollection<Profile> Profiles { get; set; } = new List<Profile>();
    public ICollection<DocboxFavorite> Favorites { get; set; } = new List<DocboxFavorite>();
}
