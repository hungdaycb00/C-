using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    public delegate double CalculateArea(double val);
    public delegate double CalculateVolume(double val);
    class Cube
    {
        public static double Area(double val)
        {
            return 6 * (val * val);
        }
      public static double Volume(double val)
        {
            return (val * val);
        }
    }
}
