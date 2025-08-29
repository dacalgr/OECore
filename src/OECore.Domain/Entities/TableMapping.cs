using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OECore.Domain.Entities;

public class TableMapping
{
    [Key]
    [Column(Order = 0)]
    [StringLength(50)]
    public string SqlServerName { get; set; } = string.Empty;

    [Key]
    [Column(Order = 1)]
    [StringLength(50)]
    public string SqliteName { get; set; } = string.Empty;

    public int Order { get; set; }
}
