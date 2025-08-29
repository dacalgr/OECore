using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DocboxFolder
{
    public int Id { get; set; }
    
    public int? ParentId { get; set; }
    
    [StringLength(500)]
    public string? Name { get; set; }
    
    [StringLength(1000)]
    public string? VirtualPath { get; set; }
    
    [StringLength(100)]
    public string? Hierarchy { get; set; }
    
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public DocboxFolder? Parent { get; set; }
    public ICollection<DocboxDocument> Documents { get; set; } = new List<DocboxDocument>();
    public ICollection<DocboxFolder> Children { get; set; } = new List<DocboxFolder>();
    public ICollection<Profile> Profiles { get; set; } = new List<Profile>();
    public ICollection<Company> CompaniesWrite { get; set; } = new List<Company>();
}
