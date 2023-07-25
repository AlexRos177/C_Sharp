using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Zoo.Enums;

namespace Zoo
{
    public class Shark :Animal
    {
        public double Length { get; set; }
        public int KillCount { get; set; }
        public int Speed { get; set; }
        public int Dept { get; set; }
        public ShrkBreed ShrkBreed { get; set; }
    }
}
