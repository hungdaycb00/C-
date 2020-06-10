using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
     class Area 
    {
        public Area() { }
        public int CalculateArea(int len, int wide)
        {
            return len * wide;
        }
        public double CalculateArea(double valOne, double valTwo)
        {
            return 0.5 * valOne * valTwo;
        }
    }
}
