namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DOCBOX_Favorites
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("tblUser")]
        public int userId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ForeignKey("tbl_DOCBOX_Document")]
        public int documentId { get; set; }

        public virtual tbl_DOCBOX_Documents tbl_DOCBOX_Document { get; set; }

        public virtual tblUser tblUser { get; set; }
    }
}
