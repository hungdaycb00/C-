using Automotive;
using Department;
using Examination;
using Products;
using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility_Vehicle = Automotive.Vehicle.Jeep;

namespace Session10
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet19();
            Console.ReadKey();
        }
        static void Snippet3()
        {
            Console.WriteLine("Hello World");
        }
        static void Snippet4()
        {
            System.Console.WriteLine("Hello World");
            System.Console.WriteLine("This is C# Programming");
            System.Console.WriteLine("You have executed a simple program of C#");
        }
        static void Snippet5()
        {
            Sales s = new Sales();
            s.Hello();
        }
        static void Snippet678()
        {
            Category ctg = new Category();
            SpareParts sp = new SpareParts();
            ctg.Display();
            sp.Display();
        }
        static void Snippet9()
        {
            Computer cp = new Computer();
            cp.Display();
           
        }
        static void Snippet10()
        {
            Students.StudentDetails st = new Students.StudentDetails();
            ScoreReport1 sc = new ScoreReport1();
            Console.WriteLine("Subject: " + sc.Subject);
            Console.WriteLine("Marks: " + sc.Marks);

        }
        static void Snippet11_12_13()
        {
            Contact.Salary.SalaryDetails objSal = new Contact.Salary.SalaryDetails();
            objSal.EmpSalary = 1000.5;
            Console.WriteLine("Salary: " + objSal.EmpSalary);

        }
        static void Snippet14()
        {
            Contact.Salary.SalaryDetails objSal = new Contact.Salary.SalaryDetails();
            objSal.EmpSalary = 1000.5;
            Console.WriteLine("Salary: " + objSal.EmpSalary);
        }
        static void Snippet15_16()
        {
            //creat class AliasExample,Companies
        }
        static void Snippet17_18()
        {
            //creat class Category , Automobile

        }
        static void Snippet19()
        {
            Utility_Vehicle.Category1 objCat = new Utility_Vehicle.Category1();
            objCat.Display();
            Utility_Vehicle::Category1 objCatogery = new Utility_Vehicle::Category1();
            objCatogery.Display();

        }
        static void Snippet20()
        {
            //creat class System
        }
    }
}
