using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zoo.Enums;

namespace Zoo
{
    public class Tiger : Animal
    {
        public double Speed { get; set; }
        public int Striper { get; set; }
        public double NailLength { get; set; }
        public AnimalColor Color { get; set; }
    }
}
