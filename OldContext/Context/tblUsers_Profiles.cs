namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUsers_Profiles
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int profileId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated { get; set; }

        public virtual tbl_CONFIG_Profiles tbl_CONFIG_Profiles { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
