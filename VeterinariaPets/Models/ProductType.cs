using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
