namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_DispoStats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_DispoStats()
        {
            tbl_CONFIG_Profiles = new HashSet<tbl_CONFIG_Profiles>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(8)]
        public string lineNr { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string destination { get; set; }

        public int agencyId { get; set; }

        [StringLength(256)]
        public string agencyName { get; set; }

        [StringLength(256)]
        public string bemerkung { get; set; }

        [StringLength(64)]
        public string update { get; set; }

        [StringLength(8)]
        public string tuKurzel { get; set; }

        public long? einsteigerProJahr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr0000 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr0600 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr0900 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr1300 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr1600 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? moFr1900 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? saSo0000 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? saSo0600 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? saSo1300 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? saSo1900 { get; set; }

        public int moFr0000_relevanzZeitabschnitt { get; set; }

        public int moFr0600_relevanzZeitabschnitt { get; set; }

        public int moFr0900_relevanzZeitabschnitt { get; set; }

        public int moFr1300_relevanzZeitabschnitt { get; set; }

        public int moFr1600_relevanzZeitabschnitt { get; set; }

        public int moFr1900_relevanzZeitabschnitt { get; set; }

        public int saSo0000_relevanzZeitabschnitt { get; set; }

        public int saSo0600_relevanzZeitabschnitt { get; set; }

        public int saSo1300_relevanzZeitabschnitt { get; set; }

        public int saSo1900_relevanzZeitabschnitt { get; set; }

        public int relevanzJahr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal gewichtungKgZuSq { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime kontrolStart { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }
    }
}
