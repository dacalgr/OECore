namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DOCBOX_DocumentsUsersRead
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int documentId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? versionDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? readDate { get; set; }

        public virtual tbl_DOCBOX_Documents tbl_DOCBOX_Documents { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
