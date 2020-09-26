using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Client
    {
        public Client()
        {
            Pet = new HashSet<Pet>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int Genero { get; set; }
        public Guid Idcity { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual City IdcityNavigation { get; set; }
        public virtual ICollection<Pet> Pet { get; set; }
    }
}
