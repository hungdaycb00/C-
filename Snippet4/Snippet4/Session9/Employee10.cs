using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Employee10
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public void Main1()
        {
            Employee10 emp1 = new Employee10
            {
                Name = "John Doe",
                Age = 24,
                Designation = "Sales Person"
            };
            Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}",emp1.Name, emp1.Age, emp1.Designation);
        }
    }
}
