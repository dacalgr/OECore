using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEyeBackendEntities.Context
{
    public class tbl_CONFIG_Companies_NOVA_ProductData
    {
        [Key]
        public int Id { get; set; }

        [Column(Order = 0)]
        public int CompanyId { get; set; }

        [Column(Order = 1)]
        public int ProductDataId { get; set; }

        [ForeignKey("CompanyId")]
        public virtual tbl_CONFIG_Companies Company { get; set; }

        [ForeignKey("ProductDataId")]
        public virtual tbl_NOVA_ProductData ProductData { get; set; }
    }
}
