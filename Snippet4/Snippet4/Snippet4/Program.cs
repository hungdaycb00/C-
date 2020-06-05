using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet4
{
    class Program
    {
        static void Main(string[] args)
        {
            snipet17();
            Console.ReadKey();
        }
        static void snipet1()
        {
            int num = -4;
            if (num < 0)
            {
                Console.WriteLine("This num is negative");
            }
        }
        static void snipet2()
        {
            int num = 10;
            if (num > 0)
            {
                Console.WriteLine("This num is positive");
            }
            else
            {
                Console.WriteLine("This num is negative");
            }
        }
        static void snipet3()
        {
            int num = 13;
            if (num < 0)
            {
                Console.WriteLine("This num is negative");
            }
            else if ((num % 2) != 0)
            {
                Console.WriteLine("This num is odd");
            }
        }
        static void snipet4()
        {
            int yrsOfService = 3;
            double salary = 1500;
            int bonus = 0;
            if (yrsOfService < 5)
            {
                if (salary < 500)
                {
                    bonus = 100;
                }
                else
                {
                    bonus = 200;
                }
            }
            else
            {
                bonus = 700;
            }
            Console.WriteLine("Bonus amount: " + bonus);

        }
        static void snipet5()
        {
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {

                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid values");
                    break;
            }
        }
        static void snipet6()
        {
            int num1;
            int num2;
            int result = 0;
            Console.WriteLine("(1) Addition\n(2) Subtraction\n(3) Multiplication\n(4) Division");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value one");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value two");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Do you want to calculate the quotient or remainder?");
                    Console.WriteLine("(1) Quotient");
                    Console.WriteLine("(2) Remainder");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            result = num1 / num2;
                            break;
                        case 2:
                            result = num1 % num2;
                            break;
                        default:
                            Console.WriteLine("Incorrect Choice");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid values");
                    break;
            }
            Console.WriteLine("Reasult: " + result);
        }
        static void snipet9()
        {
            int i = 0;
            int j;
            while (i <= 5)
            {
                j = 0;
                while (j <= i)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }

        }
        static void snipet10()
        {
            int num = 1;
            Console.WriteLine("Even numbers");
            do
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
                num = num + 1;
            } while (num <= 11);
        }
        static void snipet11()
        {
            int num;
            Console.WriteLine("Even numbers");
            for (num = 1; num <= 11; num++)
            {
                if ((num % 2) == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void snipet12()
        {
            int rows = 2;
            int columns = 2;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("{0}", i + j);
                }
             }
            Console.WriteLine();
        }
        
        static void snipet13()
        {
            Console.WriteLine("Square \t\tCube");
            for (int i = 1, j = 0; i < 11; i++, j++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write("{0} = { 1} \t", i, (i * i));
                    Console.Write("{0} = { 1} \n", j, (j * j * j));
                }
            }
        }
        static void snipet14()
        {
            int investment;
            int returns;
            int expenses;
            int profit;
            int counter = 0;
            for (investment = 1000, returns = 0; returns < investment;)
            {
                Console.WriteLine("Enter the monthly expenditure");
                expenses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the monthly profit");
                profit = Convert.ToInt32(Console.ReadLine());
                investment += expenses;
                returns += profit;
                counter++;
            }
            Console.WriteLine("Number of months to break even: " +counter);
        }
        static void snipet16()
        {
            char c;
            int numOne;
            int numTwo;
            int result;
            for (; ; )
            {
                Console.WriteLine("Enter number one");
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number two");
                numTwo = Convert.ToInt32(Console.ReadLine());
                result = numOne + numTwo;
                Console.WriteLine("Result of Addition: " +result);
                Console.WriteLine("Do you wish to continue [Y / N]");
                c = Convert.ToChar(Console.ReadLine());
                if (c == 'Y' || c == 'y')
                {
                    continue;
                }
                else
                {
                    break;
                }
                }

            }
        static void snipet17()
        {
            int fact = 1;
            int num, i;
            Console.WriteLine("Enter the number whose factorial you wish to calculate");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; fact *= i++) ;
            Console.WriteLine("Factorial: " +fact);
        }
        static void snipet18()
        {
            string[] employeeNames = { "Maria", "Wilson", "Elton", "Garry" };
            Console.WriteLine("Employee Names");
            foreach (string names in employeeNames)
            {
                Console.WriteLine("{ 0} ", names);
            }
        }
        static void snipet19()
        {
            int numOne = 17;
            int numTwo = 2;
            while (numTwo <= numOne - 1)
            {
                if (numOne % numTwo == 0)
                {
                    Console.WriteLine(“Not a Prime Number”);
                    break;
                }
                numTwo++;
            }
            if (numTwo == numOne)
            {
                Console.WriteLine(“Prime Number”);
            }
        }
        static void snipet20()
        {
            Console.WriteLine(“Even numbers in the range of 1 - 10”);
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                Console.Write(i + “ “);
            }
        }
        static void snipet21()
        {
            int i = 0;
        display:
            Console.WriteLine(“Hello World”);
            i++;
            if (i < 5)
            {
                goto display;
            }
        }
        static void snipet22()
        {
            byte num = 0;
            while (true)
            {
                byte fact = 1;
                Console.Write("Please enter a number: ");
                num = Convert.ToByte(Console.ReadLine());
                if (num < 0)
                {
                    goto stop;
                }
                for (byte j = num; j > 0; j--)
                {
                    if (j > 4)
                    {
                        goto stop;
                    }
                    fact *= j;
                    Console.WriteLine("Factorial of { 0} is { 1 }", num, fact);
            }
        stop:
            Console.WriteLine("Exiting the program");
        }
        static void snipet23()
        {

        }
        static void snipet24()
        {

        }
    }
        static void snipet24()
        {
            int yrsOfService = 5;
            double salary = 1250;
            double bonus = 0;
            if (yrsOfService <= 5)
            {
                bonus = 50;
                return;
            }
            else
            {
                bonus = salary * 0.2;
            }
        }
        static void snipet23()
        {
            byte num = 0;
            while (true)
            {
                byte fact = 1;
                Console.Write("Please enter a number: ");
                num = Convert.ToByte(Console.ReadLine());
                if (num < 0)
                {
                    goto stop;
                }
                for (byte j = num; j > 0; j--)
                {
                    if (j > 4)
                    {
                        goto stop;
                    }
                    fact *= j;
                    Console.WriteLine("Factorial of { 0} is { 1 }", num, fact);
                }
            stop:
                Console.WriteLine("Exiting the program");
            }
        }
    }
 }
