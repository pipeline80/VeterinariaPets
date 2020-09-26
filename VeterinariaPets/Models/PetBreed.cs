using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class PetBreed
    {
        public PetBreed()
        {
            Pet = new HashSet<Pet>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid IdPetType { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual PetType IdPetTypeNavigation { get; set; }
        public virtual ICollection<Pet> Pet { get; set; }
    }
}
