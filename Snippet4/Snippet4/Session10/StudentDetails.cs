using Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentDetails
    {
        string _studName = "Alexander";
        int _studID = 30;
        public StudentDetails()
        {
            Console.WriteLine("Student Name: " + _studName);
            Console.WriteLine("Student ID: " + _studID);
        }
    }
}
