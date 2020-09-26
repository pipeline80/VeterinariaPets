using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Department
    {
        public Department()
        {
            City = new HashSet<City>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
