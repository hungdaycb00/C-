using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class BussinessEmployee : Employee
    {
        public double bonusBudget = 1000;
        public BussinessEmployee(String name) : base(name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " with a budget of" + this.bonusBudget;
        }
    }
}
