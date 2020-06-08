using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersice_1_Lab3
{
    class Atom
    {
        public int number;
        public string symbol, name;
        public double weight;
        public Atom() { }
        public Atom(int number, string symbol, string name, double weight)
        {
            this.number = number;
            this.symbol = symbol;
            this.name = name;
            this.weight = weight;
        }
        public Atom[] GetFullInfor()
        {
            return GetFullInfor();
        }
        public void creatAtom()
        {
            
            
            Atom[] array = new Atom[3];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter atomic number: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter full name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter symbol: ");
                symbol = Console.ReadLine();
                Console.WriteLine("Enter atomic weight: ");
                weight = Convert.ToDouble(Console.ReadLine());
                array[i] = new Atom(number, symbol, name, weight);
            }
        }
       


    }
}
