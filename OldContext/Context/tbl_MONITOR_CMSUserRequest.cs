namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_MONITOR_CMSUserRequest")]
    public partial class tbl_MONITOR_CMSUserRequest
    {
        public int id { get; set; }

        [StringLength(4000)]
        public string message { get; set; }

        public int userId { get; set; }

        [StringLength(500)]
        public string password { get; set; }

        [StringLength(20)]
        public string role { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? validationDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        public int? validationUserId { get; set; }

        [StringLength(30)]
        public string action { get; set; }

        [StringLength(30)]
        public string validationResult { get; set; }

        public int requestUserId { get; set; }

        public int wpPUserId { get; set; }

        public virtual tblUser user { get; set; }
        public virtual tblUser validationUser { get; set; }
        public virtual tblUser requestUser { get; set; }
    }
}
