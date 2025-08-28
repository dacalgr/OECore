namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBalanceHistory")]
    public partial class tblBalanceHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime balanceDay { get; set; }

        public long? balanceDayTicks { get; set; }

        [StringLength(100)]
        public string deviceId { get; set; }
    }
}
