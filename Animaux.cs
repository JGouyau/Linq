using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Animal
    {
        public Guid AnimalId { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Species Species { get; set; }

        public Animal(string espece)
        {
            Species = new Species(espece);
            AnimalId = Guid.NewGuid();
        }
    }

    public class Species
    {
        public Guid SpeciesId { get; set; }
        public String Name { get; set; }
        public Species(string nom)
        {
            Name = nom;
            SpeciesId = Guid.NewGuid();
        }

    }
}
