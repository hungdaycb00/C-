using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Cone : Circle
    {
        protected double Side = 10.2;
        public override double Area()
        {
            return PI * Radius * Side;
        }
    }
}
