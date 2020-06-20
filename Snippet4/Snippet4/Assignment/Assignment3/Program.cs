using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
           int result =  Sum(20,40);
            int result1 = Sum(20, 40, 40);
            double result2 = Sum(20, 40.5);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result1}");
            Console.WriteLine($"Calling Sum() that takes doubles, result is: {result2}");
            int first = 9;
            int second = 0;
            Console.WriteLine("Enter number 1: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            second = Convert.ToInt32(Console.ReadLine());
            double result3 = Divide(first, second);
            Console.WriteLine("Divide: {0:N3}", result3);
            GetStudentInformation();

            Console.ReadKey();
        }
        static double Divide(int first, int second)
        {
            double result = 0;
            try
            {
                result = first / second;

            } catch(DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please use different number for second value {0}", ex.Message);
            }
            return result;
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;        
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
        static void GetStudentInformation()
        {
            int birthday = 0;
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            try
            {
                Console.WriteLine("Enter the student's birthday");
                 birthday = Convert.ToInt32(Console.ReadLine());
            } catch(FormatException)
            {
                Console.WriteLine("Enter your age by number, please take again");
                
            }
            
            PrintStudentDetails(firstName, lastName, birthday);

        }
        static void PrintStudentDetails(string first, string last, int birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
    }
    
}
