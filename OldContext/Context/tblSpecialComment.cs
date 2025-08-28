using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenEyeBackendEntities
{
    [Table("tblSpecialComment")]
    public partial class tblSpecialComment
    {
        [Key]
        public int Id { get; set; }

        [Column("TDB_Comment_ID")]
        [StringLength(100)]
        public string TDB_Comment_ID { get; set; }

        [Column("commentDE")]
        [StringLength(1024)]
        public string CommentDE { get; set; }

        [Column("commentIT")]
        [StringLength(1024)]
        public string CommentIT { get; set; }

        [Column("CommentFR")]
        [StringLength(1024)]
        public string CommentFR { get; set; }

        [Column("dtCreated", TypeName = "datetime2")]
        public DateTime DtCreated { get; set; }

        [Column("dtUpdated", TypeName = "datetime2")]
        public DateTime? DtUpdated { get; set; }

        [Column("dtDeleted", TypeName = "datetime2")]
        public DateTime? DtDeleted { get; set; }

    }
}