using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    public delegate int Calculation(int numOne, int numTwo);

    class Mathematics
    {
        public static int Addition(int numOne, int numTwo)
        {
            return (numOne + numTwo);
        }
        public int Subtraction(int numOne, int numTwo)
        {
            return (numOne - numTwo);
        }
    }
}
