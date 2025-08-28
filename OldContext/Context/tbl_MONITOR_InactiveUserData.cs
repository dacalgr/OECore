namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_InactiveUserData")]
    public partial class tbl_MONITOR_InactiveUserData
    {
        [Key]
        public int userId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime hideUntil { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [ForeignKey("userId")]
        public virtual tblUser user { get; set; }
    }
}
