namespace OECore.Domain.Entities;

public class SurveyTemplateCompany
{
    public int TemplateId { get; set; }
    public long CompanyId { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public SurveyTemplate? SurveyTemplate { get; set; }
    public Company? Company { get; set; }
}
