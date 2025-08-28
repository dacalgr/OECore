using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEyeBackendEntities.Context
{
    public partial class tbl_NOVA_ProductData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_NOVA_ProductData()
        {

        }

        public int id { get; set; }


        public string Verbund { get; set; }


        public string productNumber { get; set; }
        public string defaultText { get; set; }
        public string deText { get; set; }
        public string frText { get; set; }
        public string itText { get; set; }
        public string enText { get; set; }
        public string displayGroup { get; set; }

        public string templateId { get; set; }

        public bool isProductBasedPurchase { get; set; }

        public virtual ICollection<tbl_CONFIG_Companies_NOVA_ProductData> CompanyProducts { get; set; }
    }
}
