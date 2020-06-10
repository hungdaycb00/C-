using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Person
    {
        string name, phone, email;

        public Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }
        public Person()
        {

        }
            

        public string toString()
        {
            return "name: " + name + ", phone: " + phone + ",email" + email;
        }
    }
}
