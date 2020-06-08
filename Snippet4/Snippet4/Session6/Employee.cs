using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Employee
    {
        private int empId;
        private string empName;
        private int age;
        private double salary;
        public Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine("Constructor for Employee called");
            empId = id;
            empName = name;
            this.age = age;
            salary = sal;

        }
         ~Employee()
        {
            Console.WriteLine("Destructor for Employee called");
        }
        public int EmpId
        { get
            {
                return empId;
            }
            set
            {
                empId = value;
            } 
        }
        public string getName()
        {
            return empName;
        }
        public int getAge()
        {
            return age;
        }
        public double getSalary()
        {
            return salary;
        }
    }
}
