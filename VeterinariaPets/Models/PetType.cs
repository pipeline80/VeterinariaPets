using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class PetType
    {
        public PetType()
        {
            PetBreed = new HashSet<PetBreed>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual ICollection<PetBreed> PetBreed { get; set; }
    }
}
