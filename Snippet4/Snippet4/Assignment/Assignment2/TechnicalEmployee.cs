﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(String name) : base(name, 75000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " has " + this.successfulCheckIns + " successful check ins";
        }
    }
}
