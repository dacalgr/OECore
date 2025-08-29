namespace OECore.Domain.Entities;

public class SurveyTemplateSection
{
    public int Id { get; set; }
    
    public int SurveyId { get; set; }
    public int SectionId { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    
    // Navigation properties
    public SurveyTemplate? SurveyTemplate { get; set; }
    public FormSection? FormSection { get; set; }
    public ICollection<FormQuestion> Questions { get; set; } = new List<FormQuestion>();
}
