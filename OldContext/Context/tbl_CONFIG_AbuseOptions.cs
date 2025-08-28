namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_AbuseOptions
    {
        public tbl_CONFIG_AbuseOptions()
        {
            tbl_CONFIG_ReasonsSubcategories = new HashSet<tbl_CONFIG_ReasonsSubcategories>();
        }

        public int id { get; set; }

        public string text_it { get; set; }

        public string text_de { get; set; }

        public string text_fr { get; set; }

        
        public string warningDE { get; set; }

        
        public string warningFR { get; set; }

        
        public string warningIT { get; set; }

        public int? rank { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }


        public virtual ICollection<tbl_CONFIG_ReasonsSubcategories> tbl_CONFIG_ReasonsSubcategories { get; set; }
    }
}
