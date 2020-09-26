using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class City
    {
        public City()
        {
            Client = new HashSet<Client>();
            Providers = new HashSet<Providers>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid IdDepartment { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual Department IdDepartmentNavigation { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Providers> Providers { get; set; }
    }
}
