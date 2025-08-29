using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class FormSection
{
    public int Id { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    
    public bool Required { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtModified { get; set; }
    
    // Navigation properties
    public ICollection<SurveyTemplateSection> SurveyTemplateSections { get; set; } = new List<SurveyTemplateSection>();
}
