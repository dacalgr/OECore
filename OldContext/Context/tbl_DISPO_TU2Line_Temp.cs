namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DISPO_TU2Line_Temp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Line_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LineNr_TU { get; set; }

        public virtual tbl_DISPO_LineStats_Temp tbl_DISPO_LineStats_Temp { get; set; }
    }
}
