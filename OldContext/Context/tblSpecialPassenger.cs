using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenEyeBackendEntities
{
    [Table("tblSpecialPassenger")]
    public partial class tblSpecialPassenger
    {
        [Key]
        public int Id { get; set; }

        [Column("firstname")]
        [StringLength(100)]
        public string Firstname { get; set; }

        [Column("lastname")]
        [StringLength(100)]
        public string Lastname { get; set; }

        [Column("TDB_Id")]
        public string TDB_Id { get; set; }

        [Column("birthDate", TypeName = "datetime2")]
        public DateTime BirthDate { get; set; }

        [Column("CompanyId")]
        public int CompanyId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual tbl_CONFIG_Companies Company { get; set; }

        [Column("commentDE")]
        [StringLength(1024)]
        public string CommentDE { get; set; }

        [Column("commentFR")]
        [StringLength(1024)]
        public string CommentFR { get; set; }

        [Column("commentIT")]
        [StringLength(1024)]
        public string CommentIT { get; set; }

        [Column("expirationDate", TypeName = "datetime2")]
        public DateTime ExpirationDate { get; set; }

        [Column("dtCreation", TypeName = "datetime2")]
        public DateTime DtCreation { get; set; }

        [Column("dtUpdate", TypeName = "datetime2")]
        public DateTime? DtUpdate { get; set; }

        [Column("dtDeleted", TypeName = "datetime2")]
        public DateTime? DtDeleted { get; set; }

        //[ForeignKey("CompanyId")]
        //public virtual tblCompany Company { get; set; }

    }
}