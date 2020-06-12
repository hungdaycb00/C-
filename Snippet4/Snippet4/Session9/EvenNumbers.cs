using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class EvenNumbers : Numbers
    {
        public static void Main13()
        {
            EvenNumbers ev1 = new EvenNumbers();
            ev1[0] = 0;
            ev1[1] = 2;
            ev1[2] = 4;
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(ev1[i]);
            }
        }
    }
}
