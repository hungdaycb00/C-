using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Metals
    {
        string metaType;
        public Metals(string type)
        {
            metaType = type;
            Console.WriteLine("Metal: \t\t" + metaType);
        }
    }
    class SteelCompany: Metals
    {
        string grade;
        public SteelCompany(string grade) : base("Steel")
        {
            this.grade = grade;
            Console.WriteLine("Metal: \t\t" + this.grade);
        }
    }

    class Automobiles : SteelCompany
    {
        string part;
        public Automobiles(string part) : base("Cast Iron")
        {
            this.part = part;
            Console.WriteLine("Part: \t\t" + this.part);
        }
    }
}
