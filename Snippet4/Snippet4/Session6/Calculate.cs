using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Calculate
    {
        public static void Addition(int val1, int val2)
        {
            Console.WriteLine(val1 + val2);
        }

        public void Multiply(int val1, int val2)
        {
            Console.WriteLine(val1 * val2);
        }
        public static void MainCalculate()
        {
            Calculate.Addition(10, 50);
            Calculate obj = new Calculate();
            obj.Multiply(10, 20);
        }
       public  int Square(int num)
        {
            return num * num;
        }

        public  float Square(float num)
        {
            return num * num;
        }
    }
}
