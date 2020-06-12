using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Employee
    {
        string empName;
        int empID;
        float salary;
        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }
        public int EmpID
        {
            get
            {
                return empID;
            }
            set { empID = value; }
        }
        public float Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }
        
    }
}
