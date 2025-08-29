using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class BlackListFile
{
    public int Id { get; set; }
    
    [StringLength(255)]
    public string FileName { get; set; } = string.Empty;
    
    public bool Blacklist { get; set; }
    
    [StringLength(5)]
    public string Language { get; set; } = string.Empty;
    
    [StringLength(100)]
    public string? SftpHost { get; set; }
    
    [StringLength(50)]
    public string? SftpUser { get; set; }
    
    [StringLength(50)]
    public string? SftpPwd { get; set; }
    
    public DateTime? LastUpdate { get; set; }
    public DateTime? DtDeleted { get; set; }
    public bool? Parsed { get; set; }
}
