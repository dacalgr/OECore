using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class FormAnswer
{
    public Guid Id { get; set; }
    
    public int QuestionId { get; set; }
    public Guid SurveyId { get; set; }
    public Guid? Group { get; set; }
    
    [StringLength(255)]
    public string? Value { get; set; }
    
    public DateTime DtCreated { get; set; }
    public DateTime? DtDeleted { get; set; }
    public DateTime? DtModified { get; set; }
    
    // Navigation properties
    public FormQuestion? Question { get; set; }
    public Survey? Survey { get; set; }
}
