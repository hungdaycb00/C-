using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class EmployeeDetails
    {
        public string[] empName = new string[2];

        public string this[int index]
        {
            get { return empName[index]; }
            set { empName[index] = value; }
        }

    }
}
