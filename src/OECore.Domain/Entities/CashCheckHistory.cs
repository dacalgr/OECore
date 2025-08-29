using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class CashCheckHistory
{
    public int UserId { get; set; }
    public DateTime CashCheckDay { get; set; }
    public long? CaschCheckDayTicks { get; set; }
}
