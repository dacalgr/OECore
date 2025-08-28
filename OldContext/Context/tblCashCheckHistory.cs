namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCashCheckHistory")]
    public partial class tblCashCheckHistory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "datetime2")]
        public DateTime cashCheckDay { get; set; }

        public long? caschCheckDayTicks { get; set; }
    }
}
