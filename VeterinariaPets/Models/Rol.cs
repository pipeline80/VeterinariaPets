using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Users = new HashSet<Users>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
