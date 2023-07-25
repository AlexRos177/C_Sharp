using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Helper
    {   
        Random rnd = new Random();
        public int GetRndNumber(int from, int to)
        {
            return rnd.Next(from, to);
        }
        public  double GetRndDouble(double min, double max)
        {
            Random rand = new Random();
            return rand.NextDouble() * (max - min) + min;
        }
        public  bool GetRndBool()
        {
            return GetRndNumber(0, 1) == 0 ? false : true;
        }
    }
}
