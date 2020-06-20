using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        private int age;
        private string address;
        public TechnicalEmployee(String name, int age, string address) : base(name, 75000)
        {
            this.age = age;
            this.address = address;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Address
        {
            get
            {
                return this.address;
            }
        }
        public override string employeeStatus()
        {
            return toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
