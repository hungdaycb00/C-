using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Rectangle : ICalcilate
    {
        float length;
        float breadth;
        
        public Rectangle(float valOne, float valTwo)
        {
            length = valOne;
            breadth = valTwo;
        }

        public double Area()
        {
            return length * breadth;
        }
        
        
    }
}
