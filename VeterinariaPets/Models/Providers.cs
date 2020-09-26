using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Providers
    {
        public Providers()
        {
            ProductXprovider = new HashSet<ProductXprovider>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public Guid IdCity { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<ProductXprovider> ProductXprovider { get; set; }
    }
}
