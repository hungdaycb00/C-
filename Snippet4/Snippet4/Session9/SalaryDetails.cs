using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class SalaryDetails : Employee
    {
        private string empName;
        public string EmployeeName
        {
            get { return empName; }
            set { empName = value; }
        }

        public void Main1()
        {
            SalaryDetails sld1 = new SalaryDetails();
            sld1.EmpName = "Prank";
            sld1.EmpID = 10;
            sld1.Salary = 1000.25F;
            Console.WriteLine("Name: " + sld1.EmpName);
            Console.WriteLine("ID: " + sld1.EmpID);
            Console.WriteLine("Salary: " + sld1.Salary + "$");

        }
    }
}
