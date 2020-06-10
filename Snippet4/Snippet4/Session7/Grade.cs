using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Grade : Student
    {
        string numClass = "Four";
            float percent = 71.25F;
        public override void PrintDetails()
        {
            Console.WriteLine("Class: " + numClass);
            Console.WriteLine("Percentage: " + percent);
        }
        
    }
}
