using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class ProductXprovider
    {
        public int Idprovider { get; set; }
        public Guid Idproduct { get; set; }
        public double LastPrice { get; set; }
        public int LastDiscount { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual Product IdproductNavigation { get; set; }
        public virtual Providers IdproviderNavigation { get; set; }
    }
}
