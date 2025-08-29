using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class TaskType1
{
    public int Id { get; set; }
    public int? TaskTypeId { get; set; }
    
    [StringLength(100)]
    public string? Name { get; set; }
    
    [StringLength(500)]
    public string? Description { get; set; }
    
    public bool? IsActive { get; set; }
    public DateTime? CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    // Navigation property
    public TaskType? TaskType { get; set; }
}
