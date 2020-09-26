using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Users
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public byte[] Password { get; set; }
        public Guid Idrol { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual Rol IdrolNavigation { get; set; }
    }
}
