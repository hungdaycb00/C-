using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Employee : ISet
    {
        int empID;
        string empName;
        public void AcceptDetails(int valOne, string valTwo)
        {
            empID = valOne;
            empName = valTwo;
        }
        
    }
}
