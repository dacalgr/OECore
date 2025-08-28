namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_TICKETING_ProductPrices
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProduct { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClass { get; set; }

        public double price { get; set; }

        public double halfPrice { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string fqCodePrice { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public string fqCodeHalfPrice { get; set; }

        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        public virtual tbl_TICKETING_Classes tbl_TICKETING_Classes { get; set; }

        public virtual tbl_TICKETING_Products tbl_TICKETING_Products { get; set; }
    }
}
