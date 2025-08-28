namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_UserConfiguration")]
    public partial class tbl_MONITOR_UserConfiguration
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("userId")]
        public int userId { get; set; }

        [Column("jsonConfig")]
        public string jsonConfig { get; set; }

        public DateTime? dtDeleted { get; set; }

        public tbl_MONITOR_UserConfiguration()
        {
        }

    }
}
