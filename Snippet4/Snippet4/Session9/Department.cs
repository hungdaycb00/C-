using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Department
    {
        string deptName;
        int deptID;
        public string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        public int DeptID
        {
            set { deptID = value; }
        }

        public void Display()
        {
            Console.WriteLine("Department Name: " + deptName);
            Console.WriteLine("Department ID: " + deptID);
        }
    }
}
