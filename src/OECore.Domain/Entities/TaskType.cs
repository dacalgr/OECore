using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TaskType
{
    public int Id { get; set; }
    public Guid? TaskId { get; set; }
    
    [StringLength(50)]
    public string? Name { get; set; }
    
    [StringLength(50)]
    public string? Description { get; set; }
    
    public bool? IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    // Navigation properties
    public IncidentTask? IncidentTask { get; set; }
    public ICollection<TaskType1> TaskType1 { get; set; } = new List<TaskType1>();
    public ICollection<TaskType3> TaskType3 { get; set; } = new List<TaskType3>();
}
