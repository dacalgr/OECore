using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class FormQuestion
{
    public int Id { get; set; }
    
    public int SurveySectionId { get; set; }
    public int? Rang { get; set; }
    
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string ExpKey { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string Type { get; set; } = string.Empty;
    
    public bool Required { get; set; }
    
    [StringLength(100)]
    public string? TableRef { get; set; }
    
    [StringLength(100)]
    public string? TableValueColumn { get; set; }
    
    [StringLength(100)]
    public string? TableLabelColumn { get; set; }
    
    [StringLength(100)]
    public string? Default { get; set; }
    
    public decimal? MinValue { get; set; }
    public decimal? MaxValue { get; set; }
    public int? MinChars { get; set; }
    public int? MaxChars { get; set; }
    
    public string? DropDownOptions { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtModified { get; set; }
    
    // Navigation properties
    public SurveyTemplateSection? SurveyTemplateSection { get; set; }
    public ICollection<FormAnswer> Answers { get; set; } = new List<FormAnswer>();
}
