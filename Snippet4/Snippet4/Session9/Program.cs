using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet1();
            Snippet2();
            Snippet3();
            Snippet4();
            Snippet5();
            Snippet6();
            Snippet7();
            Snippet89();
            Snippet10();
            Snippet11();
            Snippet12();
            Snippet13();
            Snippet14();
            Snippet15();
            Console.ReadKey();
        }
        static void Snippet1()
        {
            SalaryDetails sl = new SalaryDetails();
            sl.EmployeeName = "Manh Hung";
            Console.WriteLine("Employee Name: " + sl.EmployeeName);
        }
        static void Snippet2()
        {
            Books bk1 = new Books("Learin C# in 21 days", 10014);
            Console.WriteLine("Book Name: " + bk1.BookName + "\nBook ID: " + bk1.BookId);
        }
        static void Snippet3()
        {
            Department objDepartment = new Department();
            objDepartment.DeptID = 201;
            objDepartment.DeptName = "Sales";
            objDepartment.Display();
        }
        static void Snippet4()
        {
            Product pr1 = new Product("Hard disk", 101);
            pr1.Price = -345.25F;
            pr1.Display();
            
        }
        static void Snippet5()
        {
            University.UniversityName = "University of Maryland";
            University.Department = "Physics";
            Console.WriteLine("University Name: " + University.UniversityName);

            Console.WriteLine("Department Name: " + University.Department);
        }
        static void Snippet6()
        {
            Rectangle rec = new Rectangle();
            rec.DimensionOne = 20;
            rec.DimesionTwo = 4.23F;
            Console.WriteLine("Area of rectangle: " + rec.Area());
        }
        static void Snippet7()
        {
            SalaryDetails sl = new SalaryDetails();
            
            sl.Main1();
        }
        static void Snippet89()
        {
            Employee8 emp = new Employee8();
            emp.Age = 26;
            emp.Name = "Manh Hung";
            emp.Designation = "Sales Person";
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", emp.Name, emp.Age, emp.Designation);
        }
        static void Snippet10()
        {
            Employee10 epl = new Employee10();
            
            epl.Main1();
        }
        static void Snippet11()
        {
            Car car1 = new Car();
            car1.CarType = "Utility Vehicle";
            Ferrari fera = new Ferrari();
            fera.CarType = "Sport Car";
            Console.WriteLine("Car type: " + car1.CarType);
            Console.WriteLine("Ferrari Car type: " + fera.CarType);
        }
        static void Snippet12()
        {
            EmployeeDetails empd = new EmployeeDetails();
            empd[0] = "Jack Anderson";
            empd[1] = "Kate Jones";
            Console.WriteLine("Employee Names: ");
            for (int i = 0; i < 2; i++)
            {
                Console.Write(empd[i] + "\t");
            }
        }
        static void Snippet13()
        {
            EvenNumbers.Main13();
        }
        static void Snippet14()
        {
            Result objResult = new Result();
            objResult[0] = "First";
            objResult[1] = "Pass";
            Student objStudent = new Student();
            objStudent[0] = "Peter";
            objStudent[1] = "Patrick";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(objStudent[i] + "\t" + objResult[i] + " class");
            }
        }
        static void Snippet15()
        {
            Account ac = new Account();
            string[] id = new string[3] { "1001", "1002", "1003" };
            string[] name = new string[3] { "John", "Peter", "Patrick" };
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 1; j++)
                {
                    ac[i, j] = id[counter];
                    ac[i, j+1] = name[counter++];
                }
            }
            Console.WriteLine("IDName");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ac[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
