namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCompanyMapping")]
    public partial class tblCompanyMapping
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string companyCode { get; set; }

        public int? newCompanyId { get; set; }
    }
}
