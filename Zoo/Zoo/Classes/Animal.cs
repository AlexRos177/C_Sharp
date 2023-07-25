using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zoo.Enums;

namespace Zoo
{
    public class Animal
    {
        public int Weight { get; set; }
        public Sex Sex { get; set; }
        public Enhabitat Enhabitat { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public AnimalType AnimalType { get; set; }
        public int CrateSize { get; set; }
    }
}
