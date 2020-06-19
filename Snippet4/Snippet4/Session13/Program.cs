using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session13
{
    class Program
    {
        static void Main(string[] args)
        {
            Snippet1();
            Console.ReadKey();
        }
        static void Snippet1()
        {
            List<string> objList = new List<string>();
            objList.Add("Francis");
            objList.Add("James");
            objList.Add("Baptista");
            objList.Add("Micheal");
            ReadOnlyCollection<string> objReadOnly = new ReadOnlyCollection<string>(objList);



            Console.WriteLine("Values stored in the read only collection");
            foreach (string str in objReadOnly)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("Total number of elements in the read only collection: " + objReadOnly.Count);
            if (objList.Contains("Francis"))
            {
                objList.Insert(2, "Peter");
            }
            Console.WriteLine("\nValues stored in the list after modification");
            foreach (string str in objReadOnly)
            {
                Console.WriteLine(str);
            }
            string[] array = new string[objReadOnly.Count * 2];
            objReadOnly.CopyTo(array, 5);
            Console.WriteLine("\nTotal number of values that can be stored in the new array: " + array.Length);

            Console.WriteLine("Values in the new array");
            foreach (string str in array)
            {
                if (str == null)
                {
                    Console.WriteLine("null");
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }

        static void Snippet2()
        {
            General<string> objGeneral = new General<string>(3);
            objGeneral.Add("John");
            objGeneral.Add("Patrick");
            objGeneral.Display();
            General<int> objGeneral2 = new General<int>(2);
            objGeneral2.Add(200);
            objGeneral2.Add(35);
            objGeneral2.Display();
        }

        static void Snippet3()
        {
            GenericList<Employee> objList = new GenericList<Employee>();
            objList.Add(new Employee("John", 100));
            objList.Add(new Employee("James", 200));
            objList.Add(new Employee("Patrich", 300));
            objList.Display();
        }

        static void Snippet4()
        {
            int numOne = 23;
            int numTwo = 45;
            Console.WriteLine("Values before swapping: " + numOne + " & " + numTwo);
            SwapNumbers.Swap<int>(ref numOne, ref numTwo);
            Console.WriteLine("Values after swapping: " + numOne + " & " + numTwo);
        }

        static void Snippet5()
        {
            int numOne = 23;
            int numTwo = 45;
            Numbers objInterface = new Numbers();
            Console.Write("\nAddition of two integer values is: ");
            Console.WriteLine(objInterface.Addition(numOne, numTwo));
            Console.Write("Subtraction of two integer values is: ");
            Console.WriteLine(objInterface.Subtraction(numOne, numTwo));
        }

        static void Snippet7()
        {
            DelMath<int> objDel = Numbers2.NumberType;
            DelMath<float> objDel2 = Numbers2.NumberType;
            Console.WriteLine(objDel(10));
            Console.WriteLine(objDel2(108.756F));
        }

        static void Snippet8()
        {
            General2<int, string> objGenOne = new General2<int, string>();
            objGenOne.AcceptValues(10);
            objGenOne.AcceptValues("Smith");
            Console.WriteLine("\nID\tName\tDesignation\tSalary");
            objGenOne.Display();
            General2<string, float> objGenTwo = new General2<string, float>();
            objGenTwo.AcceptValues("Mechanic");
            objGenTwo.AcceptValues(2500);
            Console.Write("\t");
            objGenTwo.Display();
            Console.WriteLine();
        }

        static void Snippet9()
        {
            Student2<string> objStudent = new Student2<string>("Patrick", "Male");
            Console.WriteLine("\nName\t\tSex");
            Console.WriteLine(objStudent.GetValue());
        }

        static void Snippet10()
        {
            Department objDepartment = new Department();
            Console.WriteLine("\nDepartment Names");
            Console.WriteLine();
            foreach (string str in objDepartment)
            {
                Console.WriteLine(str);
            }
        }

        static void Snippet11()
        {
            string[] departmentNames = { "\nMarketing", "Finance", "Information Technology", "Human Resources" };
            GenericDepartment<string> objGeneralName = new GenericDepartment<string>(

            departmentNames);
            foreach (string val in objGeneralName)
            {
                Console.Write(val + "\t");
            }
            int[] departmentID = { 101, 110, 210, 220 };
            GenericDepartment<int> objGeneralID = new GenericDepartment<int>
            (departmentID);
            Console.WriteLine();
            foreach (int val in objGeneralID)
            {
                Console.Write(val + "\t\t");
            }
            Console.WriteLine();
        }

        static void Snippet12()
        {
            NamedIterators objIterator = new NamedIterators();
            foreach (string str in objIterator.GetCarNames())
            {
                Console.WriteLine(str);
            }
        }
    }
}
