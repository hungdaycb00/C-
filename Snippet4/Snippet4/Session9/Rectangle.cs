using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Rectangle : Figure
    {
        float dimesionOne;
        float dimesionTwo;

        public override float DimensionOne {
            set
            {
             if(value < 0)
                {
                    dimesionOne = 0;
                }
                else
                {
                    dimesionOne = value;
                }   
            } 
        }
        public override float DimesionTwo {
            set
            {
                if (value < 0)
                {
                    dimesionTwo = 0;
                }
                else
                {
                    dimesionTwo = value;
                }
            }
            
        }
        public float Area()
        {
            return dimesionOne * dimesionTwo;
        }
    }
}
