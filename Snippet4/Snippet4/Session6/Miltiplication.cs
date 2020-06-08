using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Miltiplication
    {
        static int valueOne = 10;
        static int product;
        static Miltiplication()
        {
            Console.WriteLine("Static Constructor initialized");
            product = valueOne * valueOne;
        }

        public static void Method()
        {
            Console.WriteLine("Value of product = " + product);
        }

    }
}
