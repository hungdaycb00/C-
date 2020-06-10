using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Staff : Employee
    {
        public Staff(string name, string phone, string email, string department, double salary, DateTime dateHired) : base(name, phone, email, department, salary, dateHired)
        {
            
        }
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * salary;
        }
        public override int CalculateVacation()
        {
            DateTime currentYear = DateTime.Now;
            int week = 0;
            if (currentYear.Year - dateHired.Year > 4)
            {
                week = 4;
                
            }
            else
            {
                week = 3;
            }
            return week;
        }
    }
}
