namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_sold_tickets
    {
        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(4000)]
        public string employeeName { get; set; }

        [StringLength(4000)]
        public string employeeLastName { get; set; }

        public Guid id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int productID { get; set; }

        [StringLength(512)]
        public string company { get; set; }

        [StringLength(50)]
        public string product { get; set; }

        [StringLength(50)]
        public string freeText { get; set; }

        [StringLength(1024)]
        public string deletedReason { get; set; }

        [Column("class")]
        [StringLength(8)]
        public string @class { get; set; }

        [StringLength(50)]
        public string details { get; set; }

        [StringLength(50)]
        public string region { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? timeStamp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? uploaded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exported { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? balanced { get; set; }

        public int? printMode { get; set; }

        [StringLength(16)]
        public string deviceImei { get; set; }

        [StringLength(12)]
        public string laufnummer { get; set; }

        [StringLength(50)]
        public string belegId { get; set; }

        [StringLength(50)]
        public string kundennummer { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string birthdate { get; set; }

        [StringLength(50)]
        public string currency { get; set; }

        [StringLength(50)]
        public string baseCardNumber { get; set; }

        public int? classId { get; set; }

        public int? regionID { get; set; }

        public int? payment { get; set; }

        public double? currencyRate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exported_ { get; set; }

        public double? amount { get; set; }

        [StringLength(50)]
        public string responsible_DE { get; set; }

        [StringLength(50)]
        public string articleNumber { get; set; }

        public double? quittungPrice { get; set; }
    }
}
