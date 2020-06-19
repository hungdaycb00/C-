using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class NumberDoer
    {
        public void Process(int numOne, int numTwo)
        {
            try
            {
                if (numTwo == 0)
                {
                    throw new DivideByZeroException("Value of divisor is zero");
                }
                else
                {
                    Console.WriteLine("Quotient: " +(numOne / numTwo));
                    Console.WriteLine("Remainder: " +(numOne % numTwo));
                }
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Error: " +objDivide);
            }
        }
    }
}
