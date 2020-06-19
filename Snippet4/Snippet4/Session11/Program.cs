using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet8();
            Console.ReadKey();
        }
        static void Snippet1()
        {
            try
            {
                float numOne = 3.14F;
                Object obj = numOne;
                int result = (int)obj;
                Console.WriteLine("Value of numOne = { 0}", result);
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Error : {0}", ex);
            } catch(Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
            }
        }
        static void Snippet2()
        {
            string[] names = { "Jame", "Jack", "Peter" };
            int[] id = { 10, 11, 12 };
            double[] salary = { 1000, 2000, 3000 };
            float[] bonus = new float[3];
            try
            {
                bonus.CopyTo(salary, 0);
            }
            catch(ArrayTypeMismatchException objType)
            {
                Console.WriteLine("Error:" + objType);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        static void Snippet3()
        {
            Employee objEmployee = new Employee();
            Employee objEmp = objEmployee;
            objEmployee = null;
            try
            {
                Console.WriteLine("Employee Name: " + objEmployee._empName);
                Console.WriteLine("Employee ID: " + objEmployee._empID);
            }
            catch (NullReferenceException objNull)
            {
                Console.WriteLine("Error: " + objNull);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: " + objEx);
            }
        }
        static void Snippet4()
        {
            byte numOne = 200;
            byte numTwo = 5;
            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTwo));
                Console.WriteLine("Result = { 0}", result);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error Description: { 0}", objEx.ToString());
                Console.WriteLine("Exception: { 0}", objEx.GetType());
            }
        }
        static void Snippet5()
        {
            byte numOne = 200;
            byte numTwo = 5;
            byte result = 0;
            try
            {
                result = checked((byte)(numOne * numTwo));
                Console.WriteLine("Result = { 0}", result);
            }
            catch (OverflowException objEx)
            {
                Console.WriteLine("Message: { 0}", objEx.Message);
                Console.WriteLine("Source: { 0}", objEx.Source);
                Console.WriteLine("TargetSite: { 0}", objEx.TargetSite);
                Console.WriteLine("StackTrace: { 0}", objEx.StackTrace);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: { 0}", objEx);
            }
        }
        static void Snippet6()
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: " +objDivide);
            }
        }
        static void Snippet7()
        {
            Students objStudents = new Students();
            try
            {
                objStudents._names[4] = "Michael";
            }
            catch (Exception objException)
            {
                Console.WriteLine("Error: " +objException);
            }
        }
        static void Snippet8()
        {
            Console.WriteLine("Throw Example");
            try
            {
                string empName = null;
                Employee.ThrowException(empName);
            }
            catch (ArgumentNullException objNull)
            {
                Console.WriteLine("Exception caught: " +objNull);
            }
        }
        static void Snippet9()
        {
            int numOne = 133;
            int numTwo = 0;
            int result;
            try
            {
                result = numOne / numTwo;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Exception caught: " +objDivide);
            }
            finally
            {
                Console.WriteLine("This finally block will always be executed");
            }
        }
        static void Snippet10()
        {
            NumberTester objTester = new NumberTester();
            objTester.AcceptDetails();
        }
        
        static void Snippet11()
        {
            Product objGoods = new Product();
            objGoods.AcceptDetails();
            objGoods.Display();
        }
        static void Snippet12()
        {
            string[] names = { "John", "James" };
            int numOne = 0;
            int result;
            try
            {
                Console.WriteLine("This is the outer try block");
                try
                {
                    result = 133 / numOne;
                }
                catch (ArithmeticException objMaths)
                {
                    Console.WriteLine("Divide by 0 " + objMaths);
                }
                names[2] = "Smith";
            }
            catch (IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong number of arguments supplied " + objIndex);
            }
        }
        static void Snippet13()
        {
            string[] names = { "John", "James" };
            int numOne = 10;
            int result = 0;
            int index = 0;
            try
            {
                index = 3;
                names[index] = "Smith";
                result = 130 / numOne;
            }
            catch (DivideByZeroException objDivide)
            {
                Console.WriteLine("Divide by 0 " +objDivide);
            }
            catch (IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong number of arguments supplied " +objIndex);
            }
            catch (Exception objException)
            {
                Console.WriteLine("Error: " +objException);
            }
            Console.WriteLine(result);
        }
        static void Snippet14()
        {
            try
            {
                TypeInitError objType = new TypeInitError();
            }
            catch (TypeInitializationException objEx)
            {
                Console.WriteLine("Error: { 0}",objEx);
            }
            catch (Exception objEx)
            {
                Console.WriteLine("Error: { 0}", objEx);
            }
        }
        static void Snippet15()
        {
            try
            {
                throw new CustomMessage("This illustrates creation and catching of custom exception");
            }
            catch (CustomMessage objCustom)
            {
                Console.WriteLine(objCustom.Message);
            }
        }
    }
}
