using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class Employee
    {
        public string _empName;
        public int _empID;
        public Employee()
        {
            _empName = "David";
            _empID = 101;
        }
        public static void ThrowException(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
