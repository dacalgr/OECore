namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_ticketingProductPrices
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idCategory { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string productName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idProduct { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string productDetail { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idClass { get; set; }

        [Key]
        [Column("class", Order = 5)]
        [StringLength(50)]
        public string _class { get; set; }

        [Key]
        [Column(Order = 6)]
        public double price { get; set; }

        [Key]
        [Column(Order = 7)]
        public double halfPrice { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(255)]
        public string fqCodePrice { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(255)]
        public string fqCodeHalfPrice { get; set; }

        public DateTime? dtDeleted { get; set; }
    }
}
