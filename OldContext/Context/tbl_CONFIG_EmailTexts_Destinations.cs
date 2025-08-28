namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_CONFIG_EmailTexts_Destinations
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
        
        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }
    }
}
