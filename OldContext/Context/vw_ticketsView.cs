namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ticketsView
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userID { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(12)]
        public string laufnummer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? timeStamp { get; set; }

        [StringLength(50)]
        public string company { get; set; }

        [StringLength(100)]
        public string region { get; set; }

        [StringLength(50)]
        public string responsible_DE { get; set; }

        [StringLength(50)]
        public string product { get; set; }

        [StringLength(50)]
        public string details { get; set; }

        [StringLength(50)]
        public string freeText { get; set; }

        [StringLength(50)]
        public string articleNumber { get; set; }

        [StringLength(50)]
        public string billId_DE { get; set; }

        [StringLength(50)]
        public string belegId { get; set; }

        public bool? baseCard { get; set; }

        [StringLength(50)]
        public string baseCardNumber { get; set; }

        [StringLength(50)]
        public string kundennummer { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string birthdate { get; set; }

        public int? class1Type0Number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? class1Type0Price { get; set; }

        public int? class1Type1Number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? class1Type1Price { get; set; }

        public int? class2Type0Number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? class2Type0Price { get; set; }

        public int? class2Type1Number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? class2Type1Price { get; set; }

        public int? type2Number { get; set; }

        public int? type3Number { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? amount { get; set; }

        public decimal? mwst { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted { get; set; }

        [StringLength(1024)]
        public string deletedReason { get; set; }

        public Guid id { get; set; }

        [StringLength(16)]
        public string deviceImei { get; set; }

        [StringLength(50)]
        public string currency { get; set; }

        public float? currencyRate { get; set; }

        public int? payment { get; set; }

        [Column("class")]
        [StringLength(8)]
        public string @class { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyID { get; set; }

        [StringLength(50)]
        public string reference { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? uploaded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exported { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? balanced { get; set; }

        [StringLength(512)]
        public string companyName { get; set; }

        [StringLength(50)]
        public string regionName { get; set; }

        [NotMapped]
        public decimal? quittungPrice { get; set; }
        [NotMapped]
        public int? hasQuittung { get; set; }
    }
}
