using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Student : Person
    {
        private string program;

        public Student(string name, string phone, string email, string program) : base(name, phone, email)
        {
            this.program = program;
        }
        
    }
}
