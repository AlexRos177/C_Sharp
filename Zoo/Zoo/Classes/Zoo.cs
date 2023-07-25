using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {
        public string ZooName { get; set; }
        public List<Tiger> Tigers { get; set; }
        public List<Eagle> Eagles { get; set; }
        public Shark? Shark { get; set; }
        public string Address { get; set; }
    }
}
