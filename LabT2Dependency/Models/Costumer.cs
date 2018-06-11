using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabT2Dependency.Models
{
    public class Costumer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public bool TravelsWithAnimal { get; set; }
        public List<Journey> Journeys { get; set; }
    }
}
