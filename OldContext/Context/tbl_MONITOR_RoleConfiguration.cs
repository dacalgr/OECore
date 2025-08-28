namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_RoleConfiguration")]
    public partial class tbl_MONITOR_RoleConfiguration
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("role")]
        [StringLength(50)]
        public string role { get; set; }

        [Column("jsonConfig")]
        public string jsonConfig { get; set; }

        public DateTime? dtDeleted { get; set; }

        public tbl_MONITOR_RoleConfiguration()
        {
        }

    }
}
