using System;
using System.Collections.Generic;

namespace VeterinariaPets.Models
{
    public partial class Pet
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid Idbreed { get; set; }
        public string Color { get; set; }
        public int IdClient { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateBy { get; set; }

        public virtual Client IdClientNavigation { get; set; }
        public virtual PetBreed IdbreedNavigation { get; set; }
    }
}
