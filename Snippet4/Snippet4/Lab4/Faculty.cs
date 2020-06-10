using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Faculty : Employee
    {
        private bool isSenior = true;

        public Faculty(string name, string phone, string email, string department, double salary, DateTime dateHired, bool isSenior) : base(name, phone, email, department, salary, dateHired)
        {
            this.isSenior = isSenior;
        }
        public override double CalculateBonus()
        {
            return 1000 + 0.05 * salary;
        }
        public override int CalculateVacation()
        {
            DateTime currentYear = DateTime.Now;
            int week = 0;
            if(currentYear.Year - dateHired.Year > 2)
            {
                week = 5;
                if (isSenior)
                {
                    week = 6;
                }
            }
            else
            {
                week = 4;
            }
            return week;
        }

    }
}
