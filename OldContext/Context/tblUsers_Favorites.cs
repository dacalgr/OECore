namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUsers_Favorites
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        public string info { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
