using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Circle : IMath
    {
        public const float PI = 3.14F;
        protected float Radius;
        protected double AreaOfCircle;
        public virtual void Area()
        {
            AreaOfCircle = (PI * Radius * Radius);
        }
    }
}
