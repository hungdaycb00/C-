using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Student
    {
        string stuName = "James";
        string address = "California";
        public virtual void PrintDetails()
        {
            Console.WriteLine("Student Name: " + stuName);
            Console.WriteLine("Address: " + address);
        } 
    }
}
