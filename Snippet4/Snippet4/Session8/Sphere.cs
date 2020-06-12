using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Sphere: Circle
    {
        double areaOfSphere;
        public override void Area()
        {
            base.Area();
            areaOfSphere = (AreaOfCircle * 4);
        }

        public void Main9()
        {
            Sphere objSphere = new Sphere();
            objSphere.Radius = 7;
            objSphere.Area();
            Console.WriteLine("Area of sphere: {0:F2}", objSphere.areaOfSphere);
        }
    }
}
