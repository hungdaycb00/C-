using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice_1_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Atomic Infomation\n ====================\n");
            Atom a = new Atom();
            a.creatAtom();
            a.GetFullInfor();
            Console.ReadLine();
        }
    }
}
