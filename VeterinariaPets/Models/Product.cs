using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductXprovider = new HashSet<ProductXprovider>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid? IdproductType { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ProductType IdproductTypeNavigation { get; set; }
        public virtual ICollection<ProductXprovider> ProductXprovider { get; set; }
    }
}
