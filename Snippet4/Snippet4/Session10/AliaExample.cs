using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emp = Bank.Accounts.EmployeeDetails;
using IO = System.Console;
namespace Session10
{
    class AliaExample
    {
        public void Display()
        {
            
            Emp.Employees1 objEmp = new Emp.Employees1();
            objEmp.EmpName = "Peter";
            IO.WriteLine("Employee Name: " + objEmp.EmpName);
        }
    }
}
