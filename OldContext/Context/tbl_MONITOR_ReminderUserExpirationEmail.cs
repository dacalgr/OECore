namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_ReminderUserExpirationEmail")]
    public partial class tbl_MONITOR_ReminderUserExpirationEmail
    {
        [Key]
        public int id { get; set; }

        public int type { get; set; }

        public int userCount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }
    }
}
