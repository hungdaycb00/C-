using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class NumberTester
    {
        NumberDoer objDoer = new NumberDoer();
        public void AcceptDetails()
        {
            int dividend = 0;
            int divisor = 0;
            Console.WriteLine("Enter the value of dividend");
            try
            {
                dividend = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException objForm)
            {
                Console.WriteLine("Error: " + objForm);
            }
            Console.WriteLine("Enter the value of divisor");
            try
            {
                divisor = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException objFormat)
            {
                Console.WriteLine("Error: " + objFormat);
            }
            if ((dividend > 0) || (divisor > 0))
            {
                objDoer.Process(dividend, divisor);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

    }
}
