using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Libby", 2000);
            var employee2 = new TechnicalEmployee("Zaynah", 15, "HN");
            var employee3 = new BussinessEmployee("Winter");
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
            Console.WriteLine(employee2.getName() + "-" + employee2.Age + "-" + employee2.getBaseSalary() + " ." + employee2.Address);
   
            Console.ReadLine();
        }
    }
}
