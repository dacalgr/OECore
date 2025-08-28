namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_balanceHistory
    {
        public long id { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime balanceDay { get; set; }

        public long? balanceDayTicks { get; set; }
    }
}
