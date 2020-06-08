using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Rectangle
    {
        double length;
        double breadth;
        public Rectangle()
        {
            length = 13.5;
            breadth = 20.5;
        }

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public double Area()
        {
            return length * breadth;
        }
    }
}
