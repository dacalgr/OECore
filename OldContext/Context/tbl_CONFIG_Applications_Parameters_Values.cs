namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Applications_Parameters_Values
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int applicationId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parameterId { get; set; }

        public string valueEn { get; set; }

        public string valueDe { get; set; }

        public string valueFr { get; set; }

        public string valueIt { get; set; }

        public virtual tbl_CONFIG_Applications tbl_CONFIG_Applications { get; set; }

        public virtual tbl_CONFIG_Parameters tbl_CONFIG_Parameters { get; set; }
    }
}
