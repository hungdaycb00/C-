using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet3
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet24();
            Console.ReadKey();
        }
        static void Snippet123()
        {
            int side = 10, height = 5;
            double area = 0.5 * side * height;
            Console.WriteLine("Area: {0}", area);
            Console.ReadLine();
        }
        static void Snippet4()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                checked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result:" + result);

            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
        static void Snippet5()
        {
            byte numOne = 255;
            byte numTwo = 1;
            byte result = 0;
            try
            {
                unchecked
                {
                    result = (byte)(numOne + numTwo);
                }
                Console.WriteLine("Result:" + result);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
        static void Snippet7()
        {
            int value1 = 10, value2 = 2;
            int add = value1 + value2;
            int sub = value1 - value2;
            int mult = value1 * value2;
            int div = value1 / value2;
            int modu = value1 % value2;
            Console.WriteLine("Addition " + add);
            Console.WriteLine("Subtraction " + sub);
            Console.WriteLine("Multiplication " + mult);
            Console.WriteLine("Division " + div);
            Console.WriteLine("Remainder " + modu);
            
        }
        static void Snippet8()
        {
            int value1 = 10, value2 = 2;
            Console.WriteLine("Equal: " + (value1 == value2));
            Console.WriteLine("Not Equal: " + (value1 != value2));
            Console.WriteLine("Greater: " + (value1 > value2));
            Console.WriteLine("Lesser: " + (value1 < value2));
            Console.WriteLine("Greater or Equal: " + (value1 >= value2));
            Console.WriteLine("Lesser or Equal: " + (value1 <= value2));

        }
        static void Snippet9()
        {
            int quantity = 100;
            double price = 5;
            if((quantity > 2000) | (price < 10.5))
            {
                Console.WriteLine("You can buy more goods at a lower price");
            }
        }
        static void Snippet10()
        {
            int quantity = 100;
            double price = 5;
            if ((quantity > 2000) & (price < 10.5))
            {
                Console.WriteLine("You can buy more goods at a lower price");
            }
        }
        static void Snippet11()
        {
            int quantity = 100;
            double price = 50;
            if ((quantity > 2000) ^ (price < 10.5))
            {
                Console.WriteLine("You can buy more goods at a lower price");
            }
        }
        static void Snippet12()
        {
            int result = 56 & 28;
            Console.WriteLine(result);
        }
        static void Snippet13()
        {
            int result = 56 | 28;
            Console.WriteLine(result);
        }
        static void Snippet14()
        {
            int result = 56 ^ 28;
            Console.WriteLine(result);
        }
        static void Snippet15()
        {
            int num = 0;
           
            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exitst between 1 and 10");
            }
        }
        static void Snippet16()
        {
            int num = 6;

            if (num >= 1 || num <= 10)
            {
                Console.WriteLine("The number exists between 1 and 10");
            }
            else
            {
                Console.WriteLine("The number does not exitst between 1 and 10");
            }
        }
        static void Snippet17()
        {
            int num1 = 5;
            int num2 = 10;

                Console.WriteLine("Value=" + num1);
            num1 += 4;
            Console.WriteLine("Value +=4=" + num1);
            num1 -= 8;
            Console.WriteLine("Value -=8=" + num1);
            num1 *= 7;
            Console.WriteLine("Value*=2" + num1);
            num1 /= 2;
            Console.WriteLine("Value/=2" + num1);
            Console.WriteLine("Value1 == Value2: {0}", (num1 == num2));
        }
        static void Snippet18()
        {
            int valueOne = 10;
            Console.WriteLine((4 * 5 - 3) / 6 + 7 - 8 % 5);
            Console.WriteLine(32 < 4 || (8 == 8));
            Console.WriteLine(((valueOne *= 6) > (valueOne += 5)) && ((valueOne / 2) != (valueOne -= 5)));
        }
        static void Snippet19()
        {
            int num = 100;
            int result = num << 1;
            Console.WriteLine("Value before left shift: " + num);
            Console.WriteLine("Value after  left shift: " + result);
             num = 80;
             result = num >> 1;
            Console.WriteLine("Value before left shift: " + num);
            Console.WriteLine("Value after  left shift: " + result);
        }
        static void Snippet20()
        {
            int num = 6;
            string msg = " ";
            if (num < 0)
            {
                msg = "The number" + num + " is negative";
            }
            else if((num%2) == 0)
            {
                msg = "The number " + num + " is even";
            }
            else
            {
                msg = "The number " + num + " is odd";
            }
            if (msg != "")
            {
                Console.WriteLine(msg);
            }
        }
        static void Snippet21()
        {
            int numOne = 5;
            int numTwo = 25;
            int numThree = 15;
            int result = 0;
            if(numOne > numTwo)
            {
                result = (numOne > numThree) ? result = numOne : result = numThree;
            }
            else
            {
                result = (numTwo > numThree) ? result = numTwo : result = numThree;
            }
            if(result != 0)
            {
                Console.WriteLine("{0} is the largest number", result);

            }
        }
        static void Snippet22()
        {
            int value1 = 34;
            float value2;
            value2 = value1;
            Console.WriteLine(value2);
        }
        static void Snippet23()
        {
            double side = 10.5;
            int area;
            area = (int)(side * side);

            Console.WriteLine("Area of the square = {0}", area);
        }
        static void Snippet24()
        {
            float num = 500.5f;
            string strnum = num.ToString();

            Console.WriteLine("Area of the square = {0}", strnum);
            Console.WriteLine(num.ToString());
        }
    }
}
