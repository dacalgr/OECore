namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblOnlinePaymentsStatus
    {
        public int id { get; set; }

        [StringLength(150)]
        public string referenceId { get; set; }

        [StringLength(100)]
        public string entityId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? paymentDate { get; set; }

        [StringLength(100)]
        public string entityType { get; set; }

        [StringLength(100)]
        public string status { get; set; }
        [StringLength(250)]
        public string transactionId { get; set; }
    }
}
