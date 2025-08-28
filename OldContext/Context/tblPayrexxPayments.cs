namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPayrexxPayments")]
    public partial class tblPayrexxPayments
    {
        //(GUID, TYPE, TransacionId, STATUS, Time)
        public Guid id { get; set; }

        [StringLength(200)]
        public string entityType { get; set; }

        [StringLength(200)]
        public string transactionId { get; set; }
        [StringLength(200)]
        public string status { get; set; }
        [StringLength(200)]
        public string psp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? lastUpdateTime { get; set; }
    }
}
