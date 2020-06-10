using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Employee : Person
    {
        protected string department;
        protected double salary;
        string date = "12/12/2020";
        protected DateTime dateHired = new DateTime();

        public Employee() { }
        public Employee(string name, string phone, string email, string department, double salary, DateTime dateHired) : base( name,  phone,  email)
        {
            this.department = department;
            this.salary = salary;
            this.dateHired = dateHired;
        }
       public virtual double CalculateBonus() { return 0; }
        public virtual int CalculateVacation() { return 0; }
        public override string ToString()
        {
            return base.toString() + " department: " + department + ",salary: " + salary + string.Format(", date hired: {0:d}", dateHired);
        }
    }
}
