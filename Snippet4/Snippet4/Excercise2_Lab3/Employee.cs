using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2_Lab3
{
    class Employee
    {
        string firstName;
        string lastName;
        string address;
        long sin;
        double salary;

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }

        public double Bonus()
        {
            double bonus = salary * sin;
            return bonus;
        }
        public override string ToString()
        {
            return firstName + " " + lastName + "\naddress: " + address + "\nsin: " + sin + "\nsalary: " + salary + "\nBonus: " + Bonus();
        }
    }
}
