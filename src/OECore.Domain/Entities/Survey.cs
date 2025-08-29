using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class Survey
{
    public Guid Id { get; set; }
    
    public int TemplateId { get; set; }
    public long UserId { get; set; }
    public long CompanyId { get; set; }
    public long RegionId { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtClosed { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtUploaded { get; set; }
    public DateTime? DtModified { get; set; }
    public DateTime? DtExported { get; set; }
    public DateTime? DtBalanced { get; set; }
    
    public bool Sync { get; set; }
    
    // Navigation properties
    public SurveyTemplate? SurveyTemplate { get; set; }
    public User? User { get; set; }
    public Company? Company { get; set; }
    public Region? Region { get; set; }
    public ICollection<FormAnswer> Answers { get; set; } = new List<FormAnswer>();
}
