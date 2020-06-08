using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            int numOne = 10;
            int numTwo = 20;
            Snippet1(123, 456);
            Snippet2();
            Snippet3();
            Snippet5();
            Snippet7();
            Console.WriteLine("Value of Num1 and Num2 before calling method " + numOne + "," + numTwo);
            Snippet12(ref numOne, ref numTwo);
            Console.WriteLine("Value of Num1 and Num2 after calling method " + numOne + "," + numTwo);
            Snippet13(out val);
            Snippet14();
            Snippet15();
            Snippet17();
            Snippet18();
            Snippet20();
            Console.ReadKey();
        }

         static void Snippet1(int numOne, int numTwo)
        {
            int addResult = numOne + numTwo;
            Console.WriteLine("Addition = " + addResult);
            
        }
        static void Snippet2()
        {
            Book bk = new Book();
            bk.InputBookName("C# The complete references");
            Console.WriteLine(bk.PrintBook());
        }
        static void Snippet3()
        {
            Book bk1 = new Book();
            bk1.PrintNameAuthor("Manh ", "Hung");
            bk1.PrintNameAuthor(lastName: "Thai", firstName: " Manh");
        }
        static void Snippet5()
        {
            Book bk1 = new Book();
            bk1.printMessage("Wellcome");
        }
        static void Snippet7()
        {
            Calculate.Addition(10, 50);
            Calculate obj = new Calculate();
            obj.Multiply(10, 20);
        }
        static void Snippet8_9_10_11()
        {
            Console.WriteLine("Private, Protect, Public and Internal");
        }
        static void Snippet12(ref int numOne,ref int numTwo)
        {
            numOne = numOne * 2;
            numTwo = numTwo / 2;

        }
        static void Snippet13(out int val)
        {
            val = 2000;
            int dep = val * 5 / 100;
            int amt = val - dep;
            Console.WriteLine("Depreciation Amount: " + dep);
            Console.WriteLine("Reduced value after depreciation: " + amt);

        }
        
        static void Snippet14()
        {
            Calculate cl = new Calculate();
            
            Console.WriteLine("Square of integer value " + cl.Square(5));
            Console.WriteLine("Square of float value " + cl.Square(5.5f));

        }
        static void Snippet15()
        {
            Dimension dm = new Dimension();
            Console.WriteLine("Area of rectangle = " + dm.Area(10.5, 12.5));
        }
        static void Snippet16()
        {
            //Circle objCircle = new Circle();
        }
        
        static void Snippet17()
        {
            Employees objEmp = new Employees("John", 10);
            Console.WriteLine(objEmp.deptName);
            
        }
        static void Snippet18()
        {
            Miltiplication.Method();
        }
        static void Snippet19()
        {
            Rectangle rec = new Rectangle();
            Console.WriteLine("Area of rectangle = " + rec.Area());

            Rectangle rec1 = new Rectangle(2.5,3.6);
            Console.WriteLine("Area of rectangle = " + rec.Area());
        }   
        static void Snippet20()
        {
            Employee objEmp = new Employee(1, "John", 45, 35000);
            Console.WriteLine("EmployeeID: " + objEmp.EmpId);
            Console.WriteLine("Employee Name: " + objEmp.getName());
            Console.WriteLine("Employee Age: " + objEmp.getAge());
            Console.WriteLine("Employee Salary: " + objEmp.getSalary());
            
        }
    }
}
