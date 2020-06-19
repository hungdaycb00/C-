using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    public delegate void Maths(int valOne, int valTwo);

    class MathsDemo
    {
        public static void Addition(int valOne, int valTwo)
        {
            int result = valOne + valTwo;
            Console.WriteLine("Addition: " +valOne + " + " +valTwo + "= " +result);
        }
        public static void Subtraction(int valOne, int valTwo)
        {
            int result = valOne - valTwo;
            Console.WriteLine("Subtraction: " +valOne + " - " +valTwo + "= " +result);
        }
        public static void Multiplication(int valOne, int valTwo)
        {
            int result = valOne * valTwo;
            Console.WriteLine("Multiplication: " +valOne + " * " +valTwo + "= " +
            result);
        }
        public static void Division(int valOne, int valTwo)
        {
            int result = valOne / valTwo;
            Console.WriteLine("Division: " +valOne + " / " +valTwo + "= " +result);
        }
    }
}
