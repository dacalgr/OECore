namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_Task")]
    public abstract class tbl_MONITOR_Task
    {
        [Key]
        public int id { get; set; }

        [StringLength(4000)]
        public string message { get; set; }

        [ForeignKey("tblUser")]
        public int userId {  get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCompleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtRejected { get; set; }

        public tblUser tblUser { get; set; }
    }
}
