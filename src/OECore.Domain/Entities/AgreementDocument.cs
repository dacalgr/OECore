using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class AgreementDocument
{
    public int Id { get; set; }
    
    public string TitleDe { get; set; } = string.Empty;
    public string TitleFr { get; set; } = string.Empty;
    public string TitleIt { get; set; } = string.Empty;
    
    public string DescriptionDe { get; set; } = string.Empty;
    public string DescriptionIt { get; set; } = string.Empty;
    public string DescriptionFr { get; set; } = string.Empty;
    
    public string LinkDe { get; set; } = string.Empty;
    public string LinkIt { get; set; } = string.Empty;
    public string LinkFr { get; set; } = string.Empty;
    
    public string DocumentLinkDe { get; set; } = string.Empty;
    public string DocumentLinkIt { get; set; } = string.Empty;
    public string DocumentLinkFr { get; set; } = string.Empty;
    
    public string Question1De { get; set; } = string.Empty;
    public string Question1It { get; set; } = string.Empty;
    public string Question1Fr { get; set; } = string.Empty;
    
    public string Question2De { get; set; } = string.Empty;
    public string Question2It { get; set; } = string.Empty;
    public string Question2Fr { get; set; } = string.Empty;
    
    public string Question3De { get; set; } = string.Empty;
    public string Question3It { get; set; } = string.Empty;
    public string Question3Fr { get; set; } = string.Empty;
    
    public string Answers1De { get; set; } = string.Empty;
    public string Answers1It { get; set; } = string.Empty;
    public string Answers1Fr { get; set; } = string.Empty;
    
    public string Answers2De { get; set; } = string.Empty;
    public string Answers2It { get; set; } = string.Empty;
    public string Answers2Fr { get; set; } = string.Empty;
    
    public string Answers3De { get; set; } = string.Empty;
    public string Answers3It { get; set; } = string.Empty;
    public string Answers3Fr { get; set; } = string.Empty;
    
    public string CorrectAnswer1De { get; set; } = string.Empty;
    public string CorrectAnswer1It { get; set; } = string.Empty;
    public string CorrectAnswer1Fr { get; set; } = string.Empty;
    
    public string CorrectAnswer2De { get; set; } = string.Empty;
    public string CorrectAnswer2It { get; set; } = string.Empty;
    public string CorrectAnswer2Fr { get; set; } = string.Empty;
    
    public string CorrectAnswer3De { get; set; } = string.Empty;
    public string CorrectAnswer3It { get; set; } = string.Empty;
    public string CorrectAnswer3Fr { get; set; } = string.Empty;
    
    public DateTime UpdateTime { get; set; }
    public DateTime? DtDeleted { get; set; }
}
