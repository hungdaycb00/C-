using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Dimension
    {
        double length;
        double breadth;

        public double Area(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            return length * breadth;
        }
    }
}
