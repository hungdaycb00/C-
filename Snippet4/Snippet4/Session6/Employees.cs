using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Employees
    {
        string empName;
        int empAge;
        public string deptName;
        public Employees(string name, int num)
        {
            empName = name;
            empAge = num;
            deptName = "Reseatch & Development";
        }
    }
}
