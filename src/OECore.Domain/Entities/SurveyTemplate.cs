using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class SurveyTemplate
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtModified { get; set; }
    
    // Navigation properties
    public ICollection<Survey> Surveys { get; set; } = new List<Survey>();
    public ICollection<SurveyTemplateCompany> SurveyTemplateCompanies { get; set; } = new List<SurveyTemplateCompany>();
    public ICollection<SurveyTemplateSection> SurveyTemplateSections { get; set; } = new List<SurveyTemplateSection>();
}
