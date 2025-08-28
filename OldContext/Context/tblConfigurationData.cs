namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblConfigurationData")]
    public partial class tblConfigurationData
    {
        [Key]
        [StringLength(64)]
        public string DataKey { get; set; }

        [Column(TypeName = "text")]
        public string DataValue { get; set; }
    }
}
